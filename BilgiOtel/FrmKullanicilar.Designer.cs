namespace BilgiOtel
{
    partial class FrmKullanicilar
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
            this.btnKullaniciSec = new System.Windows.Forms.Button();
            this.btnKullaniciTemizle = new System.Windows.Forms.Button();
            this.btnKullaniciDuzenle = new System.Windows.Forms.Button();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbKullaniciYonetici = new System.Windows.Forms.ComboBox();
            this.cmbKullaniciCalisan = new System.Windows.Forms.ComboBox();
            this.txtKullaniciMail = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.lvwKullaniciListe = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnKullaniciSec
            // 
            this.btnKullaniciSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciSec.Location = new System.Drawing.Point(691, 194);
            this.btnKullaniciSec.Name = "btnKullaniciSec";
            this.btnKullaniciSec.Size = new System.Drawing.Size(97, 36);
            this.btnKullaniciSec.TabIndex = 21;
            this.btnKullaniciSec.Text = "Kullanıcı Seç";
            this.btnKullaniciSec.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciTemizle
            // 
            this.btnKullaniciTemizle.Location = new System.Drawing.Point(12, 151);
            this.btnKullaniciTemizle.Name = "btnKullaniciTemizle";
            this.btnKullaniciTemizle.Size = new System.Drawing.Size(56, 23);
            this.btnKullaniciTemizle.TabIndex = 20;
            this.btnKullaniciTemizle.Text = "Temizle";
            this.btnKullaniciTemizle.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciDuzenle
            // 
            this.btnKullaniciDuzenle.Location = new System.Drawing.Point(74, 151);
            this.btnKullaniciDuzenle.Name = "btnKullaniciDuzenle";
            this.btnKullaniciDuzenle.Size = new System.Drawing.Size(101, 23);
            this.btnKullaniciDuzenle.TabIndex = 18;
            this.btnKullaniciDuzenle.Text = "Kullanıcı Düzenle";
            this.btnKullaniciDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(181, 151);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(84, 23);
            this.btnKullaniciEkle.TabIndex = 19;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(23, 118);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Yönetici Adı";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(28, 91);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(59, 13);
            this.label23.TabIndex = 14;
            this.label23.Text = "Çalışan Adı";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(61, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Mail";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(58, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Şifre";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Kullanıcı Adı";
            // 
            // cmbKullaniciYonetici
            // 
            this.cmbKullaniciYonetici.FormattingEnabled = true;
            this.cmbKullaniciYonetici.Location = new System.Drawing.Point(92, 115);
            this.cmbKullaniciYonetici.Name = "cmbKullaniciYonetici";
            this.cmbKullaniciYonetici.Size = new System.Drawing.Size(173, 21);
            this.cmbKullaniciYonetici.TabIndex = 11;
            // 
            // cmbKullaniciCalisan
            // 
            this.cmbKullaniciCalisan.FormattingEnabled = true;
            this.cmbKullaniciCalisan.Location = new System.Drawing.Point(92, 88);
            this.cmbKullaniciCalisan.Name = "cmbKullaniciCalisan";
            this.cmbKullaniciCalisan.Size = new System.Drawing.Size(173, 21);
            this.cmbKullaniciCalisan.TabIndex = 12;
            // 
            // txtKullaniciMail
            // 
            this.txtKullaniciMail.Location = new System.Drawing.Point(92, 63);
            this.txtKullaniciMail.Name = "txtKullaniciMail";
            this.txtKullaniciMail.Size = new System.Drawing.Size(173, 20);
            this.txtKullaniciMail.TabIndex = 8;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(92, 37);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(173, 20);
            this.txtKullaniciSifre.TabIndex = 9;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(92, 11);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(173, 20);
            this.txtKullaniciAd.TabIndex = 10;
            // 
            // lvwKullaniciListe
            // 
            this.lvwKullaniciListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10});
            this.lvwKullaniciListe.FullRowSelect = true;
            this.lvwKullaniciListe.HideSelection = false;
            this.lvwKullaniciListe.Location = new System.Drawing.Point(284, 12);
            this.lvwKullaniciListe.MultiSelect = false;
            this.lvwKullaniciListe.Name = "lvwKullaniciListe";
            this.lvwKullaniciListe.Size = new System.Drawing.Size(504, 176);
            this.lvwKullaniciListe.TabIndex = 7;
            this.lvwKullaniciListe.UseCompatibleStateImageBehavior = false;
            this.lvwKullaniciListe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kullanıcı Adı";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Şifre";
            this.columnHeader6.Width = 65;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mail";
            this.columnHeader8.Width = 85;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kayıt Tarihi";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Çalışan Ad";
            this.columnHeader9.Width = 81;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Yönetici Ad";
            this.columnHeader10.Width = 81;
            // 
            // FrmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKullaniciSec);
            this.Controls.Add(this.btnKullaniciTemizle);
            this.Controls.Add(this.btnKullaniciDuzenle);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cmbKullaniciYonetici);
            this.Controls.Add(this.cmbKullaniciCalisan);
            this.Controls.Add(this.txtKullaniciMail);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.lvwKullaniciListe);
            this.Name = "FrmKullanicilar";
            this.Text = "FrmKullanicilar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciSec;
        private System.Windows.Forms.Button btnKullaniciTemizle;
        private System.Windows.Forms.Button btnKullaniciDuzenle;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbKullaniciYonetici;
        private System.Windows.Forms.ComboBox cmbKullaniciCalisan;
        private System.Windows.Forms.TextBox txtKullaniciMail;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.ListView lvwKullaniciListe;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}