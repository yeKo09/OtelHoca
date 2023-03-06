
namespace OtelHoca.UI
{
    partial class FormTcKimlik
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
            this.dtGun = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnGonder = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gun Seciniz ";
            // 
            // dtGun
            // 
            this.dtGun.Location = new System.Drawing.Point(156, 65);
            this.dtGun.Name = "dtGun";
            this.dtGun.Size = new System.Drawing.Size(200, 20);
            this.dtGun.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(378, 62);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(156, 117);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(207, 245);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(214, 384);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 23);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.Text = "Gonder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TC Kimlik No";
            this.columnHeader1.Width = 120;
            // 
            // FormTcKimlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 449);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dtGun);
            this.Controls.Add(this.label1);
            this.Name = "FormTcKimlik";
            this.Text = "FormTcKimlik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtGun;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}