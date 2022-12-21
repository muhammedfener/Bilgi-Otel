namespace BilgiOtel
{
    partial class FrmCalismaSaatleri
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
            this.btnCalismaSaatiTemizle = new System.Windows.Forms.Button();
            this.btnCalismaGuncelle = new System.Windows.Forms.Button();
            this.btnCalismaKaydet = new System.Windows.Forms.Button();
            this.btnCalismaSaatiSec = new System.Windows.Forms.Button();
            this.lvwCalismaSaatleri = new System.Windows.Forms.ListView();
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpCalismaBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpCalismaBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.cmbVardiyalar = new System.Windows.Forms.ComboBox();
            this.cmbCalisanlar = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalismaSaatiTemizle
            // 
            this.btnCalismaSaatiTemizle.Location = new System.Drawing.Point(81, 121);
            this.btnCalismaSaatiTemizle.Name = "btnCalismaSaatiTemizle";
            this.btnCalismaSaatiTemizle.Size = new System.Drawing.Size(52, 23);
            this.btnCalismaSaatiTemizle.TabIndex = 16;
            this.btnCalismaSaatiTemizle.Text = "Temizle";
            this.btnCalismaSaatiTemizle.UseVisualStyleBackColor = true;
            this.btnCalismaSaatiTemizle.Click += new System.EventHandler(this.btnCalismaSaatiTemizle_Click);
            // 
            // btnCalismaGuncelle
            // 
            this.btnCalismaGuncelle.Location = new System.Drawing.Point(139, 121);
            this.btnCalismaGuncelle.Name = "btnCalismaGuncelle";
            this.btnCalismaGuncelle.Size = new System.Drawing.Size(63, 23);
            this.btnCalismaGuncelle.TabIndex = 17;
            this.btnCalismaGuncelle.Text = "Güncelle";
            this.btnCalismaGuncelle.UseVisualStyleBackColor = true;
            this.btnCalismaGuncelle.Click += new System.EventHandler(this.btnCalismaGuncelle_Click);
            // 
            // btnCalismaKaydet
            // 
            this.btnCalismaKaydet.Location = new System.Drawing.Point(208, 121);
            this.btnCalismaKaydet.Name = "btnCalismaKaydet";
            this.btnCalismaKaydet.Size = new System.Drawing.Size(58, 23);
            this.btnCalismaKaydet.TabIndex = 18;
            this.btnCalismaKaydet.Text = "Kaydet";
            this.btnCalismaKaydet.UseVisualStyleBackColor = true;
            this.btnCalismaKaydet.Click += new System.EventHandler(this.btnCalismaKaydet_Click);
            // 
            // btnCalismaSaatiSec
            // 
            this.btnCalismaSaatiSec.Location = new System.Drawing.Point(599, 281);
            this.btnCalismaSaatiSec.Name = "btnCalismaSaatiSec";
            this.btnCalismaSaatiSec.Size = new System.Drawing.Size(111, 23);
            this.btnCalismaSaatiSec.TabIndex = 15;
            this.btnCalismaSaatiSec.Text = "Çalışma Saati Seç";
            this.btnCalismaSaatiSec.UseVisualStyleBackColor = true;
            this.btnCalismaSaatiSec.Click += new System.EventHandler(this.btnCalismaSaatiSec_Click);
            // 
            // lvwCalismaSaatleri
            // 
            this.lvwCalismaSaatleri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader26,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25});
            this.lvwCalismaSaatleri.FullRowSelect = true;
            this.lvwCalismaSaatleri.HideSelection = false;
            this.lvwCalismaSaatleri.Location = new System.Drawing.Point(303, 12);
            this.lvwCalismaSaatleri.MultiSelect = false;
            this.lvwCalismaSaatleri.Name = "lvwCalismaSaatleri";
            this.lvwCalismaSaatleri.Size = new System.Drawing.Size(407, 263);
            this.lvwCalismaSaatleri.TabIndex = 14;
            this.lvwCalismaSaatleri.UseCompatibleStateImageBehavior = false;
            this.lvwCalismaSaatleri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "ID";
            this.columnHeader26.Width = 39;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Çalışan Ad Soyad";
            this.columnHeader22.Width = 101;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Vardiya Aralığı";
            this.columnHeader23.Width = 80;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Başlangıç Tarihi";
            this.columnHeader24.Width = 88;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Bitiş Tarihi";
            this.columnHeader25.Width = 93;
            // 
            // dtpCalismaBitis
            // 
            this.dtpCalismaBitis.Location = new System.Drawing.Point(105, 95);
            this.dtpCalismaBitis.Name = "dtpCalismaBitis";
            this.dtpCalismaBitis.Size = new System.Drawing.Size(161, 20);
            this.dtpCalismaBitis.TabIndex = 12;
            // 
            // dtpCalismaBaslangic
            // 
            this.dtpCalismaBaslangic.Location = new System.Drawing.Point(105, 69);
            this.dtpCalismaBaslangic.Name = "dtpCalismaBaslangic";
            this.dtpCalismaBaslangic.Size = new System.Drawing.Size(161, 20);
            this.dtpCalismaBaslangic.TabIndex = 13;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(41, 99);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(55, 13);
            this.label36.TabIndex = 8;
            this.label36.Text = "Bitiş Tarihi";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(14, 73);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(82, 13);
            this.label35.TabIndex = 9;
            this.label35.Text = "Başlangıç Tarihi";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(23, 44);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(73, 13);
            this.label34.TabIndex = 10;
            this.label34.Text = "Vardiya Aralığı";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(37, 15);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 13);
            this.label33.TabIndex = 11;
            this.label33.Text = "Çalışan Adı";
            // 
            // cmbVardiyalar
            // 
            this.cmbVardiyalar.FormattingEnabled = true;
            this.cmbVardiyalar.Location = new System.Drawing.Point(105, 39);
            this.cmbVardiyalar.Name = "cmbVardiyalar";
            this.cmbVardiyalar.Size = new System.Drawing.Size(161, 21);
            this.cmbVardiyalar.TabIndex = 6;
            // 
            // cmbCalisanlar
            // 
            this.cmbCalisanlar.FormattingEnabled = true;
            this.cmbCalisanlar.Location = new System.Drawing.Point(105, 12);
            this.cmbCalisanlar.Name = "cmbCalisanlar";
            this.cmbCalisanlar.Size = new System.Drawing.Size(161, 21);
            this.cmbCalisanlar.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem1.Text = "Düzenle";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.toolStripMenuItem2.Text = "Sil";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // FrmCalismaSaatleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 316);
            this.Controls.Add(this.btnCalismaSaatiTemizle);
            this.Controls.Add(this.btnCalismaGuncelle);
            this.Controls.Add(this.btnCalismaKaydet);
            this.Controls.Add(this.btnCalismaSaatiSec);
            this.Controls.Add(this.lvwCalismaSaatleri);
            this.Controls.Add(this.dtpCalismaBitis);
            this.Controls.Add(this.dtpCalismaBaslangic);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.cmbVardiyalar);
            this.Controls.Add(this.cmbCalisanlar);
            this.Name = "FrmCalismaSaatleri";
            this.Text = "Çalışma Saati Ekle&&Düzenle";
            this.Load += new System.EventHandler(this.FrmCalismaSaatleri_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalismaSaatiTemizle;
        private System.Windows.Forms.Button btnCalismaGuncelle;
        private System.Windows.Forms.Button btnCalismaKaydet;
        private System.Windows.Forms.Button btnCalismaSaatiSec;
        private System.Windows.Forms.ListView lvwCalismaSaatleri;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.DateTimePicker dtpCalismaBitis;
        private System.Windows.Forms.DateTimePicker dtpCalismaBaslangic;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cmbVardiyalar;
        private System.Windows.Forms.ComboBox cmbCalisanlar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}