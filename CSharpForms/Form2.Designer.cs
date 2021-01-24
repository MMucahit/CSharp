namespace HelloWorld
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblSayı1 = new System.Windows.Forms.Label();
            this.lblSayı2 = new System.Windows.Forms.Label();
            this.tbxSayı1 = new System.Windows.Forms.TextBox();
            this.tbxSayı2 = new System.Windows.Forms.TextBox();
            this.btnİslem = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.cbxToplama = new System.Windows.Forms.CheckBox();
            this.cbxCıkarma = new System.Windows.Forms.CheckBox();
            this.cbxCarpma = new System.Windows.Forms.CheckBox();
            this.cbxBolme = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblSayı1
            // 
            this.lblSayı1.AutoSize = true;
            this.lblSayı1.BackColor = System.Drawing.Color.Transparent;
            this.lblSayı1.Location = new System.Drawing.Point(37, 35);
            this.lblSayı1.Name = "lblSayı1";
            this.lblSayı1.Size = new System.Drawing.Size(36, 13);
            this.lblSayı1.TabIndex = 0;
            this.lblSayı1.Text = "1.Sayı";
            // 
            // lblSayı2
            // 
            this.lblSayı2.AutoSize = true;
            this.lblSayı2.BackColor = System.Drawing.Color.Transparent;
            this.lblSayı2.Location = new System.Drawing.Point(37, 61);
            this.lblSayı2.Name = "lblSayı2";
            this.lblSayı2.Size = new System.Drawing.Size(36, 13);
            this.lblSayı2.TabIndex = 1;
            this.lblSayı2.Text = "2.Sayı";
            // 
            // tbxSayı1
            // 
            this.tbxSayı1.Location = new System.Drawing.Point(99, 28);
            this.tbxSayı1.Name = "tbxSayı1";
            this.tbxSayı1.Size = new System.Drawing.Size(100, 20);
            this.tbxSayı1.TabIndex = 2;
            // 
            // tbxSayı2
            // 
            this.tbxSayı2.Location = new System.Drawing.Point(99, 54);
            this.tbxSayı2.Name = "tbxSayı2";
            this.tbxSayı2.Size = new System.Drawing.Size(100, 20);
            this.tbxSayı2.TabIndex = 3;
            // 
            // btnİslem
            // 
            this.btnİslem.Location = new System.Drawing.Point(99, 132);
            this.btnİslem.Name = "btnİslem";
            this.btnİslem.Size = new System.Drawing.Size(92, 32);
            this.btnİslem.TabIndex = 4;
            this.btnİslem.Text = "İslem";
            this.btnİslem.UseVisualStyleBackColor = true;
            this.btnİslem.Click += new System.EventHandler(this.btnİslem_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSonuc.Location = new System.Drawing.Point(300, 45);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.Text = "Sonuc";
            // 
            // cbxToplama
            // 
            this.cbxToplama.AutoSize = true;
            this.cbxToplama.BackColor = System.Drawing.Color.Transparent;
            this.cbxToplama.Location = new System.Drawing.Point(377, 157);
            this.cbxToplama.Name = "cbxToplama";
            this.cbxToplama.Size = new System.Drawing.Size(67, 17);
            this.cbxToplama.TabIndex = 6;
            this.cbxToplama.Text = "Toplama";
            this.cbxToplama.UseVisualStyleBackColor = false;
            this.cbxToplama.CheckedChanged += new System.EventHandler(this.cbxToplama_CheckedChanged);
            // 
            // cbxCıkarma
            // 
            this.cbxCıkarma.AutoSize = true;
            this.cbxCıkarma.BackColor = System.Drawing.Color.Transparent;
            this.cbxCıkarma.Location = new System.Drawing.Point(377, 181);
            this.cbxCıkarma.Name = "cbxCıkarma";
            this.cbxCıkarma.Size = new System.Drawing.Size(64, 17);
            this.cbxCıkarma.TabIndex = 7;
            this.cbxCıkarma.Text = "Cıkarma";
            this.cbxCıkarma.UseVisualStyleBackColor = false;
            this.cbxCıkarma.CheckedChanged += new System.EventHandler(this.cbxCıkarma_CheckedChanged);
            // 
            // cbxCarpma
            // 
            this.cbxCarpma.AutoSize = true;
            this.cbxCarpma.BackColor = System.Drawing.Color.Transparent;
            this.cbxCarpma.Location = new System.Drawing.Point(377, 205);
            this.cbxCarpma.Name = "cbxCarpma";
            this.cbxCarpma.Size = new System.Drawing.Size(62, 17);
            this.cbxCarpma.TabIndex = 8;
            this.cbxCarpma.Text = "Carpma";
            this.cbxCarpma.UseVisualStyleBackColor = false;
            this.cbxCarpma.CheckedChanged += new System.EventHandler(this.cbxCarpma_CheckedChanged);
            // 
            // cbxBolme
            // 
            this.cbxBolme.AutoSize = true;
            this.cbxBolme.BackColor = System.Drawing.Color.Transparent;
            this.cbxBolme.Location = new System.Drawing.Point(377, 229);
            this.cbxBolme.Name = "cbxBolme";
            this.cbxBolme.Size = new System.Drawing.Size(55, 17);
            this.cbxBolme.TabIndex = 9;
            this.cbxBolme.Text = "Bolme";
            this.cbxBolme.UseVisualStyleBackColor = false;
            this.cbxBolme.CheckedChanged += new System.EventHandler(this.cbxBolme_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 308);
            this.Controls.Add(this.cbxBolme);
            this.Controls.Add(this.cbxCarpma);
            this.Controls.Add(this.cbxCıkarma);
            this.Controls.Add(this.cbxToplama);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnİslem);
            this.Controls.Add(this.tbxSayı2);
            this.Controls.Add(this.tbxSayı1);
            this.Controls.Add(this.lblSayı2);
            this.Controls.Add(this.lblSayı1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnİslem;
        private System.Windows.Forms.TextBox tbxSayı2;
        private System.Windows.Forms.TextBox tbxSayı1;
        private System.Windows.Forms.Label lblSayı2;
        private System.Windows.Forms.Label lblSayı1;
        private System.Windows.Forms.CheckBox cbxBolme;
        private System.Windows.Forms.CheckBox cbxCarpma;
        private System.Windows.Forms.CheckBox cbxCıkarma;
        private System.Windows.Forms.CheckBox cbxToplama;
    }
}