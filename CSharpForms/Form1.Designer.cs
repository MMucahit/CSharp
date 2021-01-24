namespace CSharpForms
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPhoneNumberText = new System.Windows.Forms.Label();
            this.lblDateText = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.mtbxDate = new System.Windows.Forms.MaskedTextBox();
            this.mtbxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lbxEkran = new System.Windows.Forms.ListBox();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblBranchText = new System.Windows.Forms.Label();
            this.cbxBranch = new System.Windows.Forms.ComboBox();
            this.lblAgeText = new System.Windows.Forms.Label();
            this.lblClassText = new System.Windows.Forms.Label();
            this.tbxClass = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbxSurName = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblSurNameText = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblSurName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnMerhaba = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPhoneNumberText
            // 
            this.lblPhoneNumberText.AutoSize = true;
            this.lblPhoneNumberText.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumberText.Location = new System.Drawing.Point(330, 232);
            this.lblPhoneNumberText.Name = "lblPhoneNumberText";
            this.lblPhoneNumberText.Size = new System.Drawing.Size(25, 13);
            this.lblPhoneNumberText.TabIndex = 48;
            this.lblPhoneNumberText.Text = "000";
            // 
            // lblDateText
            // 
            this.lblDateText.AutoSize = true;
            this.lblDateText.BackColor = System.Drawing.Color.Transparent;
            this.lblDateText.Location = new System.Drawing.Point(330, 271);
            this.lblDateText.Name = "lblDateText";
            this.lblDateText.Size = new System.Drawing.Size(25, 13);
            this.lblDateText.TabIndex = 47;
            this.lblDateText.Text = "000";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Location = new System.Drawing.Point(50, 236);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 46;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(50, 271);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Date";
            // 
            // mtbxDate
            // 
            this.mtbxDate.Location = new System.Drawing.Point(136, 264);
            this.mtbxDate.Mask = "00/00/0000";
            this.mtbxDate.Name = "mtbxDate";
            this.mtbxDate.Size = new System.Drawing.Size(93, 20);
            this.mtbxDate.TabIndex = 44;
            this.mtbxDate.ValidatingType = typeof(System.DateTime);
            // 
            // mtbxPhoneNumber
            // 
            this.mtbxPhoneNumber.Location = new System.Drawing.Point(136, 229);
            this.mtbxPhoneNumber.Mask = "(999) 000-0000";
            this.mtbxPhoneNumber.Name = "mtbxPhoneNumber";
            this.mtbxPhoneNumber.Size = new System.Drawing.Size(93, 20);
            this.mtbxPhoneNumber.TabIndex = 43;
            // 
            // lbxEkran
            // 
            this.lbxEkran.FormattingEnabled = true;
            this.lbxEkran.HorizontalScrollbar = true;
            this.lbxEkran.Location = new System.Drawing.Point(385, 39);
            this.lbxEkran.Name = "lbxEkran";
            this.lbxEkran.Size = new System.Drawing.Size(248, 173);
            this.lbxEkran.TabIndex = 41;
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.BackColor = System.Drawing.Color.Transparent;
            this.lblBranch.Location = new System.Drawing.Point(50, 199);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(41, 13);
            this.lblBranch.TabIndex = 40;
            this.lblBranch.Text = "Branch";
            // 
            // lblBranchText
            // 
            this.lblBranchText.AutoSize = true;
            this.lblBranchText.BackColor = System.Drawing.Color.Transparent;
            this.lblBranchText.Location = new System.Drawing.Point(330, 199);
            this.lblBranchText.Name = "lblBranchText";
            this.lblBranchText.Size = new System.Drawing.Size(25, 13);
            this.lblBranchText.TabIndex = 39;
            this.lblBranchText.Text = "000";
            // 
            // cbxBranch
            // 
            this.cbxBranch.FormattingEnabled = true;
            this.cbxBranch.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.cbxBranch.Location = new System.Drawing.Point(136, 191);
            this.cbxBranch.Name = "cbxBranch";
            this.cbxBranch.Size = new System.Drawing.Size(121, 21);
            this.cbxBranch.TabIndex = 38;
            // 
            // lblAgeText
            // 
            this.lblAgeText.AutoSize = true;
            this.lblAgeText.BackColor = System.Drawing.Color.Transparent;
            this.lblAgeText.Location = new System.Drawing.Point(330, 122);
            this.lblAgeText.Name = "lblAgeText";
            this.lblAgeText.Size = new System.Drawing.Size(25, 13);
            this.lblAgeText.TabIndex = 37;
            this.lblAgeText.Text = "000";
            // 
            // lblClassText
            // 
            this.lblClassText.AutoSize = true;
            this.lblClassText.BackColor = System.Drawing.Color.Transparent;
            this.lblClassText.Location = new System.Drawing.Point(330, 157);
            this.lblClassText.Name = "lblClassText";
            this.lblClassText.Size = new System.Drawing.Size(25, 13);
            this.lblClassText.TabIndex = 36;
            this.lblClassText.Text = "000";
            // 
            // tbxClass
            // 
            this.tbxClass.Location = new System.Drawing.Point(136, 150);
            this.tbxClass.Name = "tbxClass";
            this.tbxClass.Size = new System.Drawing.Size(100, 20);
            this.tbxClass.TabIndex = 35;
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(136, 115);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(100, 20);
            this.tbxAge.TabIndex = 34;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.BackColor = System.Drawing.Color.Transparent;
            this.lblClass.Location = new System.Drawing.Point(50, 157);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 33;
            this.lblClass.Text = "Class";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Location = new System.Drawing.Point(50, 118);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 32;
            this.lblAge.Text = "Age";
            // 
            // tbxSurName
            // 
            this.tbxSurName.Location = new System.Drawing.Point(136, 80);
            this.tbxSurName.Name = "tbxSurName";
            this.tbxSurName.Size = new System.Drawing.Size(100, 20);
            this.tbxSurName.TabIndex = 31;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(136, 39);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 30;
            // 
            // lblSurNameText
            // 
            this.lblSurNameText.AutoSize = true;
            this.lblSurNameText.BackColor = System.Drawing.Color.Transparent;
            this.lblSurNameText.Location = new System.Drawing.Point(330, 87);
            this.lblSurNameText.Name = "lblSurNameText";
            this.lblSurNameText.Size = new System.Drawing.Size(25, 13);
            this.lblSurNameText.TabIndex = 29;
            this.lblSurNameText.Text = "000";
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.BackColor = System.Drawing.Color.Transparent;
            this.lblNameText.Location = new System.Drawing.Point(330, 46);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(25, 13);
            this.lblNameText.TabIndex = 28;
            this.lblNameText.Text = "000";
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.BackColor = System.Drawing.Color.Transparent;
            this.lblSurName.Location = new System.Drawing.Point(50, 80);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(51, 13);
            this.lblSurName.TabIndex = 27;
            this.lblSurName.Text = "SurName";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(50, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Name";
            // 
            // btnMerhaba
            // 
            this.btnMerhaba.Location = new System.Drawing.Point(253, 334);
            this.btnMerhaba.Name = "btnMerhaba";
            this.btnMerhaba.Size = new System.Drawing.Size(152, 104);
            this.btnMerhaba.TabIndex = 49;
            this.btnMerhaba.Text = "Merhaba";
            this.btnMerhaba.UseVisualStyleBackColor = true;
            this.btnMerhaba.Click += new System.EventHandler(this.btnMerhaba_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(437, 271);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 50;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 461);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnMerhaba);
            this.Controls.Add(this.lblPhoneNumberText);
            this.Controls.Add(this.lblDateText);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.mtbxDate);
            this.Controls.Add(this.mtbxPhoneNumber);
            this.Controls.Add(this.lbxEkran);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblBranchText);
            this.Controls.Add(this.cbxBranch);
            this.Controls.Add(this.lblAgeText);
            this.Controls.Add(this.lblClassText);
            this.Controls.Add(this.tbxClass);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.tbxSurName);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblSurNameText);
            this.Controls.Add(this.lblNameText);
            this.Controls.Add(this.lblSurName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPhoneNumberText;
        private System.Windows.Forms.Label lblDateText;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MaskedTextBox mtbxDate;
        private System.Windows.Forms.MaskedTextBox mtbxPhoneNumber;
        private System.Windows.Forms.ListBox lbxEkran;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblBranchText;
        private System.Windows.Forms.ComboBox cbxBranch;
        private System.Windows.Forms.Label lblAgeText;
        private System.Windows.Forms.Label lblClassText;
        private System.Windows.Forms.TextBox tbxClass;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbxSurName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblSurNameText;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnMerhaba;
        private System.Windows.Forms.Button btnEkle;
    }
}

