namespace Inventory_Management_System
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.mainFormBtnPartAdd = new System.Windows.Forms.Button();
            this.mainFormBtnPartModify = new System.Windows.Forms.Button();
            this.mainFormPartGrid = new System.Windows.Forms.DataGridView();
            this.mainFormBtnPartDelete = new System.Windows.Forms.Button();
            this.mainFormLabelParts = new System.Windows.Forms.Label();
            this.mainFormProductSeachBox = new System.Windows.Forms.TextBox();
            this.mainFormProductSeachBtn = new System.Windows.Forms.Button();
            this.mainFormPartSeachBox = new System.Windows.Forms.TextBox();
            this.mainFormBtnProductAdd = new System.Windows.Forms.Button();
            this.mainFormPartSeachBtn = new System.Windows.Forms.Button();
            this.mainFormBtnProductModify = new System.Windows.Forms.Button();
            this.mainFormProductGrid = new System.Windows.Forms.DataGridView();
            this.mainFormBtnProductDelete = new System.Windows.Forms.Button();
            this.mainFormBtnExit = new System.Windows.Forms.Button();
            this.mainFormLabelProducts = new System.Windows.Forms.Label();
            this.mainFormTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormPartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormProductGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormBtnPartAdd
            // 
            this.mainFormBtnPartAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormBtnPartAdd.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormBtnPartAdd.Location = new System.Drawing.Point(220, 312);
            this.mainFormBtnPartAdd.Name = "mainFormBtnPartAdd";
            this.mainFormBtnPartAdd.Size = new System.Drawing.Size(75, 23);
            this.mainFormBtnPartAdd.TabIndex = 17;
            this.mainFormBtnPartAdd.Text = "Add";
            this.mainFormBtnPartAdd.UseVisualStyleBackColor = true;
            this.mainFormBtnPartAdd.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // mainFormBtnPartModify
            // 
            this.mainFormBtnPartModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormBtnPartModify.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormBtnPartModify.Location = new System.Drawing.Point(301, 312);
            this.mainFormBtnPartModify.Name = "mainFormBtnPartModify";
            this.mainFormBtnPartModify.Size = new System.Drawing.Size(75, 23);
            this.mainFormBtnPartModify.TabIndex = 18;
            this.mainFormBtnPartModify.Text = "Modify";
            this.mainFormBtnPartModify.UseVisualStyleBackColor = true;
            this.mainFormBtnPartModify.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // mainFormPartGrid
            // 
            this.mainFormPartGrid.AllowUserToAddRows = false;
            this.mainFormPartGrid.AllowUserToDeleteRows = false;
            this.mainFormPartGrid.AllowUserToResizeColumns = false;
            this.mainFormPartGrid.AllowUserToResizeRows = false;
            this.mainFormPartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainFormPartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainFormPartGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainFormPartGrid.Location = new System.Drawing.Point(57, 115);
            this.mainFormPartGrid.MultiSelect = false;
            this.mainFormPartGrid.Name = "mainFormPartGrid";
            this.mainFormPartGrid.RowHeadersVisible = false;
            this.mainFormPartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainFormPartGrid.Size = new System.Drawing.Size(400, 171);
            this.mainFormPartGrid.TabIndex = 13;
            // 
            // mainFormBtnPartDelete
            // 
            this.mainFormBtnPartDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormBtnPartDelete.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormBtnPartDelete.Location = new System.Drawing.Point(382, 312);
            this.mainFormBtnPartDelete.Name = "mainFormBtnPartDelete";
            this.mainFormBtnPartDelete.Size = new System.Drawing.Size(75, 23);
            this.mainFormBtnPartDelete.TabIndex = 19;
            this.mainFormBtnPartDelete.Text = "Delete";
            this.mainFormBtnPartDelete.UseVisualStyleBackColor = true;
            this.mainFormBtnPartDelete.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // mainFormLabelParts
            // 
            this.mainFormLabelParts.AutoSize = true;
            this.mainFormLabelParts.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormLabelParts.Location = new System.Drawing.Point(53, 82);
            this.mainFormLabelParts.Name = "mainFormLabelParts";
            this.mainFormLabelParts.Size = new System.Drawing.Size(44, 21);
            this.mainFormLabelParts.TabIndex = 20;
            this.mainFormLabelParts.Text = "Parts";
            // 
            // mainFormProductSeachBox
            // 
            this.mainFormProductSeachBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainFormProductSeachBox.Location = new System.Drawing.Point(806, 79);
            this.mainFormProductSeachBox.Name = "mainFormProductSeachBox";
            this.mainFormProductSeachBox.Size = new System.Drawing.Size(156, 30);
            this.mainFormProductSeachBox.TabIndex = 16;
            // 
            // mainFormProductSeachBtn
            // 
            this.mainFormProductSeachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormProductSeachBtn.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormProductSeachBtn.Location = new System.Drawing.Point(710, 76);
            this.mainFormProductSeachBtn.Name = "mainFormProductSeachBtn";
            this.mainFormProductSeachBtn.Size = new System.Drawing.Size(75, 23);
            this.mainFormProductSeachBtn.TabIndex = 15;
            this.mainFormProductSeachBtn.Text = "Search";
            this.mainFormProductSeachBtn.UseVisualStyleBackColor = true;
            this.mainFormProductSeachBtn.Click += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // mainFormPartSeachBox
            // 
            this.mainFormPartSeachBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainFormPartSeachBox.Location = new System.Drawing.Point(301, 79);
            this.mainFormPartSeachBox.Name = "mainFormPartSeachBox";
            this.mainFormPartSeachBox.Size = new System.Drawing.Size(156, 30);
            this.mainFormPartSeachBox.TabIndex = 16;
            // 
            // mainFormBtnProductAdd
            // 
            this.mainFormBtnProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormBtnProductAdd.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormBtnProductAdd.Location = new System.Drawing.Point(725, 312);
            this.mainFormBtnProductAdd.Name = "mainFormBtnProductAdd";
            this.mainFormBtnProductAdd.Size = new System.Drawing.Size(75, 23);
            this.mainFormBtnProductAdd.TabIndex = 17;
            this.mainFormBtnProductAdd.Text = "Add";
            this.mainFormBtnProductAdd.UseVisualStyleBackColor = true;
            this.mainFormBtnProductAdd.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // mainFormPartSeachBtn
            // 
            this.mainFormPartSeachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormPartSeachBtn.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormPartSeachBtn.Location = new System.Drawing.Point(208, 82);
            this.mainFormPartSeachBtn.Name = "mainFormPartSeachBtn";
            this.mainFormPartSeachBtn.Size = new System.Drawing.Size(75, 23);
            this.mainFormPartSeachBtn.TabIndex = 15;
            this.mainFormPartSeachBtn.Text = "Search";
            this.mainFormPartSeachBtn.UseVisualStyleBackColor = true;
            this.mainFormPartSeachBtn.Click += new System.EventHandler(this.SearchPartButton_Click);
            // 
            // mainFormBtnProductModify
            // 
            this.mainFormBtnProductModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormBtnProductModify.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormBtnProductModify.Location = new System.Drawing.Point(806, 312);
            this.mainFormBtnProductModify.Name = "mainFormBtnProductModify";
            this.mainFormBtnProductModify.Size = new System.Drawing.Size(75, 23);
            this.mainFormBtnProductModify.TabIndex = 18;
            this.mainFormBtnProductModify.Text = "Modify";
            this.mainFormBtnProductModify.UseVisualStyleBackColor = true;
            this.mainFormBtnProductModify.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // mainFormProductGrid
            // 
            this.mainFormProductGrid.AllowUserToAddRows = false;
            this.mainFormProductGrid.AllowUserToDeleteRows = false;
            this.mainFormProductGrid.AllowUserToResizeColumns = false;
            this.mainFormProductGrid.AllowUserToResizeRows = false;
            this.mainFormProductGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainFormProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainFormProductGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mainFormProductGrid.Location = new System.Drawing.Point(562, 115);
            this.mainFormProductGrid.MultiSelect = false;
            this.mainFormProductGrid.Name = "mainFormProductGrid";
            this.mainFormProductGrid.RowHeadersVisible = false;
            this.mainFormProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainFormProductGrid.Size = new System.Drawing.Size(400, 171);
            this.mainFormProductGrid.TabIndex = 13;
            // 
            // mainFormBtnProductDelete
            // 
            this.mainFormBtnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormBtnProductDelete.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormBtnProductDelete.Location = new System.Drawing.Point(887, 312);
            this.mainFormBtnProductDelete.Name = "mainFormBtnProductDelete";
            this.mainFormBtnProductDelete.Size = new System.Drawing.Size(75, 23);
            this.mainFormBtnProductDelete.TabIndex = 19;
            this.mainFormBtnProductDelete.Text = "Delete";
            this.mainFormBtnProductDelete.UseVisualStyleBackColor = true;
            this.mainFormBtnProductDelete.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // mainFormBtnExit
            // 
            this.mainFormBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormBtnExit.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormBtnExit.Location = new System.Drawing.Point(887, 361);
            this.mainFormBtnExit.Name = "mainFormBtnExit";
            this.mainFormBtnExit.Size = new System.Drawing.Size(75, 23);
            this.mainFormBtnExit.TabIndex = 21;
            this.mainFormBtnExit.Text = "Exit";
            this.mainFormBtnExit.UseVisualStyleBackColor = true;
            this.mainFormBtnExit.Click += new System.EventHandler(this.ExitAppButton_Click);
            // 
            // mainFormLabelProducts
            // 
            this.mainFormLabelProducts.AutoSize = true;
            this.mainFormLabelProducts.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormLabelProducts.Location = new System.Drawing.Point(558, 79);
            this.mainFormLabelProducts.Name = "mainFormLabelProducts";
            this.mainFormLabelProducts.Size = new System.Drawing.Size(71, 21);
            this.mainFormLabelProducts.TabIndex = 20;
            this.mainFormLabelProducts.Text = "Products";
            // 
            // mainFormTitle
            // 
            this.mainFormTitle.AutoSize = true;
            this.mainFormTitle.Font = new System.Drawing.Font("Nirmala Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormTitle.Location = new System.Drawing.Point(52, 19);
            this.mainFormTitle.Name = "mainFormTitle";
            this.mainFormTitle.Size = new System.Drawing.Size(273, 25);
            this.mainFormTitle.TabIndex = 22;
            this.mainFormTitle.Text = "Inventory Management System";
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(1028, 407);
            this.Controls.Add(this.mainFormTitle);
            this.Controls.Add(this.mainFormPartSeachBtn);
            this.Controls.Add(this.mainFormLabelProducts);
            this.Controls.Add(this.mainFormPartSeachBox);
            this.Controls.Add(this.mainFormLabelParts);
            this.Controls.Add(this.mainFormBtnExit);
            this.Controls.Add(this.mainFormBtnProductDelete);
            this.Controls.Add(this.mainFormBtnPartDelete);
            this.Controls.Add(this.mainFormProductGrid);
            this.Controls.Add(this.mainFormBtnProductModify);
            this.Controls.Add(this.mainFormPartGrid);
            this.Controls.Add(this.mainFormBtnPartAdd);
            this.Controls.Add(this.mainFormBtnProductAdd);
            this.Controls.Add(this.mainFormBtnPartModify);
            this.Controls.Add(this.mainFormProductSeachBox);
            this.Controls.Add(this.mainFormProductSeachBtn);
            this.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "mainForm";
            this.Text = "Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)(this.mainFormPartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormProductGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button mainFormBtnPartAdd;
        private System.Windows.Forms.Button mainFormBtnPartModify;
        public System.Windows.Forms.DataGridView mainFormPartGrid;
        private System.Windows.Forms.Button mainFormBtnPartDelete;
        private System.Windows.Forms.Label mainFormLabelParts;
        private System.Windows.Forms.TextBox mainFormProductSeachBox;
        private System.Windows.Forms.Button mainFormProductSeachBtn;
        private System.Windows.Forms.TextBox mainFormPartSeachBox;
        private System.Windows.Forms.Button mainFormBtnProductAdd;
        private System.Windows.Forms.Button mainFormPartSeachBtn;
        private System.Windows.Forms.Button mainFormBtnProductModify;
        public System.Windows.Forms.DataGridView mainFormProductGrid;
        private System.Windows.Forms.Button mainFormBtnProductDelete;
        private System.Windows.Forms.Button mainFormBtnExit;
        private System.Windows.Forms.Label mainFormLabelProducts;
        private System.Windows.Forms.Label mainFormTitle;
    }
}