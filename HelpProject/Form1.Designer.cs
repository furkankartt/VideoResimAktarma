namespace HelpProject
{
    partial class FormHelp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.sbGomCam = new DevExpress.XtraEditors.SimpleButton();
            this.sbKapat = new DevExpress.XtraEditors.SimpleButton();
            this.textEditMenuAdi = new DevExpress.XtraEditors.TextEdit();
            this.textEditGirisYapan = new DevExpress.XtraEditors.TextEdit();
            this.textEditFormAdi = new DevExpress.XtraEditors.TextEdit();
            this.sbKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvYardim = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textEditAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.sbMicControl = new DevExpress.XtraEditors.SimpleButton();
            this.sbResimAktar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenuAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGirisYapan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFormAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYardim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sbGomCam
            // 
            this.sbGomCam.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbGomCam.Appearance.Options.UseFont = true;
            this.sbGomCam.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbGomCam.ImageOptions.Image")));
            this.sbGomCam.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbGomCam.Location = new System.Drawing.Point(672, 490);
            this.sbGomCam.Name = "sbGomCam";
            this.sbGomCam.Size = new System.Drawing.Size(110, 75);
            this.sbGomCam.TabIndex = 7;
            this.sbGomCam.Text = "Gom Cam";
            this.sbGomCam.Click += new System.EventHandler(this.sbGomCam_Click);
            // 
            // sbKapat
            // 
            this.sbKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbKapat.Appearance.Options.UseFont = true;
            this.sbKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbKapat.ImageOptions.Image")));
            this.sbKapat.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbKapat.Location = new System.Drawing.Point(1111, 490);
            this.sbKapat.Name = "sbKapat";
            this.sbKapat.Size = new System.Drawing.Size(110, 75);
            this.sbKapat.TabIndex = 6;
            this.sbKapat.Text = "Kapat";
            this.sbKapat.Click += new System.EventHandler(this.sbKapat_Click);
            // 
            // textEditMenuAdi
            // 
            this.textEditMenuAdi.Location = new System.Drawing.Point(100, 48);
            this.textEditMenuAdi.Name = "textEditMenuAdi";
            this.textEditMenuAdi.Size = new System.Drawing.Size(326, 22);
            this.textEditMenuAdi.TabIndex = 2;
            // 
            // textEditGirisYapan
            // 
            this.textEditGirisYapan.Enabled = false;
            this.textEditGirisYapan.Location = new System.Drawing.Point(100, 84);
            this.textEditGirisYapan.Name = "textEditGirisYapan";
            this.textEditGirisYapan.Size = new System.Drawing.Size(326, 22);
            this.textEditGirisYapan.TabIndex = 3;
            // 
            // textEditFormAdi
            // 
            this.textEditFormAdi.Location = new System.Drawing.Point(100, 10);
            this.textEditFormAdi.Name = "textEditFormAdi";
            this.textEditFormAdi.Size = new System.Drawing.Size(326, 22);
            this.textEditFormAdi.TabIndex = 1;
            // 
            // sbKaydet
            // 
            this.sbKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbKaydet.Appearance.Options.UseFont = true;
            this.sbKaydet.Enabled = false;
            this.sbKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbKaydet.ImageOptions.Image")));
            this.sbKaydet.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbKaydet.Location = new System.Drawing.Point(984, 490);
            this.sbKaydet.Name = "sbKaydet";
            this.sbKaydet.Size = new System.Drawing.Size(110, 75);
            this.sbKaydet.TabIndex = 5;
            this.sbKaydet.Text = "Kaydet";
            this.sbKaydet.Click += new System.EventHandler(this.sbKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Form Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Menü Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kayıt Yapan:";
            // 
            // dgvYardim
            // 
            this.dgvYardim.AllowUserToAddRows = false;
            this.dgvYardim.AllowUserToDeleteRows = false;
            this.dgvYardim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYardim.Location = new System.Drawing.Point(12, 130);
            this.dgvYardim.Name = "dgvYardim";
            this.dgvYardim.ReadOnly = true;
            this.dgvYardim.RowTemplate.Height = 24;
            this.dgvYardim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvYardim.Size = new System.Drawing.Size(1210, 338);
            this.dgvYardim.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Açıklama:";
            // 
            // textEditAciklama
            // 
            this.textEditAciklama.Location = new System.Drawing.Point(562, 12);
            this.textEditAciklama.Name = "textEditAciklama";
            this.textEditAciklama.Size = new System.Drawing.Size(659, 94);
            this.textEditAciklama.TabIndex = 4;
            // 
            // sbMicControl
            // 
            this.sbMicControl.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbMicControl.Appearance.Options.UseFont = true;
            this.sbMicControl.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbMicControl.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbMicControl.ImageOptions.SvgImage")));
            this.sbMicControl.Location = new System.Drawing.Point(458, 490);
            this.sbMicControl.Name = "sbMicControl";
            this.sbMicControl.Size = new System.Drawing.Size(194, 75);
            this.sbMicControl.TabIndex = 8;
            this.sbMicControl.Text = "Mikrofon Kontrolü";
            this.sbMicControl.Click += new System.EventHandler(this.sbMicControl_Click);
            // 
            // sbResimAktar
            // 
            this.sbResimAktar.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbResimAktar.Appearance.Options.UseFont = true;
            this.sbResimAktar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.sbResimAktar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbResimAktar.ImageOptions.SvgImage")));
            this.sbResimAktar.Location = new System.Drawing.Point(801, 490);
            this.sbResimAktar.Name = "sbResimAktar";
            this.sbResimAktar.Size = new System.Drawing.Size(165, 75);
            this.sbResimAktar.TabIndex = 15;
            this.sbResimAktar.Text = "Resimleri Aktar";
            this.sbResimAktar.Click += new System.EventHandler(this.sbResimAktar_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 577);
            this.ControlBox = false;
            this.Controls.Add(this.sbResimAktar);
            this.Controls.Add(this.sbMicControl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvYardim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sbKaydet);
            this.Controls.Add(this.textEditGirisYapan);
            this.Controls.Add(this.textEditMenuAdi);
            this.Controls.Add(this.sbKapat);
            this.Controls.Add(this.sbGomCam);
            this.Controls.Add(this.textEditFormAdi);
            this.Controls.Add(this.textEditAciklama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHelp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Video ve Fotoğraf Kayıt Formu";
            this.Load += new System.EventHandler(this.FormHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditMenuAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGirisYapan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFormAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYardim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAciklama.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbGomCam;
        private DevExpress.XtraEditors.SimpleButton sbKapat;
        private DevExpress.XtraEditors.TextEdit textEditMenuAdi;
        private DevExpress.XtraEditors.TextEdit textEditGirisYapan;
        private DevExpress.XtraEditors.TextEdit textEditFormAdi;
        private DevExpress.XtraEditors.SimpleButton sbKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvYardim;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.MemoEdit textEditAciklama;
        private DevExpress.XtraEditors.SimpleButton sbMicControl;
        private DevExpress.XtraEditors.SimpleButton sbResimAktar;
    }
}

