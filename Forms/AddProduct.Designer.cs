namespace Inventory_Management_System
{
    partial class addProduct
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
            this.addProductLabelID = new System.Windows.Forms.Label();
            this.addProductLabelName = new System.Windows.Forms.Label();
            this.addProductLabelInventory = new System.Windows.Forms.Label();
            this.addProductLabelPrice = new System.Windows.Forms.Label();
            this.addProductLabelMax = new System.Windows.Forms.Label();
            this.addProductLabeln = new System.Windows.Forms.Label();
            this.addProductGrid1 = new System.Windows.Forms.DataGridView();
            this.addProductLabelGrid1 = new System.Windows.Forms.Label();
            this.addProductIDTextBox = new System.Windows.Forms.TextBox();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.addProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.addProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.addProductMinTextBox = new System.Windows.Forms.TextBox();
            this.addProductSearchBox = new System.Windows.Forms.TextBox();
            this.addProductBtnSearch = new System.Windows.Forms.Button();
            this.addProductBtnAdd = new System.Windows.Forms.Button();
            this.addProductGrid2 = new System.Windows.Forms.DataGridView();
            this.addProductBtnDelete = new System.Windows.Forms.Button();
            this.addProductLabelGrid2 = new System.Windows.Forms.Label();
            this.addProductBtnCancel = new System.Windows.Forms.Button();
            this.addProductBtnSave = new System.Windows.Forms.Button();
            this.addProductTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductLabelID
            // 
            this.addProductLabelID.AutoSize = true;
            this.addProductLabelID.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabelID.Location = new System.Drawing.Point(24, 162);
            this.addProductLabelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductLabelID.Name = "addProductLabelID";
            this.addProductLabelID.Size = new System.Drawing.Size(18, 15);
            this.addProductLabelID.TabIndex = 1;
            this.addProductLabelID.Text = "ID";
            // 
            // addProductLabelName
            // 
            this.addProductLabelName.AutoSize = true;
            this.addProductLabelName.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabelName.Location = new System.Drawing.Point(24, 203);
            this.addProductLabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductLabelName.Name = "addProductLabelName";
            this.addProductLabelName.Size = new System.Drawing.Size(39, 15);
            this.addProductLabelName.TabIndex = 2;
            this.addProductLabelName.Text = "Name";
            // 
            // addProductLabelInventory
            // 
            this.addProductLabelInventory.AutoSize = true;
            this.addProductLabelInventory.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabelInventory.Location = new System.Drawing.Point(24, 246);
            this.addProductLabelInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductLabelInventory.Name = "addProductLabelInventory";
            this.addProductLabelInventory.Size = new System.Drawing.Size(57, 15);
            this.addProductLabelInventory.TabIndex = 3;
            this.addProductLabelInventory.Text = "Inventory";
            // 
            // addProductLabelPrice
            // 
            this.addProductLabelPrice.AutoSize = true;
            this.addProductLabelPrice.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabelPrice.Location = new System.Drawing.Point(24, 287);
            this.addProductLabelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductLabelPrice.Name = "addProductLabelPrice";
            this.addProductLabelPrice.Size = new System.Drawing.Size(68, 15);
            this.addProductLabelPrice.TabIndex = 4;
            this.addProductLabelPrice.Text = "Price / Cost";
            this.addProductLabelPrice.Click += new System.EventHandler(this.addProductLabelPrice_Click);
            // 
            // addProductLabelMax
            // 
            this.addProductLabelMax.AutoSize = true;
            this.addProductLabelMax.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabelMax.Location = new System.Drawing.Point(24, 340);
            this.addProductLabelMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductLabelMax.Name = "addProductLabelMax";
            this.addProductLabelMax.Size = new System.Drawing.Size(29, 15);
            this.addProductLabelMax.TabIndex = 5;
            this.addProductLabelMax.Text = "Max";
            // 
            // addProductLabeln
            // 
            this.addProductLabeln.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductLabeln.AutoSize = true;
            this.addProductLabeln.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabeln.Location = new System.Drawing.Point(190, 340);
            this.addProductLabeln.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductLabeln.Name = "addProductLabeln";
            this.addProductLabeln.Size = new System.Drawing.Size(28, 15);
            this.addProductLabeln.TabIndex = 6;
            this.addProductLabeln.Text = "Min";
            // 
            // addProductGrid1
            // 
            this.addProductGrid1.AllowUserToAddRows = false;
            this.addProductGrid1.AllowUserToDeleteRows = false;
            this.addProductGrid1.AllowUserToResizeColumns = false;
            this.addProductGrid1.AllowUserToResizeRows = false;
            this.addProductGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addProductGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addProductGrid1.Location = new System.Drawing.Point(398, 71);
            this.addProductGrid1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductGrid1.MultiSelect = false;
            this.addProductGrid1.Name = "addProductGrid1";
            this.addProductGrid1.RowHeadersVisible = false;
            this.addProductGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addProductGrid1.Size = new System.Drawing.Size(497, 137);
            this.addProductGrid1.TabIndex = 7;
            // 
            // addProductLabelGrid1
            // 
            this.addProductLabelGrid1.AutoSize = true;
            this.addProductLabelGrid1.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabelGrid1.Location = new System.Drawing.Point(395, 47);
            this.addProductLabelGrid1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductLabelGrid1.Name = "addProductLabelGrid1";
            this.addProductLabelGrid1.Size = new System.Drawing.Size(140, 21);
            this.addProductLabelGrid1.TabIndex = 8;
            this.addProductLabelGrid1.Text = "All Candidate Parts";
            this.addProductLabelGrid1.Click += new System.EventHandler(this.addProductLabelGrid1_Click);
            // 
            // addProductIDTextBox
            // 
            this.addProductIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductIDTextBox.Location = new System.Drawing.Point(135, 158);
            this.addProductIDTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductIDTextBox.Name = "addProductIDTextBox";
            this.addProductIDTextBox.ReadOnly = true;
            this.addProductIDTextBox.Size = new System.Drawing.Size(92, 30);
            this.addProductIDTextBox.TabIndex = 9;
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.addProductNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductNameTextBox.Location = new System.Drawing.Point(135, 200);
            this.addProductNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(92, 30);
            this.addProductNameTextBox.TabIndex = 10;
            // 
            // addProductInventoryTextBox
            // 
            this.addProductInventoryTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.addProductInventoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductInventoryTextBox.Location = new System.Drawing.Point(135, 244);
            this.addProductInventoryTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductInventoryTextBox.Name = "addProductInventoryTextBox";
            this.addProductInventoryTextBox.Size = new System.Drawing.Size(92, 30);
            this.addProductInventoryTextBox.TabIndex = 11;
            // 
            // addProductPriceTextBox
            // 
            this.addProductPriceTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.addProductPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductPriceTextBox.Location = new System.Drawing.Point(135, 285);
            this.addProductPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductPriceTextBox.Name = "addProductPriceTextBox";
            this.addProductPriceTextBox.Size = new System.Drawing.Size(92, 30);
            this.addProductPriceTextBox.TabIndex = 12;
            // 
            // addProductMaxTextBox
            // 
            this.addProductMaxTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.addProductMaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductMaxTextBox.Location = new System.Drawing.Point(74, 338);
            this.addProductMaxTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductMaxTextBox.Name = "addProductMaxTextBox";
            this.addProductMaxTextBox.Size = new System.Drawing.Size(92, 30);
            this.addProductMaxTextBox.TabIndex = 13;
            // 
            // addProductMinTextBox
            // 
            this.addProductMinTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.addProductMinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductMinTextBox.Location = new System.Drawing.Point(226, 338);
            this.addProductMinTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductMinTextBox.Name = "addProductMinTextBox";
            this.addProductMinTextBox.Size = new System.Drawing.Size(92, 30);
            this.addProductMinTextBox.TabIndex = 14;
            this.addProductMinTextBox.TextChanged += new System.EventHandler(this.addProductMinTextBox_TextChanged);
            // 
            // addProductSearchBox
            // 
            this.addProductSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProductSearchBox.Location = new System.Drawing.Point(692, 30);
            this.addProductSearchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductSearchBox.Name = "addProductSearchBox";
            this.addProductSearchBox.Size = new System.Drawing.Size(203, 30);
            this.addProductSearchBox.TabIndex = 15;
            // 
            // addProductBtnSearch
            // 
            this.addProductBtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtnSearch.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtnSearch.Location = new System.Drawing.Point(601, 31);
            this.addProductBtnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductBtnSearch.Name = "addProductBtnSearch";
            this.addProductBtnSearch.Size = new System.Drawing.Size(88, 27);
            this.addProductBtnSearch.TabIndex = 16;
            this.addProductBtnSearch.Text = "Search";
            this.addProductBtnSearch.UseVisualStyleBackColor = true;
            this.addProductBtnSearch.Click += new System.EventHandler(this.SearchPartListButton_Click);
            // 
            // addProductBtnAdd
            // 
            this.addProductBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtnAdd.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtnAdd.Location = new System.Drawing.Point(807, 214);
            this.addProductBtnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductBtnAdd.Name = "addProductBtnAdd";
            this.addProductBtnAdd.Size = new System.Drawing.Size(88, 27);
            this.addProductBtnAdd.TabIndex = 17;
            this.addProductBtnAdd.Text = "Add";
            this.addProductBtnAdd.UseVisualStyleBackColor = true;
            this.addProductBtnAdd.Click += new System.EventHandler(this.AddAssociatedPartButton_Click);
            // 
            // addProductGrid2
            // 
            this.addProductGrid2.AllowUserToAddRows = false;
            this.addProductGrid2.AllowUserToDeleteRows = false;
            this.addProductGrid2.AllowUserToResizeColumns = false;
            this.addProductGrid2.AllowUserToResizeRows = false;
            this.addProductGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addProductGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductGrid2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addProductGrid2.Location = new System.Drawing.Point(398, 278);
            this.addProductGrid2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductGrid2.MultiSelect = false;
            this.addProductGrid2.Name = "addProductGrid2";
            this.addProductGrid2.RowHeadersVisible = false;
            this.addProductGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addProductGrid2.Size = new System.Drawing.Size(497, 137);
            this.addProductGrid2.TabIndex = 18;
            // 
            // addProductBtnDelete
            // 
            this.addProductBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtnDelete.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtnDelete.Location = new System.Drawing.Point(807, 431);
            this.addProductBtnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductBtnDelete.Name = "addProductBtnDelete";
            this.addProductBtnDelete.Size = new System.Drawing.Size(88, 27);
            this.addProductBtnDelete.TabIndex = 19;
            this.addProductBtnDelete.Text = "Delete";
            this.addProductBtnDelete.UseVisualStyleBackColor = true;
            this.addProductBtnDelete.Click += new System.EventHandler(this.DeleteAssociatedPartButton_Click);
            // 
            // addProductLabelGrid2
            // 
            this.addProductLabelGrid2.AutoSize = true;
            this.addProductLabelGrid2.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductLabelGrid2.Location = new System.Drawing.Point(395, 254);
            this.addProductLabelGrid2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductLabelGrid2.Name = "addProductLabelGrid2";
            this.addProductLabelGrid2.Size = new System.Drawing.Size(262, 21);
            this.addProductLabelGrid2.TabIndex = 20;
            this.addProductLabelGrid2.Text = "Parts Associated with this Product";
            // 
            // addProductBtnCancel
            // 
            this.addProductBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtnCancel.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtnCancel.Location = new System.Drawing.Point(807, 489);
            this.addProductBtnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductBtnCancel.Name = "addProductBtnCancel";
            this.addProductBtnCancel.Size = new System.Drawing.Size(88, 27);
            this.addProductBtnCancel.TabIndex = 21;
            this.addProductBtnCancel.Text = "Cancel";
            this.addProductBtnCancel.UseVisualStyleBackColor = true;
            this.addProductBtnCancel.Click += new System.EventHandler(this.CancelAddProductbutton_Click);
            // 
            // addProductBtnSave
            // 
            this.addProductBtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtnSave.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtnSave.Location = new System.Drawing.Point(693, 489);
            this.addProductBtnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addProductBtnSave.Name = "addProductBtnSave";
            this.addProductBtnSave.Size = new System.Drawing.Size(88, 27);
            this.addProductBtnSave.TabIndex = 22;
            this.addProductBtnSave.Text = "Save";
            this.addProductBtnSave.UseVisualStyleBackColor = true;
            this.addProductBtnSave.Click += new System.EventHandler(this.SaveAddProductButton_Click);
            // 
            // addProductTitle
            // 
            this.addProductTitle.AutoSize = true;
            this.addProductTitle.Font = new System.Drawing.Font("Nirmala Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductTitle.Location = new System.Drawing.Point(23, 31);
            this.addProductTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductTitle.Name = "addProductTitle";
            this.addProductTitle.Size = new System.Drawing.Size(117, 25);
            this.addProductTitle.TabIndex = 23;
            this.addProductTitle.Text = "Add Product";
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 550);
            this.Controls.Add(this.addProductTitle);
            this.Controls.Add(this.addProductBtnSave);
            this.Controls.Add(this.addProductBtnCancel);
            this.Controls.Add(this.addProductLabelGrid2);
            this.Controls.Add(this.addProductBtnDelete);
            this.Controls.Add(this.addProductGrid2);
            this.Controls.Add(this.addProductBtnAdd);
            this.Controls.Add(this.addProductBtnSearch);
            this.Controls.Add(this.addProductSearchBox);
            this.Controls.Add(this.addProductMinTextBox);
            this.Controls.Add(this.addProductMaxTextBox);
            this.Controls.Add(this.addProductPriceTextBox);
            this.Controls.Add(this.addProductInventoryTextBox);
            this.Controls.Add(this.addProductNameTextBox);
            this.Controls.Add(this.addProductIDTextBox);
            this.Controls.Add(this.addProductLabelGrid1);
            this.Controls.Add(this.addProductGrid1);
            this.Controls.Add(this.addProductLabeln);
            this.Controls.Add(this.addProductLabelMax);
            this.Controls.Add(this.addProductLabelPrice);
            this.Controls.Add(this.addProductLabelInventory);
            this.Controls.Add(this.addProductLabelName);
            this.Controls.Add(this.addProductLabelID);
            this.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "addProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label addProductLabelID;
        private System.Windows.Forms.Label addProductLabelName;
        private System.Windows.Forms.Label addProductLabelInventory;
        private System.Windows.Forms.Label addProductLabelPrice;
        private System.Windows.Forms.Label addProductLabelMax;
        private System.Windows.Forms.Label addProductLabeln;
        private System.Windows.Forms.DataGridView addProductGrid1;
        private System.Windows.Forms.Label addProductLabelGrid1;
        private System.Windows.Forms.TextBox addProductIDTextBox;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.TextBox addProductInventoryTextBox;
        private System.Windows.Forms.TextBox addProductPriceTextBox;
        private System.Windows.Forms.TextBox addProductMaxTextBox;
        private System.Windows.Forms.TextBox addProductMinTextBox;
        private System.Windows.Forms.TextBox addProductSearchBox;
        private System.Windows.Forms.Button addProductBtnSearch;
        private System.Windows.Forms.Button addProductBtnAdd;
        private System.Windows.Forms.DataGridView addProductGrid2;
        private System.Windows.Forms.Button addProductBtnDelete;
        private System.Windows.Forms.Label addProductLabelGrid2;
        private System.Windows.Forms.Button addProductBtnCancel;
        private System.Windows.Forms.Button addProductBtnSave;
        private System.Windows.Forms.Label addProductTitle;
    }
}