
namespace OtelHoca.UI
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.islemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporuGor = new System.Windows.Forms.ToolStripMenuItem();
            this.tcKimlikGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islemlerToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // islemlerToolStripMenuItem
            // 
            this.islemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acToolStripMenuItem,
            this.ödemeToolStripMenuItem});
            this.islemlerToolStripMenuItem.Name = "islemlerToolStripMenuItem";
            this.islemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.islemlerToolStripMenuItem.Text = "İslemler";
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.acToolStripMenuItem.Text = "Rezervasyon";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // ödemeToolStripMenuItem
            // 
            this.ödemeToolStripMenuItem.Name = "ödemeToolStripMenuItem";
            this.ödemeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.ödemeToolStripMenuItem.Text = "Ödeme";
            this.ödemeToolStripMenuItem.Click += new System.EventHandler(this.ödemeToolStripMenuItem_Click);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporuGor,
            this.tcKimlikGönderToolStripMenuItem});
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.raporToolStripMenuItem.Text = "Rapor";
            // 
            // raporuGor
            // 
            this.raporuGor.Name = "raporuGor";
            this.raporuGor.Size = new System.Drawing.Size(180, 22);
            this.raporuGor.Text = "Raporu Gor";
            this.raporuGor.Click += new System.EventHandler(this.raporuGor_Click);
            // 
            // tcKimlikGönderToolStripMenuItem
            // 
            this.tcKimlikGönderToolStripMenuItem.Name = "tcKimlikGönderToolStripMenuItem";
            this.tcKimlikGönderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tcKimlikGönderToolStripMenuItem.Text = "Tc Kimlik Gonder";
            this.tcKimlikGönderToolStripMenuItem.Click += new System.EventHandler(this.tcKimlikGönderToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 625);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem islemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporuGor;
        private System.Windows.Forms.ToolStripMenuItem tcKimlikGönderToolStripMenuItem;
    }
}