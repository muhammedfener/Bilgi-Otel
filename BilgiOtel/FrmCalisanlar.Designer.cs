namespace BilgiOtel
{
    partial class FrmCalisanlar
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
            this.components = new System.ComponentModel.Container();
            this.btnCalisanSec = new System.Windows.Forms.Button();
            this.lvwCalisanListesi = new System.Windows.Forms.ListView();
            this.calisanAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calisanTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calisanTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calisanMeslek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calisanAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.calisanUcret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsSagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileButon = new System.Windows.Forms.ToolStripMenuItem();
            this.duzenleButon = new System.Windows.Forms.ToolStripMenuItem();
            this.silButon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalisanTemizle = new System.Windows.Forms.Button();
            this.btnCalisanDuzenle = new System.Windows.Forms.Button();
            this.btnCalisanKaydet = new System.Windows.Forms.Button();
            this.nudSaatlikUcret = new System.Windows.Forms.NumericUpDown();
            this.cmbMeslek = new System.Windows.Forms.ComboBox();
            this.dtpIstenAyrilma = new System.Windows.Forms.DateTimePicker();
            this.dtpIseBaslama = new System.Windows.Forms.DateTimePicker();
            this.rtxAdres = new System.Windows.Forms.RichTextBox();
            this.txtIrtibat = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkCalisanAktifMi = new System.Windows.Forms.CheckBox();
            this.chkIseDevam = new System.Windows.Forms.CheckBox();
            this.cmsSagTik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSaatlikUcret)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalisanSec
            // 
            this.btnCalisanSec.Location = new System.Drawing.Point(668, 368);
            this.btnCalisanSec.Name = "btnCalisanSec";
            this.btnCalisanSec.Size = new System.Drawing.Size(82, 23);
            this.btnCalisanSec.TabIndex = 35;
            this.btnCalisanSec.Text = "Çalışan Seç";
            this.btnCalisanSec.UseVisualStyleBackColor = true;
            this.btnCalisanSec.Click += new System.EventHandler(this.btnCalisanSec_Click);
            // 
            // lvwCalisanListesi
            // 
            this.lvwCalisanListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.calisanAdSoyad,
            this.calisanTC,
            this.calisanTelefon,
            this.calisanMeslek,
            this.calisanAdres,
            this.calisanUcret});
            this.lvwCalisanListesi.ContextMenuStrip = this.cmsSagTik;
            this.lvwCalisanListesi.FullRowSelect = true;
            this.lvwCalisanListesi.HideSelection = false;
            this.lvwCalisanListesi.Location = new System.Drawing.Point(276, 12);
            this.lvwCalisanListesi.MultiSelect = false;
            this.lvwCalisanListesi.Name = "lvwCalisanListesi";
            this.lvwCalisanListesi.Size = new System.Drawing.Size(474, 350);
            this.lvwCalisanListesi.TabIndex = 34;
            this.lvwCalisanListesi.UseCompatibleStateImageBehavior = false;
            this.lvwCalisanListesi.View = System.Windows.Forms.View.Details;
            this.lvwCalisanListesi.DoubleClick += new System.EventHandler(this.lvwCalisanListesi_DoubleClick);
            // 
            // calisanAdSoyad
            // 
            this.calisanAdSoyad.Text = "Ad Soyad";
            this.calisanAdSoyad.Width = 84;
            // 
            // calisanTC
            // 
            this.calisanTC.Text = "TC Kimlik";
            this.calisanTC.Width = 83;
            // 
            // calisanTelefon
            // 
            this.calisanTelefon.Text = "Telefon";
            this.calisanTelefon.Width = 89;
            // 
            // calisanMeslek
            // 
            this.calisanMeslek.Text = "Meslek";
            // 
            // calisanAdres
            // 
            this.calisanAdres.Text = "Adres";
            this.calisanAdres.Width = 84;
            // 
            // calisanUcret
            // 
            this.calisanUcret.Text = "Ücret";
            this.calisanUcret.Width = 67;
            // 
            // cmsSagTik
            // 
            this.cmsSagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileButon,
            this.duzenleButon,
            this.silButon});
            this.cmsSagTik.Name = "cmsSagTik";
            this.cmsSagTik.Size = new System.Drawing.Size(117, 70);
            // 
            // yenileButon
            // 
            this.yenileButon.Name = "yenileButon";
            this.yenileButon.Size = new System.Drawing.Size(116, 22);
            this.yenileButon.Text = "Yenile";
            this.yenileButon.Click += new System.EventHandler(this.yenileButon_Click);
            // 
            // duzenleButon
            // 
            this.duzenleButon.Name = "duzenleButon";
            this.duzenleButon.Size = new System.Drawing.Size(116, 22);
            this.duzenleButon.Text = "Düzenle";
            this.duzenleButon.Click += new System.EventHandler(this.duzenleButon_Click);
            // 
            // silButon
            // 
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(116, 22);
            this.silButon.Text = "Sil";
            this.silButon.Click += new System.EventHandler(this.silButon_Click);
            // 
            // btnCalisanTemizle
            // 
            this.btnCalisanTemizle.Location = new System.Drawing.Point(12, 372);
            this.btnCalisanTemizle.Name = "btnCalisanTemizle";
            this.btnCalisanTemizle.Size = new System.Drawing.Size(54, 23);
            this.btnCalisanTemizle.TabIndex = 33;
            this.btnCalisanTemizle.Text = "Temizle";
            this.btnCalisanTemizle.UseVisualStyleBackColor = true;
            this.btnCalisanTemizle.Click += new System.EventHandler(this.btnCalisanTemizle_Click);
            // 
            // btnCalisanDuzenle
            // 
            this.btnCalisanDuzenle.Location = new System.Drawing.Point(72, 372);
            this.btnCalisanDuzenle.Name = "btnCalisanDuzenle";
            this.btnCalisanDuzenle.Size = new System.Drawing.Size(96, 23);
            this.btnCalisanDuzenle.TabIndex = 32;
            this.btnCalisanDuzenle.Text = "Çalışan Düzenle";
            this.btnCalisanDuzenle.UseVisualStyleBackColor = true;
            this.btnCalisanDuzenle.Click += new System.EventHandler(this.btnCalisanDuzenle_Click);
            // 
            // btnCalisanKaydet
            // 
            this.btnCalisanKaydet.Location = new System.Drawing.Point(174, 372);
            this.btnCalisanKaydet.Name = "btnCalisanKaydet";
            this.btnCalisanKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnCalisanKaydet.TabIndex = 31;
            this.btnCalisanKaydet.Text = "Çalışan Ekle";
            this.btnCalisanKaydet.UseVisualStyleBackColor = true;
            this.btnCalisanKaydet.Click += new System.EventHandler(this.btnCalisanKaydet_Click);
            // 
            // nudSaatlikUcret
            // 
            this.nudSaatlikUcret.DecimalPlaces = 2;
            this.nudSaatlikUcret.Location = new System.Drawing.Point(137, 323);
            this.nudSaatlikUcret.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudSaatlikUcret.Name = "nudSaatlikUcret";
            this.nudSaatlikUcret.Size = new System.Drawing.Size(112, 20);
            this.nudSaatlikUcret.TabIndex = 30;
            // 
            // cmbMeslek
            // 
            this.cmbMeslek.FormattingEnabled = true;
            this.cmbMeslek.Location = new System.Drawing.Point(137, 296);
            this.cmbMeslek.Name = "cmbMeslek";
            this.cmbMeslek.Size = new System.Drawing.Size(112, 21);
            this.cmbMeslek.TabIndex = 29;
            // 
            // dtpIstenAyrilma
            // 
            this.dtpIstenAyrilma.Location = new System.Drawing.Point(137, 270);
            this.dtpIstenAyrilma.Name = "dtpIstenAyrilma";
            this.dtpIstenAyrilma.Size = new System.Drawing.Size(112, 20);
            this.dtpIstenAyrilma.TabIndex = 28;
            // 
            // dtpIseBaslama
            // 
            this.dtpIseBaslama.Location = new System.Drawing.Point(137, 244);
            this.dtpIseBaslama.Name = "dtpIseBaslama";
            this.dtpIseBaslama.Size = new System.Drawing.Size(112, 20);
            this.dtpIseBaslama.TabIndex = 27;
            // 
            // rtxAdres
            // 
            this.rtxAdres.Location = new System.Drawing.Point(137, 116);
            this.rtxAdres.MaxLength = 200;
            this.rtxAdres.Name = "rtxAdres";
            this.rtxAdres.Size = new System.Drawing.Size(112, 96);
            this.rtxAdres.TabIndex = 26;
            this.rtxAdres.Text = "";
            // 
            // txtIrtibat
            // 
            this.txtIrtibat.Location = new System.Drawing.Point(137, 218);
            this.txtIrtibat.MaxLength = 15;
            this.txtIrtibat.Name = "txtIrtibat";
            this.txtIrtibat.Size = new System.Drawing.Size(112, 20);
            this.txtIrtibat.TabIndex = 24;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(137, 90);
            this.txtTC.MaxLength = 80;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(112, 20);
            this.txtTC.TabIndex = 25;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(137, 64);
            this.txtTel.MaxLength = 15;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(112, 20);
            this.txtTel.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "İşten Ayrılma Tarihi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "İşe Başlama Tarihi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(59, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "İrtibat Telefon";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(137, 38);
            this.txtSoyad.MaxLength = 80;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(112, 20);
            this.txtSoyad.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "TC Kimlik";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Çalışan Adres";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(137, 12);
            this.txtAd.MaxLength = 80;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(112, 20);
            this.txtAd.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(88, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Telefon";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(63, 325);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Saatlik Ücret";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Soyad";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(90, 299);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Meslek";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ad";
            // 
            // chkCalisanAktifMi
            // 
            this.chkCalisanAktifMi.AutoSize = true;
            this.chkCalisanAktifMi.Location = new System.Drawing.Point(151, 349);
            this.chkCalisanAktifMi.Name = "chkCalisanAktifMi";
            this.chkCalisanAktifMi.Size = new System.Drawing.Size(98, 17);
            this.chkCalisanAktifMi.TabIndex = 36;
            this.chkCalisanAktifMi.Text = "Çalışan Aktif Mi";
            this.chkCalisanAktifMi.UseVisualStyleBackColor = true;
            // 
            // chkIseDevam
            // 
            this.chkIseDevam.AutoSize = true;
            this.chkIseDevam.Location = new System.Drawing.Point(255, 275);
            this.chkIseDevam.Name = "chkIseDevam";
            this.chkIseDevam.Size = new System.Drawing.Size(15, 14);
            this.chkIseDevam.TabIndex = 37;
            this.chkIseDevam.UseVisualStyleBackColor = true;
            this.chkIseDevam.CheckedChanged += new System.EventHandler(this.chkIseDevam_CheckedChanged);
            // 
            // FrmCalisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 423);
            this.Controls.Add(this.chkIseDevam);
            this.Controls.Add(this.chkCalisanAktifMi);
            this.Controls.Add(this.btnCalisanSec);
            this.Controls.Add(this.lvwCalisanListesi);
            this.Controls.Add(this.btnCalisanTemizle);
            this.Controls.Add(this.btnCalisanDuzenle);
            this.Controls.Add(this.btnCalisanKaydet);
            this.Controls.Add(this.nudSaatlikUcret);
            this.Controls.Add(this.cmbMeslek);
            this.Controls.Add(this.dtpIstenAyrilma);
            this.Controls.Add(this.dtpIseBaslama);
            this.Controls.Add(this.rtxAdres);
            this.Controls.Add(this.txtIrtibat);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Name = "FrmCalisanlar";
            this.Tag = "Çalışan Ekle&&Düzenle";
            this.Text = "Çalışan Ekle&&Düzenle";
            this.Load += new System.EventHandler(this.FrmCalisanlar_Load);
            this.cmsSagTik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSaatlikUcret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalisanSec;
        private System.Windows.Forms.ListView lvwCalisanListesi;
        private System.Windows.Forms.ColumnHeader calisanAdSoyad;
        private System.Windows.Forms.ColumnHeader calisanTC;
        private System.Windows.Forms.ColumnHeader calisanTelefon;
        private System.Windows.Forms.ColumnHeader calisanMeslek;
        private System.Windows.Forms.ColumnHeader calisanAdres;
        private System.Windows.Forms.ColumnHeader calisanUcret;
        private System.Windows.Forms.Button btnCalisanTemizle;
        private System.Windows.Forms.Button btnCalisanDuzenle;
        private System.Windows.Forms.Button btnCalisanKaydet;
        private System.Windows.Forms.NumericUpDown nudSaatlikUcret;
        private System.Windows.Forms.ComboBox cmbMeslek;
        private System.Windows.Forms.DateTimePicker dtpIstenAyrilma;
        private System.Windows.Forms.DateTimePicker dtpIseBaslama;
        private System.Windows.Forms.RichTextBox rtxAdres;
        private System.Windows.Forms.TextBox txtIrtibat;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkCalisanAktifMi;
        private System.Windows.Forms.CheckBox chkIseDevam;
        private System.Windows.Forms.ContextMenuStrip cmsSagTik;
        private System.Windows.Forms.ToolStripMenuItem duzenleButon;
        private System.Windows.Forms.ToolStripMenuItem silButon;
        private System.Windows.Forms.ToolStripMenuItem yenileButon;
    }
}