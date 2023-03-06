
namespace OtelHoca.UI
{
    partial class FormRapor
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lwDetaylar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSifirla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnSadeceTarihFiltrele = new System.Windows.Forms.Button();
            this.btnHemTarihHemIsim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsme Göre Filtrele ";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(155, 68);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(213, 20);
            this.txtAra.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(401, 66);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lwDetaylar
            // 
            this.lwDetaylar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lwDetaylar.HideSelection = false;
            this.lwDetaylar.Location = new System.Drawing.Point(29, 215);
            this.lwDetaylar.Name = "lwDetaylar";
            this.lwDetaylar.Size = new System.Drawing.Size(883, 326);
            this.lwDetaylar.TabIndex = 3;
            this.lwDetaylar.UseCompatibleStateImageBehavior = false;
            this.lwDetaylar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giris Tarihi";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cikis Tarihi";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Oda Numarasi";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Toplam Fiyat";
            this.columnHeader5.Width = 120;
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(29, 169);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(97, 29);
            this.btnSifirla.TabIndex = 4;
            this.btnSifirla.Text = "Sifirla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(655, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarihe Göre Filtrele ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(510, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bu Tarihte veya Sonra Giris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(514, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bu Tarihte veya Önce Cikis";
            // 
            // dtGirisTarihi
            // 
            this.dtGirisTarihi.Location = new System.Drawing.Point(699, 63);
            this.dtGirisTarihi.Name = "dtGirisTarihi";
            this.dtGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtGirisTarihi.TabIndex = 8;
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Location = new System.Drawing.Point(699, 101);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtCikisTarihi.TabIndex = 9;
            // 
            // btnSadeceTarihFiltrele
            // 
            this.btnSadeceTarihFiltrele.Location = new System.Drawing.Point(699, 136);
            this.btnSadeceTarihFiltrele.Name = "btnSadeceTarihFiltrele";
            this.btnSadeceTarihFiltrele.Size = new System.Drawing.Size(200, 23);
            this.btnSadeceTarihFiltrele.TabIndex = 10;
            this.btnSadeceTarihFiltrele.Text = "Sadece Tarihe Göre Filtrele";
            this.btnSadeceTarihFiltrele.UseVisualStyleBackColor = true;
            this.btnSadeceTarihFiltrele.Click += new System.EventHandler(this.btnSadeceTarihFiltrele_Click);
            // 
            // btnHemTarihHemIsim
            // 
            this.btnHemTarihHemIsim.Location = new System.Drawing.Point(699, 172);
            this.btnHemTarihHemIsim.Name = "btnHemTarihHemIsim";
            this.btnHemTarihHemIsim.Size = new System.Drawing.Size(200, 23);
            this.btnHemTarihHemIsim.TabIndex = 11;
            this.btnHemTarihHemIsim.Text = "Hem Tarih Hem de İsme Göre Filtrele";
            this.btnHemTarihHemIsim.UseVisualStyleBackColor = true;
            this.btnHemTarihHemIsim.Click += new System.EventHandler(this.btnHemTarihHemIsim_Click);
            // 
            // FormRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 553);
            this.Controls.Add(this.btnHemTarihHemIsim);
            this.Controls.Add(this.btnSadeceTarihFiltrele);
            this.Controls.Add(this.dtCikisTarihi);
            this.Controls.Add(this.dtGirisTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.lwDetaylar);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Name = "FormRapor";
            this.Text = "FormRapor";
            this.Load += new System.EventHandler(this.FormRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ListView lwDetaylar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.Button btnSadeceTarihFiltrele;
        private System.Windows.Forms.Button btnHemTarihHemIsim;
    }
}