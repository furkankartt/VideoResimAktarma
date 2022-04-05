using Dapper;
using MediaDevices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace HelpProject
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
            textEditGirisYapan.Text = windowsAdi.Name;
            DatabaseGet();
        }

        WindowsIdentity windowsAdi = WindowsIdentity.GetCurrent();
        SqlConnection myConn = new SqlConnection("Data Source=U220\\SQLEXPRESS;Initial Catalog=Yardim;Integrated Security=True");

        SqlCommand command = new SqlCommand();
        SqlCommand command2 = new SqlCommand();
        public List<string> databaseDosyaYolu = new List<string>();

        string KopyalanacakVideo = @"C:\\Users\\220\\Documents\\GOMCam";
        string KaydetVideo = "C:\\Users\\220\\Desktop\\NewPhotos";
        bool Kontrol;

        public void CMDCalistir(string fileName, string workingDirectory, string arguments, ProcessWindowStyle style)
        {
            var p2 = new Process
            {
                StartInfo =
                 {
                     FileName = fileName,
                     WorkingDirectory = workingDirectory,
                     Arguments = arguments,
                     WindowStyle = style
                 }
            }.Start();
        }

        public void MikrofonKontrol()
        {

            MMDeviceEnumerator names = new MMDeviceEnumerator();
            var devices = names.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            foreach (var device in devices)
                //if (device.FriendlyName == "Jack Mic (Realtek(R) Audio)" || device.FriendlyName == "Headset (Pro8S)")
                    MessageBox.Show(device.FriendlyName);
        }

        public List<YardimUstTable> yardimUst()
        {
            YardimUstTable yrd = new YardimUstTable();
            List<YardimUstTable> yardimUsts = new List<YardimUstTable>();

            yrd.FormAdi = textEditFormAdi.Text;
            yrd.MenuAdi = textEditMenuAdi.Text;
            yrd.VeriGiren = textEditGirisYapan.Text;
            yrd.Aciklama = textEditAciklama.Text;

            yardimUsts.Add(yrd);

            return yardimUsts;
        }

        public List<YardimAltTable> yardimAlt()
        {
            YardimAltTable yrdAlt = new YardimAltTable();
            List<YardimAltTable> yardimAlts = new List<YardimAltTable>();

            yardimAlts.Add(yrdAlt);

            return yardimAlts;
        }

        public void DosyaCek(string KopyalanacakDosyaYolu, string KaydedilecekDosyaYolu)
        {

            string uzantı = null;
            string sabitYol = KaydedilecekDosyaYolu;
            string[] allFiles = Directory.GetFiles(KopyalanacakDosyaYolu, "GOMCAM*.*", SearchOption.AllDirectories);

            if (!allFiles.Any())
            {
                MessageBox.Show("Dosyanızda veri bulunmamaktadır.");
            }
            else
            {
                foreach (var file in allFiles)
                {
                    FileInfo fi = new FileInfo(file);
                    uzantı = fi.Extension;
                    KaydedilecekDosyaYolu = sabitYol + "\\" + DateTime.Now.ToString("yyyyMMddhhmmssfff") + uzantı;
                    databaseDosyaYolu.Add(KaydedilecekDosyaYolu.ToString());
                    fi.CopyTo(@KaydedilecekDosyaYolu, true);
                    fi.Delete();

                    if (databaseDosyaYolu.Count == 0)
                    {
                        MessageBox.Show("Kaydedilecek dosya kalmadı.");
                    }
                }
                if(databaseDosyaYolu.Count > 0)
                {
                    MessageBox.Show("Dosyalarınız aktarıldı, KAYDET butonuna basarak veritabanına kaydedebilirsiniz.");
                    sbKaydet.Enabled = true;
                    sbResimAktar.Enabled = false;
                }
            }
        }

        public void DatabaseInsert(List<YardimUstTable> UstTableList, List<YardimAltTable> AltTableList)
        {
            YardimUstTable yardimUst = new YardimUstTable();
            YardimAltTable yardimAlt = new YardimAltTable();
            
            using (SqlConnection sqlConnection = new SqlConnection(myConn.ConnectionString))
            {
                DateTime date = DateTime.Now;

                foreach (YardimUstTable satir in UstTableList)
                {
                    satir.KayitTarihi = date;
                    sqlConnection.Query<YardimUstTable>(@"INSERT INTO [dbo].[YardimUst]
                                                                               ([FormAdi]
                                                                               ,[MenuAdi]
                                                                               ,[VeriGiren]
                                                                               ,[Tarih]
                                                                               ,[Aciklama])
                                                                         VALUES
                                                                               (@FormAdi
                                                                               ,@MenuAdi
                                                                               ,@VeriGiren
                                                                               ,@KayitTarihi
                                                                               ,@Aciklama)", satir);
                }

                foreach (YardimAltTable satir in AltTableList)
                {
                    for (int i = 0; i < databaseDosyaYolu.Count; i++)
                    {
                        satir.ResimYolu = databaseDosyaYolu[i].ToString();

                        sqlConnection.Query<YardimAltTable>(@"DECLARE @id decimal
                                                              SET @id = IDENT_CURRENT('YardimUst')
                                                              INSERT INTO [dbo].[YardimAlt]
                                                                                ([UstKimlik]
                                                                                ,[ResimYolu])
                                                                         VALUES
                                                                                (@id
                                                                                ,@ResimYolu)", satir);
                        
                    }
                    databaseDosyaYolu.Clear();
                }
                textEditFormAdi.Text = "";
                textEditMenuAdi.Text = "";
                textEditAciklama.Text = "";
                sbKaydet.Enabled = false;
                sbResimAktar.Enabled = true;
            }
        }

        public void DatabaseGet()
        {
            myConn.ConnectionString = "Data Source=U220\\SQLEXPRESS;Initial Catalog=Yardim;Integrated Security=True";
            myConn.Open();
            command.Connection = myConn;
            command.CommandText = ("SELECT YardimUst.FormAdi, YardimUst.MenuAdi, YardimUst.VeriGiren, YardimUst.Tarih, YardimAlt.ResimYolu, YardimUst.Aciklama FROM YardimUst INNER JOIN YardimAlt ON YardimUst.Kimlik = YardimAlt.UstKimlik ORDER BY YardimUst.Kimlik DESC");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvYardim.DataSource = dt;
            myConn.Close();

            dgvYardim.Columns[0].Width = 100;
            dgvYardim.Columns[1].Width = 100;
            dgvYardim.Columns[2].Width = 100;
            dgvYardim.Columns[3].Width = 100;
            dgvYardim.Columns[4].Width = 220;
            dgvYardim.Columns[5].Width = 220;
        }

        private void sbResimAktar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEditFormAdi.Text != "" && textEditMenuAdi.Text != "" && textEditGirisYapan.Text != "" && textEditAciklama.Text != "")
                {
                    if (databaseDosyaYolu.Count == 0)
                    {
                        DosyaCek(KopyalanacakVideo, KaydetVideo);
                    }
                }
                else
                {
                    MessageBox.Show("Boşlukları doldurunuz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.ToString());
            }
        }

        private void sbKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                List<YardimUstTable> aktarilacakUstListe = yardimUst();
                List<YardimAltTable> aktarilacakAltListe = yardimAlt();

                if (aktarilacakUstListe.Count > 0)
                    DatabaseInsert(aktarilacakUstListe, aktarilacakAltListe);
                DatabaseGet();
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.ToString());
            }
        }

        private void sbGomCam_Click(object sender, EventArgs e)
        {
            Kontrol = Directory.Exists(@"C:\Program Files\GOM\GOMCam");
            if (Kontrol)
            {
                CMDCalistir("GOMCam.exe", @"C:\Program Files\GOM\GOMCam", null, ProcessWindowStyle.Normal);
            }
            else
            {
                CMDCalistir("node-v16.14.0-x64.msi", @"\\192.168.100.17\Ses_Dosyalari", null, ProcessWindowStyle.Normal);
            }
        }

        private void sbKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbMicControl_Click(object sender, EventArgs e)
        {
            MikrofonKontrol();
        }
        
    }
}
