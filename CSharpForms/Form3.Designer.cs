namespace HelloWorld
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lbxEkran = new System.Windows.Forms.ListBox();
            this.lblSehirAdı = new System.Windows.Forms.Label();
            this.tbxSehirAdı = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.lbxEkran1 = new System.Windows.Forms.ListBox();
            this.btnSırala = new System.Windows.Forms.Button();
            this.lbxEkran2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxEkran
            // 
            this.lbxEkran.FormattingEnabled = true;
            this.lbxEkran.Location = new System.Drawing.Point(291, 26);
            this.lbxEkran.Name = "lbxEkran";
            this.lbxEkran.Size = new System.Drawing.Size(120, 238);
            this.lbxEkran.TabIndex = 0;
            // 
            // lblSehirAdı
            // 
            this.lblSehirAdı.AutoSize = true;
            this.lblSehirAdı.Location = new System.Drawing.Point(39, 34);
            this.lblSehirAdı.Name = "lblSehirAdı";
            this.lblSehirAdı.Size = new System.Drawing.Size(52, 13);
            this.lblSehirAdı.TabIndex = 1;
            this.lblSehirAdı.Text = "Şehir Adı:";
            // 
            // tbxSehirAdı
            // 
            this.tbxSehirAdı.Location = new System.Drawing.Point(103, 26);
            this.tbxSehirAdı.Name = "tbxSehirAdı";
            this.tbxSehirAdı.Size = new System.Drawing.Size(100, 20);
            this.tbxSehirAdı.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(116, 64);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(313, 286);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lbxEkran1
            // 
            this.lbxEkran1.FormattingEnabled = true;
            this.lbxEkran1.Location = new System.Drawing.Point(152, 222);
            this.lbxEkran1.Name = "lbxEkran1";
            this.lbxEkran1.Size = new System.Drawing.Size(120, 147);
            this.lbxEkran1.TabIndex = 5;
            // 
            // btnSırala
            // 
            this.btnSırala.Location = new System.Drawing.Point(171, 384);
            this.btnSırala.Name = "btnSırala";
            this.btnSırala.Size = new System.Drawing.Size(75, 23);
            this.btnSırala.TabIndex = 6;
            this.btnSırala.Text = "Sırala";
            this.btnSırala.UseVisualStyleBackColor = true;
            this.btnSırala.Click += new System.EventHandler(this.btnSırala_Click);
            // 
            // lbxEkran2
            // 
            this.lbxEkran2.FormattingEnabled = true;
            this.lbxEkran2.Location = new System.Drawing.Point(12, 222);
            this.lbxEkran2.Name = "lbxEkran2";
            this.lbxEkran2.Size = new System.Drawing.Size(120, 147);
            this.lbxEkran2.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 432);
            this.Controls.Add(this.lbxEkran2);
            this.Controls.Add(this.btnSırala);
            this.Controls.Add(this.lbxEkran1);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbxSehirAdı);
            this.Controls.Add(this.lblSehirAdı);
            this.Controls.Add(this.lbxEkran);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEkran;
        private System.Windows.Forms.Label lblSehirAdı;
        private System.Windows.Forms.TextBox tbxSehirAdı;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ListBox lbxEkran1;
        private System.Windows.Forms.Button btnSırala;
        private System.Windows.Forms.ListBox lbxEkran2;
    }
}