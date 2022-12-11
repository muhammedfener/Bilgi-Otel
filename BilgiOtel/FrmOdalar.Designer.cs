namespace BilgiOtel
{
    partial class FrmOdalar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdaTemizle = new System.Windows.Forms.Button();
            this.nudOdaNumara = new System.Windows.Forms.NumericUpDown();
            this.chkKralOdasi = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxOdaAciklama = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOdaSec = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwOdaListesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nudOdaKat = new System.Windows.Forms.NumericUpDown();
            this.btnOdaDuzenle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.nudOdaKisi = new System.Windows.Forms.NumericUpDown();
            this.cklOzellikler = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCiftKisilikYatak = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudTekKisilikYatak = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudOdaFiyat = new System.Windows.Forms.NumericUpDown();
            this.chkOdaAktifMi = new System.Windows.Forms.CheckBox();
            this.cmsSagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileButon = new System.Windows.Forms.ToolStripMenuItem();
            this.duzenleButon = new System.Windows.Forms.ToolStripMenuItem();
            this.silButon = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaNumara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaKat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaKisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCiftKisilikYatak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTekKisilikYatak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaFiyat)).BeginInit();
            this.cmsSagTik.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Oda Numara: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOdaTemizle
            // 
            this.btnOdaTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaTemizle.Location = new System.Drawing.Point(12, 384);
            this.btnOdaTemizle.Name = "btnOdaTemizle";
            this.btnOdaTemizle.Size = new System.Drawing.Size(73, 24);
            this.btnOdaTemizle.TabIndex = 76;
            this.btnOdaTemizle.Text = "Temizle";
            this.btnOdaTemizle.UseVisualStyleBackColor = true;
            this.btnOdaTemizle.Click += new System.EventHandler(this.btnOdaTemizle_Click);
            // 
            // nudOdaNumara
            // 
            this.nudOdaNumara.Location = new System.Drawing.Point(170, 12);
            this.nudOdaNumara.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudOdaNumara.Name = "nudOdaNumara";
            this.nudOdaNumara.Size = new System.Drawing.Size(109, 20);
            this.nudOdaNumara.TabIndex = 56;
            // 
            // chkKralOdasi
            // 
            this.chkKralOdasi.AutoSize = true;
            this.chkKralOdasi.Location = new System.Drawing.Point(115, 270);
            this.chkKralOdasi.Name = "chkKralOdasi";
            this.chkKralOdasi.Size = new System.Drawing.Size(74, 17);
            this.chkKralOdasi.TabIndex = 75;
            this.chkKralOdasi.Text = "Kral Odası";
            this.chkKralOdasi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Oda Kat: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxOdaAciklama
            // 
            this.rtxOdaAciklama.Location = new System.Drawing.Point(23, 293);
            this.rtxOdaAciklama.Name = "rtxOdaAciklama";
            this.rtxOdaAciklama.Size = new System.Drawing.Size(256, 85);
            this.rtxOdaAciklama.TabIndex = 74;
            this.rtxOdaAciklama.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Oda Kişi Sayısı: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOdaSec
            // 
            this.btnOdaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaSec.Location = new System.Drawing.Point(634, 371);
            this.btnOdaSec.Name = "btnOdaSec";
            this.btnOdaSec.Size = new System.Drawing.Size(86, 34);
            this.btnOdaSec.TabIndex = 73;
            this.btnOdaSec.Text = "Oda Seç";
            this.btnOdaSec.UseVisualStyleBackColor = true;
            this.btnOdaSec.Click += new System.EventHandler(this.btnOdaSec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Oda Fiyat: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvwOdaListesi
            // 
            this.lvwOdaListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwOdaListesi.ContextMenuStrip = this.cmsSagTik;
            this.lvwOdaListesi.FullRowSelect = true;
            this.lvwOdaListesi.HideSelection = false;
            this.lvwOdaListesi.Location = new System.Drawing.Point(296, 12);
            this.lvwOdaListesi.Name = "lvwOdaListesi";
            this.lvwOdaListesi.Size = new System.Drawing.Size(424, 341);
            this.lvwOdaListesi.TabIndex = 72;
            this.lvwOdaListesi.UseCompatibleStateImageBehavior = false;
            this.lvwOdaListesi.View = System.Windows.Forms.View.Details;
            this.lvwOdaListesi.DoubleClick += new System.EventHandler(this.lvwOdaListesi_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Oda Numarası";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Oda Katı";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oda Kişi Sayısı";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Oda Fiyat";
            this.columnHeader4.Width = 75;
            // 
            // nudOdaKat
            // 
            this.nudOdaKat.Location = new System.Drawing.Point(170, 38);
            this.nudOdaKat.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudOdaKat.Name = "nudOdaKat";
            this.nudOdaKat.Size = new System.Drawing.Size(109, 20);
            this.nudOdaKat.TabIndex = 64;
            // 
            // btnOdaDuzenle
            // 
            this.btnOdaDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaDuzenle.Location = new System.Drawing.Point(91, 384);
            this.btnOdaDuzenle.Name = "btnOdaDuzenle";
            this.btnOdaDuzenle.Size = new System.Drawing.Size(108, 24);
            this.btnOdaDuzenle.TabIndex = 71;
            this.btnOdaDuzenle.Text = "Odayı Düzenle";
            this.btnOdaDuzenle.UseVisualStyleBackColor = true;
            this.btnOdaDuzenle.Click += new System.EventHandler(this.btnOdaDuzenle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Tek Kişilik Yatak Sayısı: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaEkle.Location = new System.Drawing.Point(205, 384);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(74, 24);
            this.btnOdaEkle.TabIndex = 70;
            this.btnOdaEkle.Text = "Oda Ekle";
            this.btnOdaEkle.UseVisualStyleBackColor = true;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);
            // 
            // nudOdaKisi
            // 
            this.nudOdaKisi.Location = new System.Drawing.Point(170, 64);
            this.nudOdaKisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudOdaKisi.Name = "nudOdaKisi";
            this.nudOdaKisi.Size = new System.Drawing.Size(109, 20);
            this.nudOdaKisi.TabIndex = 65;
            // 
            // cklOzellikler
            // 
            this.cklOzellikler.CheckOnClick = true;
            this.cklOzellikler.FormattingEnabled = true;
            this.cklOzellikler.Items.AddRange(new object[] {
            "Saç Kurutma Makinesi",
            "Minibar",
            "TV",
            "Kablosuz İnternet",
            "Klima",
            "Balkon"});
            this.cklOzellikler.Location = new System.Drawing.Point(136, 168);
            this.cklOzellikler.Name = "cklOzellikler";
            this.cklOzellikler.Size = new System.Drawing.Size(143, 94);
            this.cklOzellikler.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Çift Kişilik Yatak Sayısı: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudCiftKisilikYatak
            // 
            this.nudCiftKisilikYatak.Location = new System.Drawing.Point(170, 142);
            this.nudCiftKisilikYatak.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCiftKisilikYatak.Name = "nudCiftKisilikYatak";
            this.nudCiftKisilikYatak.Size = new System.Drawing.Size(109, 20);
            this.nudCiftKisilikYatak.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Oda Özellikleri: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTekKisilikYatak
            // 
            this.nudTekKisilikYatak.Location = new System.Drawing.Point(170, 116);
            this.nudTekKisilikYatak.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTekKisilikYatak.Name = "nudTekKisilikYatak";
            this.nudTekKisilikYatak.Size = new System.Drawing.Size(109, 20);
            this.nudTekKisilikYatak.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Oda Açıklama:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudOdaFiyat
            // 
            this.nudOdaFiyat.Location = new System.Drawing.Point(170, 90);
            this.nudOdaFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudOdaFiyat.Name = "nudOdaFiyat";
            this.nudOdaFiyat.Size = new System.Drawing.Size(109, 20);
            this.nudOdaFiyat.TabIndex = 66;
            // 
            // chkOdaAktifMi
            // 
            this.chkOdaAktifMi.AutoSize = true;
            this.chkOdaAktifMi.Location = new System.Drawing.Point(195, 270);
            this.chkOdaAktifMi.Name = "chkOdaAktifMi";
            this.chkOdaAktifMi.Size = new System.Drawing.Size(84, 17);
            this.chkOdaAktifMi.TabIndex = 77;
            this.chkOdaAktifMi.Text = "Oda Aktif Mi";
            this.chkOdaAktifMi.UseVisualStyleBackColor = true;
            // 
            // cmsSagTik
            // 
            this.cmsSagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileButon,
            this.duzenleButon,
            this.silButon});
            this.cmsSagTik.Name = "cmsSagTik";
            this.cmsSagTik.Size = new System.Drawing.Size(181, 92);
            // 
            // yenileButon
            // 
            this.yenileButon.Name = "yenileButon";
            this.yenileButon.Size = new System.Drawing.Size(180, 22);
            this.yenileButon.Text = "Yenile";
            this.yenileButon.Click += new System.EventHandler(this.yenileButon_Click);
            // 
            // duzenleButon
            // 
            this.duzenleButon.Name = "duzenleButon";
            this.duzenleButon.Size = new System.Drawing.Size(180, 22);
            this.duzenleButon.Text = "Düzenle";
            this.duzenleButon.Click += new System.EventHandler(this.duzenleButon_Click);
            // 
            // silButon
            // 
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(180, 22);
            this.silButon.Text = "Sil";
            this.silButon.Click += new System.EventHandler(this.silButon_Click);
            // 
            // FrmOdalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 421);
            this.Controls.Add(this.chkOdaAktifMi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdaTemizle);
            this.Controls.Add(this.nudOdaNumara);
            this.Controls.Add(this.chkKralOdasi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxOdaAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdaSec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvwOdaListesi);
            this.Controls.Add(this.nudOdaKat);
            this.Controls.Add(this.btnOdaDuzenle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOdaEkle);
            this.Controls.Add(this.nudOdaKisi);
            this.Controls.Add(this.cklOzellikler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudCiftKisilikYatak);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudTekKisilikYatak);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudOdaFiyat);
            this.Name = "FrmOdalar";
            this.Tag = "Oda Ekle&&Düzenle";
            this.Text = "Odalar";
            this.Load += new System.EventHandler(this.FrmOdalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaNumara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaKat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaKisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCiftKisilikYatak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTekKisilikYatak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaFiyat)).EndInit();
            this.cmsSagTik.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaTemizle;
        private System.Windows.Forms.NumericUpDown nudOdaNumara;
        private System.Windows.Forms.CheckBox chkKralOdasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxOdaAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOdaSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwOdaListesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown nudOdaKat;
        private System.Windows.Forms.Button btnOdaDuzenle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.NumericUpDown nudOdaKisi;
        private System.Windows.Forms.CheckedListBox cklOzellikler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCiftKisilikYatak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudTekKisilikYatak;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudOdaFiyat;
        private System.Windows.Forms.CheckBox chkOdaAktifMi;
        private System.Windows.Forms.ContextMenuStrip cmsSagTik;
        private System.Windows.Forms.ToolStripMenuItem yenileButon;
        private System.Windows.Forms.ToolStripMenuItem duzenleButon;
        private System.Windows.Forms.ToolStripMenuItem silButon;
    }
}