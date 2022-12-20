namespace BilgiOtel
{
    partial class FrmMesailer
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
            this.btnMesaiTemizle = new System.Windows.Forms.Button();
            this.btnMesaiDuzenle = new System.Windows.Forms.Button();
            this.btnMesaiKaydet = new System.Windows.Forms.Button();
            this.btnMesaiSec = new System.Windows.Forms.Button();
            this.lvwMesaiListe = new System.Windows.Forms.ListView();
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpMesaiBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpMesaiBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.cmbBitisSaatler = new System.Windows.Forms.ComboBox();
            this.cmbBaslangicSaatler = new System.Windows.Forms.ComboBox();
            this.cmbMesaiCalisanlar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnMesaiTemizle
            // 
            this.btnMesaiTemizle.Location = new System.Drawing.Point(76, 140);
            this.btnMesaiTemizle.Name = "btnMesaiTemizle";
            this.btnMesaiTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnMesaiTemizle.TabIndex = 14;
            this.btnMesaiTemizle.Text = "Temizle";
            this.btnMesaiTemizle.UseVisualStyleBackColor = true;
            // 
            // btnMesaiDuzenle
            // 
            this.btnMesaiDuzenle.Location = new System.Drawing.Point(157, 140);
            this.btnMesaiDuzenle.Name = "btnMesaiDuzenle";
            this.btnMesaiDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnMesaiDuzenle.TabIndex = 15;
            this.btnMesaiDuzenle.Text = "Güncelle";
            this.btnMesaiDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnMesaiKaydet
            // 
            this.btnMesaiKaydet.Location = new System.Drawing.Point(238, 140);
            this.btnMesaiKaydet.Name = "btnMesaiKaydet";
            this.btnMesaiKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnMesaiKaydet.TabIndex = 16;
            this.btnMesaiKaydet.Text = "Kaydet";
            this.btnMesaiKaydet.UseVisualStyleBackColor = true;
            this.btnMesaiKaydet.Click += new System.EventHandler(this.btnMesaiKaydet_Click);
            // 
            // btnMesaiSec
            // 
            this.btnMesaiSec.Location = new System.Drawing.Point(707, 218);
            this.btnMesaiSec.Name = "btnMesaiSec";
            this.btnMesaiSec.Size = new System.Drawing.Size(75, 23);
            this.btnMesaiSec.TabIndex = 17;
            this.btnMesaiSec.Text = "Mesai Seç";
            this.btnMesaiSec.UseVisualStyleBackColor = true;
            // 
            // lvwMesaiListe
            // 
            this.lvwMesaiListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29});
            this.lvwMesaiListe.FullRowSelect = true;
            this.lvwMesaiListe.HideSelection = false;
            this.lvwMesaiListe.Location = new System.Drawing.Point(401, 55);
            this.lvwMesaiListe.MultiSelect = false;
            this.lvwMesaiListe.Name = "lvwMesaiListe";
            this.lvwMesaiListe.Size = new System.Drawing.Size(381, 157);
            this.lvwMesaiListe.TabIndex = 13;
            this.lvwMesaiListe.UseCompatibleStateImageBehavior = false;
            this.lvwMesaiListe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Çalışan Ad Soyad";
            this.columnHeader27.Width = 125;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Mesai Başlangıç Tarihi";
            this.columnHeader28.Width = 140;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Mesai Bitiş Tarihi";
            this.columnHeader29.Width = 100;
            // 
            // dtpMesaiBitis
            // 
            this.dtpMesaiBitis.Location = new System.Drawing.Point(138, 109);
            this.dtpMesaiBitis.Name = "dtpMesaiBitis";
            this.dtpMesaiBitis.Size = new System.Drawing.Size(104, 20);
            this.dtpMesaiBitis.TabIndex = 11;
            // 
            // dtpMesaiBaslangic
            // 
            this.dtpMesaiBaslangic.Location = new System.Drawing.Point(138, 84);
            this.dtpMesaiBaslangic.Name = "dtpMesaiBaslangic";
            this.dtpMesaiBaslangic.Size = new System.Drawing.Size(104, 20);
            this.dtpMesaiBaslangic.TabIndex = 12;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(46, 113);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(86, 13);
            this.label39.TabIndex = 8;
            this.label39.Text = "Mesai Bitiş Tarihi";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(19, 88);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(113, 13);
            this.label38.TabIndex = 9;
            this.label38.Text = "Mesai Başlangıç Tarihi";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(42, 59);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(90, 13);
            this.label37.TabIndex = 10;
            this.label37.Text = "Çalışan Ad Soyad";
            // 
            // cmbBitisSaatler
            // 
            this.cmbBitisSaatler.FormattingEnabled = true;
            this.cmbBitisSaatler.Location = new System.Drawing.Point(248, 109);
            this.cmbBitisSaatler.Name = "cmbBitisSaatler";
            this.cmbBitisSaatler.Size = new System.Drawing.Size(65, 21);
            this.cmbBitisSaatler.TabIndex = 5;
            // 
            // cmbBaslangicSaatler
            // 
            this.cmbBaslangicSaatler.FormattingEnabled = true;
            this.cmbBaslangicSaatler.Location = new System.Drawing.Point(248, 82);
            this.cmbBaslangicSaatler.Name = "cmbBaslangicSaatler";
            this.cmbBaslangicSaatler.Size = new System.Drawing.Size(65, 21);
            this.cmbBaslangicSaatler.TabIndex = 6;
            // 
            // cmbMesaiCalisanlar
            // 
            this.cmbMesaiCalisanlar.FormattingEnabled = true;
            this.cmbMesaiCalisanlar.Location = new System.Drawing.Point(138, 55);
            this.cmbMesaiCalisanlar.Name = "cmbMesaiCalisanlar";
            this.cmbMesaiCalisanlar.Size = new System.Drawing.Size(175, 21);
            this.cmbMesaiCalisanlar.TabIndex = 7;
            // 
            // FrmMesailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 297);
            this.Controls.Add(this.btnMesaiTemizle);
            this.Controls.Add(this.btnMesaiDuzenle);
            this.Controls.Add(this.btnMesaiKaydet);
            this.Controls.Add(this.btnMesaiSec);
            this.Controls.Add(this.lvwMesaiListe);
            this.Controls.Add(this.dtpMesaiBitis);
            this.Controls.Add(this.dtpMesaiBaslangic);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.cmbBitisSaatler);
            this.Controls.Add(this.cmbBaslangicSaatler);
            this.Controls.Add(this.cmbMesaiCalisanlar);
            this.Name = "FrmMesailer";
            this.Text = "FrmMesailer";
            this.Load += new System.EventHandler(this.FrmMesailer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMesaiTemizle;
        private System.Windows.Forms.Button btnMesaiDuzenle;
        private System.Windows.Forms.Button btnMesaiKaydet;
        private System.Windows.Forms.Button btnMesaiSec;
        private System.Windows.Forms.ListView lvwMesaiListe;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.DateTimePicker dtpMesaiBitis;
        private System.Windows.Forms.DateTimePicker dtpMesaiBaslangic;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cmbBitisSaatler;
        private System.Windows.Forms.ComboBox cmbBaslangicSaatler;
        private System.Windows.Forms.ComboBox cmbMesaiCalisanlar;
    }
}