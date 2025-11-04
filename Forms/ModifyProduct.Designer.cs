namespace Inventory_Management_System
{
    partial class modProduct
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.modProductBtnSave = new System.Windows.Forms.Button();
            this.modProductBtnCancel = new System.Windows.Forms.Button();
            this.modProductLabelGrid2 = new System.Windows.Forms.Label();
            this.modProductBtnDelete = new System.Windows.Forms.Button();
            this.modProductGrid2 = new System.Windows.Forms.DataGridView();
            this.modProductBtnAdd = new System.Windows.Forms.Button();
            this.modProductBtnSearch = new System.Windows.Forms.Button();
            this.modProductPartSearchBox = new System.Windows.Forms.TextBox();
            this.modProductMinBox = new System.Windows.Forms.TextBox();
            this.modProductMaxBox = new System.Windows.Forms.TextBox();
            this.modProductPriceBox = new System.Windows.Forms.TextBox();
            this.modProductInventoryBox = new System.Windows.Forms.TextBox();
            this.modProductNameBox = new System.Windows.Forms.TextBox();
            this.modProductIDBox = new System.Windows.Forms.TextBox();
            this.modProductLabelGrid1 = new System.Windows.Forms.Label();
            this.modProductGrid1 = new System.Windows.Forms.DataGridView();
            this.modProductLabelMin = new System.Windows.Forms.Label();
            this.modProductLabelMax = new System.Windows.Forms.Label();
            this.modProductLabelPrice = new System.Windows.Forms.Label();
            this.modProductLabelInventory = new System.Windows.Forms.Label();
            this.modProductLabelName = new System.Windows.Forms.Label();
            this.modProductLabelID = new System.Windows.Forms.Label();
            this.modProductTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.modProductGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modProductGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // modProductBtnSave
            // 
            this.modProductBtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modProductBtnSave.Location = new System.Drawing.Point(731, 479);
            this.modProductBtnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductBtnSave.Name = "modProductBtnSave";
            this.modProductBtnSave.Size = new System.Drawing.Size(69, 34);
            this.modProductBtnSave.TabIndex = 45;
            this.modProductBtnSave.Text = "Save";
            this.modProductBtnSave.UseVisualStyleBackColor = true;
            this.modProductBtnSave.Click += new System.EventHandler(this.SaveModifyProductButton_Click);
            // 
            // modProductBtnCancel
            // 
            this.modProductBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modProductBtnCancel.Location = new System.Drawing.Point(819, 479);
            this.modProductBtnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductBtnCancel.Name = "modProductBtnCancel";
            this.modProductBtnCancel.Size = new System.Drawing.Size(69, 34);
            this.modProductBtnCancel.TabIndex = 44;
            this.modProductBtnCancel.Text = "Cancel";
            this.modProductBtnCancel.UseVisualStyleBackColor = true;
            this.modProductBtnCancel.Click += new System.EventHandler(this.CancelModifyProductButton_Click);
            // 
            // modProductLabelGrid2
            // 
            this.modProductLabelGrid2.AutoSize = true;
            this.modProductLabelGrid2.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductLabelGrid2.Location = new System.Drawing.Point(388, 252);
            this.modProductLabelGrid2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modProductLabelGrid2.Name = "modProductLabelGrid2";
            this.modProductLabelGrid2.Size = new System.Drawing.Size(262, 21);
            this.modProductLabelGrid2.TabIndex = 43;
            this.modProductLabelGrid2.Text = "Parts Associated with this Product";
            // 
            // modProductBtnDelete
            // 
            this.modProductBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modProductBtnDelete.Location = new System.Drawing.Point(819, 431);
            this.modProductBtnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductBtnDelete.Name = "modProductBtnDelete";
            this.modProductBtnDelete.Size = new System.Drawing.Size(69, 34);
            this.modProductBtnDelete.TabIndex = 42;
            this.modProductBtnDelete.Text = "Delete";
            this.modProductBtnDelete.UseVisualStyleBackColor = true;
            this.modProductBtnDelete.Click += new System.EventHandler(this.DeleteAssociatedPartButton_Click);
            // 
            // modProductGrid2
            // 
            this.modProductGrid2.AllowUserToAddRows = false;
            this.modProductGrid2.AllowUserToDeleteRows = false;
            this.modProductGrid2.AllowUserToResizeColumns = false;
            this.modProductGrid2.AllowUserToResizeRows = false;
            this.modProductGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modProductGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modProductGrid2.Location = new System.Drawing.Point(391, 278);
            this.modProductGrid2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductGrid2.Name = "modProductGrid2";
            this.modProductGrid2.RowHeadersVisible = false;
            this.modProductGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modProductGrid2.Size = new System.Drawing.Size(497, 137);
            this.modProductGrid2.TabIndex = 41;
            // 
            // modProductBtnAdd
            // 
            this.modProductBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modProductBtnAdd.Location = new System.Drawing.Point(819, 214);
            this.modProductBtnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductBtnAdd.Name = "modProductBtnAdd";
            this.modProductBtnAdd.Size = new System.Drawing.Size(69, 34);
            this.modProductBtnAdd.TabIndex = 40;
            this.modProductBtnAdd.Text = "Add";
            this.modProductBtnAdd.UseVisualStyleBackColor = true;
            this.modProductBtnAdd.Click += new System.EventHandler(this.AddAssociatedPartButton_Click);
            // 
            // modProductBtnSearch
            // 
            this.modProductBtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modProductBtnSearch.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductBtnSearch.Location = new System.Drawing.Point(595, 29);
            this.modProductBtnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductBtnSearch.Name = "modProductBtnSearch";
            this.modProductBtnSearch.Size = new System.Drawing.Size(76, 30);
            this.modProductBtnSearch.TabIndex = 39;
            this.modProductBtnSearch.Text = "Search";
            this.modProductBtnSearch.UseVisualStyleBackColor = true;
            this.modProductBtnSearch.Click += new System.EventHandler(this.SearchPartListButton_Click);
            // 
            // modProductPartSearchBox
            // 
            this.modProductPartSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductPartSearchBox.Location = new System.Drawing.Point(686, 30);
            this.modProductPartSearchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductPartSearchBox.Name = "modProductPartSearchBox";
            this.modProductPartSearchBox.Size = new System.Drawing.Size(203, 30);
            this.modProductPartSearchBox.TabIndex = 38;
            // 
            // modProductMinBox
            // 
            this.modProductMinBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductMinBox.Location = new System.Drawing.Point(232, 338);
            this.modProductMinBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductMinBox.Name = "modProductMinBox";
            this.modProductMinBox.Size = new System.Drawing.Size(92, 30);
            this.modProductMinBox.TabIndex = 37;
            // 
            // modProductMaxBox
            // 
            this.modProductMaxBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductMaxBox.Location = new System.Drawing.Point(80, 338);
            this.modProductMaxBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductMaxBox.Name = "modProductMaxBox";
            this.modProductMaxBox.Size = new System.Drawing.Size(92, 30);
            this.modProductMaxBox.TabIndex = 36;
            // 
            // modProductPriceBox
            // 
            this.modProductPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductPriceBox.Location = new System.Drawing.Point(141, 285);
            this.modProductPriceBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductPriceBox.Name = "modProductPriceBox";
            this.modProductPriceBox.Size = new System.Drawing.Size(92, 30);
            this.modProductPriceBox.TabIndex = 35;
            // 
            // modProductInventoryBox
            // 
            this.modProductInventoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductInventoryBox.Location = new System.Drawing.Point(141, 244);
            this.modProductInventoryBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductInventoryBox.Name = "modProductInventoryBox";
            this.modProductInventoryBox.Size = new System.Drawing.Size(92, 30);
            this.modProductInventoryBox.TabIndex = 34;
            // 
            // modProductNameBox
            // 
            this.modProductNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductNameBox.Location = new System.Drawing.Point(141, 200);
            this.modProductNameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductNameBox.Name = "modProductNameBox";
            this.modProductNameBox.Size = new System.Drawing.Size(92, 30);
            this.modProductNameBox.TabIndex = 33;
            // 
            // modProductIDBox
            // 
            this.modProductIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductIDBox.Location = new System.Drawing.Point(141, 158);
            this.modProductIDBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductIDBox.Name = "modProductIDBox";
            this.modProductIDBox.ReadOnly = true;
            this.modProductIDBox.Size = new System.Drawing.Size(92, 30);
            this.modProductIDBox.TabIndex = 32;
            // 
            // modProductLabelGrid1
            // 
            this.modProductLabelGrid1.AutoSize = true;
            this.modProductLabelGrid1.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductLabelGrid1.Location = new System.Drawing.Point(388, 45);
            this.modProductLabelGrid1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modProductLabelGrid1.Name = "modProductLabelGrid1";
            this.modProductLabelGrid1.Size = new System.Drawing.Size(140, 21);
            this.modProductLabelGrid1.TabIndex = 31;
            this.modProductLabelGrid1.Text = "All Candidate Parts";
            // 
            // modProductGrid1
            // 
            this.modProductGrid1.AllowUserToAddRows = false;
            this.modProductGrid1.AllowUserToDeleteRows = false;
            this.modProductGrid1.AllowUserToResizeColumns = false;
            this.modProductGrid1.AllowUserToResizeRows = false;
            this.modProductGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modProductGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modProductGrid1.Location = new System.Drawing.Point(391, 71);
            this.modProductGrid1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modProductGrid1.Name = "modProductGrid1";
            this.modProductGrid1.RowHeadersVisible = false;
            this.modProductGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modProductGrid1.Size = new System.Drawing.Size(497, 137);
            this.modProductGrid1.TabIndex = 30;
            // 
            // modProductLabelMin
            // 
            this.modProductLabelMin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modProductLabelMin.AutoSize = true;
            this.modProductLabelMin.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductLabelMin.Location = new System.Drawing.Point(196, 340);
            this.modProductLabelMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modProductLabelMin.Name = "modProductLabelMin";
            this.modProductLabelMin.Size = new System.Drawing.Size(28, 15);
            this.modProductLabelMin.TabIndex = 29;
            this.modProductLabelMin.Text = "Min";
            // 
            // modProductLabelMax
            // 
            this.modProductLabelMax.AutoSize = true;
            this.modProductLabelMax.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductLabelMax.Location = new System.Drawing.Point(30, 340);
            this.modProductLabelMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modProductLabelMax.Name = "modProductLabelMax";
            this.modProductLabelMax.Size = new System.Drawing.Size(29, 15);
            this.modProductLabelMax.TabIndex = 28;
            this.modProductLabelMax.Text = "Max";
            // 
            // modProductLabelPrice
            // 
            this.modProductLabelPrice.AutoSize = true;
            this.modProductLabelPrice.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductLabelPrice.Location = new System.Drawing.Point(30, 287);
            this.modProductLabelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modProductLabelPrice.Name = "modProductLabelPrice";
            this.modProductLabelPrice.Size = new System.Drawing.Size(68, 15);
            this.modProductLabelPrice.TabIndex = 27;
            this.modProductLabelPrice.Text = "Price / Cost";
            // 
            // modProductLabelInventory
            // 
            this.modProductLabelInventory.AutoSize = true;
            this.modProductLabelInventory.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductLabelInventory.Location = new System.Drawing.Point(30, 246);
            this.modProductLabelInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modProductLabelInventory.Name = "modProductLabelInventory";
            this.modProductLabelInventory.Size = new System.Drawing.Size(57, 15);
            this.modProductLabelInventory.TabIndex = 26;
            this.modProductLabelInventory.Text = "Inventory";
            // 
            // modProductLabelName
            // 
            this.modProductLabelName.AutoSize = true;
            this.modProductLabelName.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductLabelName.Location = new System.Drawing.Point(30, 203);
            this.modProductLabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modProductLabelName.Name = "modProductLabelName";
            this.modProductLabelName.Size = new System.Drawing.Size(39, 15);
            this.modProductLabelName.TabIndex = 25;
            this.modProductLabelName.Text = "Name";
            // 
            // modProductLabelID
            // 
            this.modProductLabelID.AutoSize = true;
            this.modProductLabelID.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductLabelID.Location = new System.Drawing.Point(30, 162);
            this.modProductLabelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modProductLabelID.Name = "modProductLabelID";
            this.modProductLabelID.Size = new System.Drawing.Size(18, 15);
            this.modProductLabelID.TabIndex = 24;
            this.modProductLabelID.Text = "ID";
            // 
            // modProductTitle
            // 
            this.modProductTitle.AutoSize = true;
            this.modProductTitle.Font = new System.Drawing.Font("Nirmala Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductTitle.Location = new System.Drawing.Point(29, 31);
            this.modProductTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modProductTitle.Name = "modProductTitle";
            this.modProductTitle.Size = new System.Drawing.Size(141, 25);
            this.modProductTitle.TabIndex = 46;
            this.modProductTitle.Text = "Modify Product";
            // 
            // modProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 550);
            this.Controls.Add(this.modProductTitle);
            this.Controls.Add(this.modProductBtnSave);
            this.Controls.Add(this.modProductBtnCancel);
            this.Controls.Add(this.modProductLabelGrid2);
            this.Controls.Add(this.modProductBtnDelete);
            this.Controls.Add(this.modProductGrid2);
            this.Controls.Add(this.modProductBtnAdd);
            this.Controls.Add(this.modProductBtnSearch);
            this.Controls.Add(this.modProductPartSearchBox);
            this.Controls.Add(this.modProductMinBox);
            this.Controls.Add(this.modProductMaxBox);
            this.Controls.Add(this.modProductPriceBox);
            this.Controls.Add(this.modProductInventoryBox);
            this.Controls.Add(this.modProductNameBox);
            this.Controls.Add(this.modProductIDBox);
            this.Controls.Add(this.modProductLabelGrid1);
            this.Controls.Add(this.modProductGrid1);
            this.Controls.Add(this.modProductLabelMin);
            this.Controls.Add(this.modProductLabelMax);
            this.Controls.Add(this.modProductLabelPrice);
            this.Controls.Add(this.modProductLabelInventory);
            this.Controls.Add(this.modProductLabelName);
            this.Controls.Add(this.modProductLabelID);
            this.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "modProduct";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.modProductGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modProductGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button modProductBtnSave;
        private System.Windows.Forms.Button modProductBtnCancel;
        private System.Windows.Forms.Label modProductLabelGrid2;
        private System.Windows.Forms.Button modProductBtnDelete;
        private System.Windows.Forms.DataGridView modProductGrid2;
        private System.Windows.Forms.Button modProductBtnAdd;
        private System.Windows.Forms.Button modProductBtnSearch;
        private System.Windows.Forms.TextBox modProductPartSearchBox;
        private System.Windows.Forms.TextBox modProductMinBox;
        private System.Windows.Forms.TextBox modProductMaxBox;
        private System.Windows.Forms.TextBox modProductPriceBox;
        private System.Windows.Forms.TextBox modProductInventoryBox;
        private System.Windows.Forms.TextBox modProductNameBox;
        private System.Windows.Forms.TextBox modProductIDBox;
        private System.Windows.Forms.Label modProductLabelGrid1;
        private System.Windows.Forms.DataGridView modProductGrid1;
        private System.Windows.Forms.Label modProductLabelMin;
        private System.Windows.Forms.Label modProductLabelMax;
        private System.Windows.Forms.Label modProductLabelPrice;
        private System.Windows.Forms.Label modProductLabelInventory;
        private System.Windows.Forms.Label modProductLabelName;
        private System.Windows.Forms.Label modProductLabelID;
        private System.Windows.Forms.Label modProductTitle;
    }
}