namespace BilgiOtel
{
    partial class FrmKampanyalar
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
            this.btnKampanyaSec = new System.Windows.Forms.Button();
            this.dtpKampanyaBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpKampanyaBaslangic = new System.Windows.Forms.DateTimePicker();
            this.rtxKampanyaAciklama = new System.Windows.Forms.RichTextBox();
            this.btnKampanyaTemizle = new System.Windows.Forms.Button();
            this.btnKampanyaDuzenle = new System.Windows.Forms.Button();
            this.btnKampanyaKaydet = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtIndirimOrani = new System.Windows.Forms.TextBox();
            this.txtKampanyaAd = new System.Windows.Forms.TextBox();
            this.lvwKampanyalar = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnKampanyaSec
            // 
            this.btnKampanyaSec.Location = new System.Drawing.Point(691, 179);
            this.btnKampanyaSec.Name = "btnKampanyaSec";
            this.btnKampanyaSec.Size = new System.Drawing.Size(97, 23);
            this.btnKampanyaSec.TabIndex = 21;
            this.btnKampanyaSec.Text = "Kampanya Seç";
            this.btnKampanyaSec.UseVisualStyleBackColor = true;
            this.btnKampanyaSec.Click += new System.EventHandler(this.btnKampanyaSec_Click);
            // 
            // dtpKampanyaBitis
            // 
            this.dtpKampanyaBitis.Location = new System.Drawing.Point(140, 93);
            this.dtpKampanyaBitis.Name = "dtpKampanyaBitis";
            this.dtpKampanyaBitis.Size = new System.Drawing.Size(158, 20);
            this.dtpKampanyaBitis.TabIndex = 19;
            // 
            // dtpKampanyaBaslangic
            // 
            this.dtpKampanyaBaslangic.Location = new System.Drawing.Point(140, 67);
            this.dtpKampanyaBaslangic.Name = "dtpKampanyaBaslangic";
            this.dtpKampanyaBaslangic.Size = new System.Drawing.Size(158, 20);
            this.dtpKampanyaBaslangic.TabIndex = 20;
            // 
            // rtxKampanyaAciklama
            // 
            this.rtxKampanyaAciklama.Location = new System.Drawing.Point(140, 119);
            this.rtxKampanyaAciklama.Name = "rtxKampanyaAciklama";
            this.rtxKampanyaAciklama.Size = new System.Drawing.Size(158, 96);
            this.rtxKampanyaAciklama.TabIndex = 18;
            this.rtxKampanyaAciklama.Text = "";
            // 
            // btnKampanyaTemizle
            // 
            this.btnKampanyaTemizle.Location = new System.Drawing.Point(85, 221);
            this.btnKampanyaTemizle.Name = "btnKampanyaTemizle";
            this.btnKampanyaTemizle.Size = new System.Drawing.Size(62, 23);
            this.btnKampanyaTemizle.TabIndex = 15;
            this.btnKampanyaTemizle.Text = "Temizle";
            this.btnKampanyaTemizle.UseVisualStyleBackColor = true;
            // 
            // btnKampanyaDuzenle
            // 
            this.btnKampanyaDuzenle.Location = new System.Drawing.Point(153, 221);
            this.btnKampanyaDuzenle.Name = "btnKampanyaDuzenle";
            this.btnKampanyaDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnKampanyaDuzenle.TabIndex = 16;
            this.btnKampanyaDuzenle.Text = "Düzenle";
            this.btnKampanyaDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnKampanyaKaydet
            // 
            this.btnKampanyaKaydet.Location = new System.Drawing.Point(234, 221);
            this.btnKampanyaKaydet.Name = "btnKampanyaKaydet";
            this.btnKampanyaKaydet.Size = new System.Drawing.Size(64, 23);
            this.btnKampanyaKaydet.TabIndex = 17;
            this.btnKampanyaKaydet.Text = "Kaydet";
            this.btnKampanyaKaydet.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(19, 119);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(103, 13);
            this.label28.TabIndex = 10;
            this.label28.Text = "Kampanya Açıklama";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(61, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 13);
            this.label27.TabIndex = 11;
            this.label27.Text = "İndirim Bitişi";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(34, 68);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(88, 13);
            this.label26.TabIndex = 12;
            this.label26.Text = "İndirim Başlangıcı";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(57, 42);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "İndirim Oranı";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(47, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 13);
            this.label22.TabIndex = 14;
            this.label22.Text = "Kampanya Adı";
            // 
            // txtIndirimOrani
            // 
            this.txtIndirimOrani.Location = new System.Drawing.Point(140, 38);
            this.txtIndirimOrani.Name = "txtIndirimOrani";
            this.txtIndirimOrani.Size = new System.Drawing.Size(158, 20);
            this.txtIndirimOrani.TabIndex = 8;
            // 
            // txtKampanyaAd
            // 
            this.txtKampanyaAd.Location = new System.Drawing.Point(140, 12);
            this.txtKampanyaAd.Name = "txtKampanyaAd";
            this.txtKampanyaAd.Size = new System.Drawing.Size(158, 20);
            this.txtKampanyaAd.TabIndex = 9;
            // 
            // lvwKampanyalar
            // 
            this.lvwKampanyalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader14,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader15});
            this.lvwKampanyalar.FullRowSelect = true;
            this.lvwKampanyalar.HideSelection = false;
            this.lvwKampanyalar.Location = new System.Drawing.Point(342, 12);
            this.lvwKampanyalar.MultiSelect = false;
            this.lvwKampanyalar.Name = "lvwKampanyalar";
            this.lvwKampanyalar.Size = new System.Drawing.Size(446, 161);
            this.lvwKampanyalar.TabIndex = 7;
            this.lvwKampanyalar.UseCompatibleStateImageBehavior = false;
            this.lvwKampanyalar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Kampanya Adı";
            this.columnHeader11.Width = 90;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "İndirim Oranı";
            this.columnHeader14.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Başlangıç Tarihi";
            this.columnHeader12.Width = 91;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Bitiş Tarihi";
            this.columnHeader13.Width = 82;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Kampanya Açıklama";
            this.columnHeader15.Width = 109;
            // 
            // FrmKampanyalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.btnKampanyaSec);
            this.Controls.Add(this.dtpKampanyaBitis);
            this.Controls.Add(this.dtpKampanyaBaslangic);
            this.Controls.Add(this.rtxKampanyaAciklama);
            this.Controls.Add(this.btnKampanyaTemizle);
            this.Controls.Add(this.btnKampanyaDuzenle);
            this.Controls.Add(this.btnKampanyaKaydet);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtIndirimOrani);
            this.Controls.Add(this.txtKampanyaAd);
            this.Controls.Add(this.lvwKampanyalar);
            this.Name = "FrmKampanyalar";
            this.Text = "FrmKampanyalar";
            this.Load += new System.EventHandler(this.FrmKampanyalar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKampanyaSec;
        private System.Windows.Forms.DateTimePicker dtpKampanyaBitis;
        private System.Windows.Forms.DateTimePicker dtpKampanyaBaslangic;
        private System.Windows.Forms.RichTextBox rtxKampanyaAciklama;
        private System.Windows.Forms.Button btnKampanyaTemizle;
        private System.Windows.Forms.Button btnKampanyaDuzenle;
        private System.Windows.Forms.Button btnKampanyaKaydet;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtIndirimOrani;
        private System.Windows.Forms.TextBox txtKampanyaAd;
        private System.Windows.Forms.ListView lvwKampanyalar;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
    }
}