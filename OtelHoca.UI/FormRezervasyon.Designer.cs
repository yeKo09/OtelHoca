
namespace OtelHoca.UI
{
    partial class FormRezervasyon
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
            this.ftKat4 = new System.Windows.Forms.FlowLayoutPanel();
            this.ftKat3 = new System.Windows.Forms.FlowLayoutPanel();
            this.ftKat2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ftKat1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.numYas = new System.Windows.Forms.NumericUpDown();
            this.mtxtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.mTxtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.gbMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numYas)).BeginInit();
            this.gbMusteriBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKisiSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // ftKat4
            // 
            this.ftKat4.Location = new System.Drawing.Point(42, 33);
            this.ftKat4.Name = "ftKat4";
            this.ftKat4.Size = new System.Drawing.Size(413, 74);
            this.ftKat4.TabIndex = 0;
            // 
            // ftKat3
            // 
            this.ftKat3.Location = new System.Drawing.Point(42, 159);
            this.ftKat3.Name = "ftKat3";
            this.ftKat3.Size = new System.Drawing.Size(413, 74);
            this.ftKat3.TabIndex = 1;
            // 
            // ftKat2
            // 
            this.ftKat2.Location = new System.Drawing.Point(42, 276);
            this.ftKat2.Name = "ftKat2";
            this.ftKat2.Size = new System.Drawing.Size(413, 74);
            this.ftKat2.TabIndex = 1;
            // 
            // ftKat1
            // 
            this.ftKat1.Location = new System.Drawing.Point(42, 401);
            this.ftKat1.Name = "ftKat1";
            this.ftKat1.Size = new System.Drawing.Size(413, 74);
            this.ftKat1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(92, 52);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(170, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TcNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TelNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yas";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(92, 407);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 35);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // numYas
            // 
            this.numYas.Location = new System.Drawing.Point(92, 190);
            this.numYas.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numYas.Name = "numYas";
            this.numYas.Size = new System.Drawing.Size(170, 20);
            this.numYas.TabIndex = 9;
            this.numYas.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // mtxtTcNo
            // 
            this.mtxtTcNo.Location = new System.Drawing.Point(92, 104);
            this.mtxtTcNo.Mask = "00000000000";
            this.mtxtTcNo.Name = "mtxtTcNo";
            this.mtxtTcNo.Size = new System.Drawing.Size(170, 20);
            this.mtxtTcNo.TabIndex = 10;
            this.mtxtTcNo.ValidatingType = typeof(int);
            // 
            // mTxtTelNo
            // 
            this.mTxtTelNo.Location = new System.Drawing.Point(92, 146);
            this.mTxtTelNo.Mask = "(999) 000-0000";
            this.mTxtTelNo.Name = "mTxtTelNo";
            this.mTxtTelNo.Size = new System.Drawing.Size(170, 20);
            this.mTxtTelNo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giris Tarihi";
            // 
            // dtGirisTarihi
            // 
            this.dtGirisTarihi.Location = new System.Drawing.Point(92, 281);
            this.dtGirisTarihi.Name = "dtGirisTarihi";
            this.dtGirisTarihi.Size = new System.Drawing.Size(170, 20);
            this.dtGirisTarihi.TabIndex = 15;
            // 
            // gbMusteriBilgileri
            // 
            this.gbMusteriBilgileri.Controls.Add(this.numKisiSayisi);
            this.gbMusteriBilgileri.Controls.Add(this.label6);
            this.gbMusteriBilgileri.Controls.Add(this.dtGirisTarihi);
            this.gbMusteriBilgileri.Controls.Add(this.label5);
            this.gbMusteriBilgileri.Controls.Add(this.mTxtTelNo);
            this.gbMusteriBilgileri.Controls.Add(this.mtxtTcNo);
            this.gbMusteriBilgileri.Controls.Add(this.numYas);
            this.gbMusteriBilgileri.Controls.Add(this.btnEkle);
            this.gbMusteriBilgileri.Controls.Add(this.label4);
            this.gbMusteriBilgileri.Controls.Add(this.label3);
            this.gbMusteriBilgileri.Controls.Add(this.label2);
            this.gbMusteriBilgileri.Controls.Add(this.txtAdSoyad);
            this.gbMusteriBilgileri.Controls.Add(this.label1);
            this.gbMusteriBilgileri.Location = new System.Drawing.Point(504, 13);
            this.gbMusteriBilgileri.Name = "gbMusteriBilgileri";
            this.gbMusteriBilgileri.Size = new System.Drawing.Size(284, 462);
            this.gbMusteriBilgileri.TabIndex = 2;
            this.gbMusteriBilgileri.TabStop = false;
            this.gbMusteriBilgileri.Text = "Musteri Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kisi Sayisi";
            // 
            // numKisiSayisi
            // 
            this.numKisiSayisi.Location = new System.Drawing.Point(92, 237);
            this.numKisiSayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKisiSayisi.Name = "numKisiSayisi";
            this.numKisiSayisi.Size = new System.Drawing.Size(170, 20);
            this.numKisiSayisi.TabIndex = 17;
            this.numKisiSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "1.KAT - 1 Kisilik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "2.KAT - 2 Kisilik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "3.KAT - 3 Kisilik";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "4.KAT - 5 Kisilik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 520);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbMusteriBilgileri);
            this.Controls.Add(this.ftKat1);
            this.Controls.Add(this.ftKat2);
            this.Controls.Add(this.ftKat3);
            this.Controls.Add(this.ftKat4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYas)).EndInit();
            this.gbMusteriBilgileri.ResumeLayout(false);
            this.gbMusteriBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKisiSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ftKat4;
        private System.Windows.Forms.FlowLayoutPanel ftKat3;
        private System.Windows.Forms.FlowLayoutPanel ftKat2;
        private System.Windows.Forms.FlowLayoutPanel ftKat1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown numYas;
        private System.Windows.Forms.MaskedTextBox mtxtTcNo;
        private System.Windows.Forms.MaskedTextBox mTxtTelNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtGirisTarihi;
        private System.Windows.Forms.GroupBox gbMusteriBilgileri;
        private System.Windows.Forms.NumericUpDown numKisiSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

