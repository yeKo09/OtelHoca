
namespace OtelHoca.UI
{
    partial class FormFaturalandirma
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMusteriBilgileri = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGunSayisi = new System.Windows.Forms.Label();
            this.btnHizmetleriEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.flEkHizmetler = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEkHizmetler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Musteri :";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(152, 36);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(195, 21);
            this.cmbMusteri.TabIndex = 1;
            this.cmbMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbMusteri_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Musteri Bilgileri :";
            // 
            // lblMusteriBilgileri
            // 
            this.lblMusteriBilgileri.AutoSize = true;
            this.lblMusteriBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriBilgileri.Location = new System.Drawing.Point(151, 85);
            this.lblMusteriBilgileri.Name = "lblMusteriBilgileri";
            this.lblMusteriBilgileri.Size = new System.Drawing.Size(16, 17);
            this.lblMusteriBilgileri.TabIndex = 3;
            this.lblMusteriBilgileri.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cikis Tarihi :";
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Location = new System.Drawing.Point(154, 134);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtCikisTarihi.TabIndex = 5;
            this.dtCikisTarihi.ValueChanged += new System.EventHandler(this.dtCikisTarihi_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kalinan Gun Sayisi :";
            // 
            // lblGunSayisi
            // 
            this.lblGunSayisi.AutoSize = true;
            this.lblGunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunSayisi.Location = new System.Drawing.Point(151, 178);
            this.lblGunSayisi.Name = "lblGunSayisi";
            this.lblGunSayisi.Size = new System.Drawing.Size(16, 17);
            this.lblGunSayisi.TabIndex = 7;
            this.lblGunSayisi.Text = "0";
            // 
            // btnHizmetleriEkle
            // 
            this.btnHizmetleriEkle.Location = new System.Drawing.Point(86, 338);
            this.btnHizmetleriEkle.Name = "btnHizmetleriEkle";
            this.btnHizmetleriEkle.Size = new System.Drawing.Size(203, 36);
            this.btnHizmetleriEkle.TabIndex = 9;
            this.btnHizmetleriEkle.Text = "Hizmetleri Ekle ve Fiyatı Hesapla";
            this.btnHizmetleriEkle.UseVisualStyleBackColor = true;
            this.btnHizmetleriEkle.Click += new System.EventHandler(this.btnHizmetleriEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(407, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Toplam Fiyat :";
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamFiyat.Location = new System.Drawing.Point(539, 259);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(16, 17);
            this.lblToplamFiyat.TabIndex = 11;
            this.lblToplamFiyat.Text = "0";
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(436, 302);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(108, 40);
            this.btnOdemeYap.TabIndex = 12;
            this.btnOdemeYap.Text = "Odeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // flEkHizmetler
            // 
            this.flEkHizmetler.Location = new System.Drawing.Point(13, 250);
            this.flEkHizmetler.Name = "flEkHizmetler";
            this.flEkHizmetler.Size = new System.Drawing.Size(334, 72);
            this.flEkHizmetler.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(96, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ek Hizmetler : ";
            // 
            // lblEkHizmetler
            // 
            this.lblEkHizmetler.AutoSize = true;
            this.lblEkHizmetler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkHizmetler.Location = new System.Drawing.Point(201, 221);
            this.lblEkHizmetler.Name = "lblEkHizmetler";
            this.lblEkHizmetler.Size = new System.Drawing.Size(16, 17);
            this.lblEkHizmetler.TabIndex = 15;
            this.lblEkHizmetler.Text = "0";
            // 
            // FormFaturalandirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 451);
            this.Controls.Add(this.lblEkHizmetler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.flEkHizmetler);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.lblToplamFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHizmetleriEkle);
            this.Controls.Add(this.lblGunSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtCikisTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMusteriBilgileri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label1);
            this.Name = "FormFaturalandirma";
            this.Text = "FormFaturalandirma";
            this.Load += new System.EventHandler(this.FormFaturalandirma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMusteriBilgileri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGunSayisi;
        private System.Windows.Forms.Button btnHizmetleriEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.FlowLayoutPanel flEkHizmetler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEkHizmetler;
    }
}