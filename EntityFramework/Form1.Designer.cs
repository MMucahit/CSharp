namespace EntityFramework
{
    partial class Form1
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
            this.UPP = new System.Windows.Forms.GroupBox();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.btnUpp = new System.Windows.Forms.Button();
            this.tbxUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.lblUpdateStockAmount = new System.Windows.Forms.Label();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.GroupBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblGetById = new System.Windows.Forms.Label();
            this.tbxGetById = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.UPP.SuspendLayout();
            this.ADD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // UPP
            // 
            this.UPP.Controls.Add(this.lblUpdateName);
            this.UPP.Controls.Add(this.tbxUpdateName);
            this.UPP.Controls.Add(this.tbxUpdateUnitPrice);
            this.UPP.Controls.Add(this.btnUpp);
            this.UPP.Controls.Add(this.tbxUpdateStockAmount);
            this.UPP.Controls.Add(this.lblUpdateStockAmount);
            this.UPP.Controls.Add(this.lblUpdateUnitPrice);
            this.UPP.Location = new System.Drawing.Point(499, 285);
            this.UPP.Name = "UPP";
            this.UPP.Size = new System.Drawing.Size(258, 155);
            this.UPP.TabIndex = 21;
            this.UPP.TabStop = false;
            this.UPP.Text = "UPP";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(32, 34);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateName.TabIndex = 11;
            this.lblUpdateName.Text = "Name";
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(119, 27);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateName.TabIndex = 8;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(119, 53);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateUnitPrice.TabIndex = 9;
            // 
            // btnUpp
            // 
            this.btnUpp.Location = new System.Drawing.Point(119, 128);
            this.btnUpp.Name = "btnUpp";
            this.btnUpp.Size = new System.Drawing.Size(100, 23);
            this.btnUpp.TabIndex = 14;
            this.btnUpp.Text = "Update";
            this.btnUpp.UseVisualStyleBackColor = true;
            this.btnUpp.Click += new System.EventHandler(this.btnUpp_Click);
            // 
            // tbxUpdateStockAmount
            // 
            this.tbxUpdateStockAmount.Location = new System.Drawing.Point(119, 80);
            this.tbxUpdateStockAmount.Name = "tbxUpdateStockAmount";
            this.tbxUpdateStockAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateStockAmount.TabIndex = 10;
            // 
            // lblUpdateStockAmount
            // 
            this.lblUpdateStockAmount.AutoSize = true;
            this.lblUpdateStockAmount.Location = new System.Drawing.Point(32, 86);
            this.lblUpdateStockAmount.Name = "lblUpdateStockAmount";
            this.lblUpdateStockAmount.Size = new System.Drawing.Size(71, 13);
            this.lblUpdateStockAmount.TabIndex = 13;
            this.lblUpdateStockAmount.Text = "StockAmount";
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(32, 60);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(50, 13);
            this.lblUpdateUnitPrice.TabIndex = 12;
            this.lblUpdateUnitPrice.Text = "UnitPrice";
            // 
            // ADD
            // 
            this.ADD.Controls.Add(this.lblStockAmount);
            this.ADD.Controls.Add(this.tbxName);
            this.ADD.Controls.Add(this.tbxUnitPrice);
            this.ADD.Controls.Add(this.tbxStockAmount);
            this.ADD.Controls.Add(this.lblName);
            this.ADD.Controls.Add(this.lblUnitPrice);
            this.ADD.Controls.Add(this.btnAdd);
            this.ADD.Location = new System.Drawing.Point(30, 285);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(258, 155);
            this.ADD.TabIndex = 20;
            this.ADD.TabStop = false;
            this.ADD.Text = "ADD";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(27, 78);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(71, 13);
            this.lblStockAmount.TabIndex = 6;
            this.lblStockAmount.Text = "StockAmount";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(114, 19);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(114, 45);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxUnitPrice.TabIndex = 2;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(114, 72);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(100, 20);
            this.tbxStockAmount.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(27, 52);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(50, 13);
            this.lblUnitPrice.TabIndex = 5;
            this.lblUnitPrice.Text = "UnitPrice";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(114, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(344, 413);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 23);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(30, 43);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(741, 236);
            this.dgwProducts.TabIndex = 18;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(567, 19);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 22;
            this.lblSearch.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(618, 16);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 23;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblGetById
            // 
            this.lblGetById.AutoSize = true;
            this.lblGetById.Location = new System.Drawing.Point(57, 19);
            this.lblGetById.Name = "lblGetById";
            this.lblGetById.Size = new System.Drawing.Size(45, 13);
            this.lblGetById.TabIndex = 24;
            this.lblGetById.Text = "GetById";
            // 
            // tbxGetById
            // 
            this.tbxGetById.Location = new System.Drawing.Point(144, 16);
            this.tbxGetById.Name = "tbxGetById";
            this.tbxGetById.Size = new System.Drawing.Size(100, 20);
            this.tbxGetById.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(261, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 483);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxGetById);
            this.Controls.Add(this.lblGetById);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.UPP);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.UPP.ResumeLayout(false);
            this.UPP.PerformLayout();
            this.ADD.ResumeLayout(false);
            this.ADD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UPP;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.Button btnUpp;
        private System.Windows.Forms.TextBox tbxUpdateStockAmount;
        private System.Windows.Forms.Label lblUpdateStockAmount;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.GroupBox ADD;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblGetById;
        private System.Windows.Forms.TextBox tbxGetById;
        private System.Windows.Forms.Button btnSearch;
    }
}