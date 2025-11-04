namespace Inventory_Management_System
{
    partial class addPart
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
            this.addPartInhouseRadioButton = new System.Windows.Forms.RadioButton();
            this.addPartOutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.addPartID = new System.Windows.Forms.Label();
            this.addPartName = new System.Windows.Forms.Label();
            this.addPartInventory = new System.Windows.Forms.Label();
            this.addPartPrice = new System.Windows.Forms.Label();
            this.addPartMax = new System.Windows.Forms.Label();
            this.addPartMin = new System.Windows.Forms.Label();
            this.addPartMachineID = new System.Windows.Forms.Label();
            this.addPartIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPartCostTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPartMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartMacComTextBox = new System.Windows.Forms.TextBox();
            this.savePartButton = new System.Windows.Forms.Button();
            this.cancelPartCreationButton = new System.Windows.Forms.Button();
            this.addPartTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPartInhouseRadioButton
            // 
            this.addPartInhouseRadioButton.AutoSize = true;
            this.addPartInhouseRadioButton.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInhouseRadioButton.Location = new System.Drawing.Point(150, 17);
            this.addPartInhouseRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPartInhouseRadioButton.Name = "addPartInhouseRadioButton";
            this.addPartInhouseRadioButton.Size = new System.Drawing.Size(74, 19);
            this.addPartInhouseRadioButton.TabIndex = 1;
            this.addPartInhouseRadioButton.TabStop = true;
            this.addPartInhouseRadioButton.Text = "In-House";
            this.addPartInhouseRadioButton.UseVisualStyleBackColor = true;
            this.addPartInhouseRadioButton.CheckedChanged += new System.EventHandler(this.InhouseRadioButton_CheckedChanged);
            // 
            // addPartOutsourcedRadioButton
            // 
            this.addPartOutsourcedRadioButton.AutoSize = true;
            this.addPartOutsourcedRadioButton.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartOutsourcedRadioButton.Location = new System.Drawing.Point(278, 18);
            this.addPartOutsourcedRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPartOutsourcedRadioButton.Name = "addPartOutsourcedRadioButton";
            this.addPartOutsourcedRadioButton.Size = new System.Drawing.Size(87, 19);
            this.addPartOutsourcedRadioButton.TabIndex = 2;
            this.addPartOutsourcedRadioButton.TabStop = true;
            this.addPartOutsourcedRadioButton.Text = "Outsourced";
            this.addPartOutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.addPartOutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            // 
            // addPartID
            // 
            this.addPartID.AutoSize = true;
            this.addPartID.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartID.Location = new System.Drawing.Point(96, 84);
            this.addPartID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartID.Name = "addPartID";
            this.addPartID.Size = new System.Drawing.Size(18, 15);
            this.addPartID.TabIndex = 3;
            this.addPartID.Text = "ID";
            // 
            // addPartName
            // 
            this.addPartName.AutoSize = true;
            this.addPartName.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartName.Location = new System.Drawing.Point(76, 122);
            this.addPartName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartName.Name = "addPartName";
            this.addPartName.Size = new System.Drawing.Size(39, 15);
            this.addPartName.TabIndex = 4;
            this.addPartName.Text = "Name";
            // 
            // addPartInventory
            // 
            this.addPartInventory.AutoSize = true;
            this.addPartInventory.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInventory.Location = new System.Drawing.Point(57, 158);
            this.addPartInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartInventory.Name = "addPartInventory";
            this.addPartInventory.Size = new System.Drawing.Size(57, 15);
            this.addPartInventory.TabIndex = 5;
            this.addPartInventory.Text = "Inventory";
            // 
            // addPartPrice
            // 
            this.addPartPrice.AutoSize = true;
            this.addPartPrice.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartPrice.Location = new System.Drawing.Point(43, 192);
            this.addPartPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartPrice.Name = "addPartPrice";
            this.addPartPrice.Size = new System.Drawing.Size(68, 15);
            this.addPartPrice.TabIndex = 6;
            this.addPartPrice.Text = "Price / Cost";
            // 
            // addPartMax
            // 
            this.addPartMax.AutoSize = true;
            this.addPartMax.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMax.Location = new System.Drawing.Point(85, 233);
            this.addPartMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartMax.Name = "addPartMax";
            this.addPartMax.Size = new System.Drawing.Size(29, 15);
            this.addPartMax.TabIndex = 7;
            this.addPartMax.Text = "Max";
            // 
            // addPartMin
            // 
            this.addPartMin.AutoSize = true;
            this.addPartMin.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMin.Location = new System.Drawing.Point(264, 239);
            this.addPartMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartMin.Name = "addPartMin";
            this.addPartMin.Size = new System.Drawing.Size(28, 15);
            this.addPartMin.TabIndex = 8;
            this.addPartMin.Text = "Min";
            // 
            // addPartMachineID
            // 
            this.addPartMachineID.AutoSize = true;
            this.addPartMachineID.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMachineID.Location = new System.Drawing.Point(44, 271);
            this.addPartMachineID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartMachineID.Name = "addPartMachineID";
            this.addPartMachineID.Size = new System.Drawing.Size(67, 15);
            this.addPartMachineID.TabIndex = 9;
            this.addPartMachineID.Text = "Machine ID";
            // 
            // addPartIDTextBox
            // 
            this.addPartIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartIDTextBox.Location = new System.Drawing.Point(150, 87);
            this.addPartIDTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPartIDTextBox.Name = "addPartIDTextBox";
            this.addPartIDTextBox.ReadOnly = true;
            this.addPartIDTextBox.Size = new System.Drawing.Size(116, 30);
            this.addPartIDTextBox.TabIndex = 10;
            // 
            // addPartNameTextBox
            // 
            this.addPartNameTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.addPartNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartNameTextBox.Location = new System.Drawing.Point(150, 120);
            this.addPartNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPartNameTextBox.Name = "addPartNameTextBox";
            this.addPartNameTextBox.Size = new System.Drawing.Size(116, 30);
            this.addPartNameTextBox.TabIndex = 11;
            // 
            // addPartInventoryTextBox
            // 
            this.addPartInventoryTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.addPartInventoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartInventoryTextBox.Location = new System.Drawing.Point(150, 156);
            this.addPartInventoryTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPartInventoryTextBox.Name = "addPartInventoryTextBox";
            this.addPartInventoryTextBox.Size = new System.Drawing.Size(116, 30);
            this.addPartInventoryTextBox.TabIndex = 12;
            // 
            // addPartCostTextBox
            // 
            this.addPartCostTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.addPartCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartCostTextBox.Location = new System.Drawing.Point(150, 190);
            this.addPartCostTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPartCostTextBox.Name = "addPartCostTextBox";
            this.addPartCostTextBox.Size = new System.Drawing.Size(116, 30);
            this.addPartCostTextBox.TabIndex = 13;
            // 
            // addPartMaxTextBox
            // 
            this.addPartMaxTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.addPartMaxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartMaxTextBox.Location = new System.Drawing.Point(150, 230);
            this.addPartMaxTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPartMaxTextBox.Name = "addPartMaxTextBox";
            this.addPartMaxTextBox.Size = new System.Drawing.Size(79, 30);
            this.addPartMaxTextBox.TabIndex = 14;
            // 
            // addPartMinTextBox
            // 
            this.addPartMinTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.addPartMinTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartMinTextBox.Location = new System.Drawing.Point(322, 228);
            this.addPartMinTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPartMinTextBox.Name = "addPartMinTextBox";
            this.addPartMinTextBox.Size = new System.Drawing.Size(86, 30);
            this.addPartMinTextBox.TabIndex = 15;
            // 
            // addPartMacComTextBox
            // 
            this.addPartMacComTextBox.BackColor = System.Drawing.Color.LightCoral;
            this.addPartMacComTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartMacComTextBox.Location = new System.Drawing.Point(150, 269);
            this.addPartMacComTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addPartMacComTextBox.Name = "addPartMacComTextBox";
            this.addPartMacComTextBox.Size = new System.Drawing.Size(116, 30);
            this.addPartMacComTextBox.TabIndex = 16;
            // 
            // savePartButton
            // 
            this.savePartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePartButton.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePartButton.Location = new System.Drawing.Point(268, 323);
            this.savePartButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.savePartButton.Name = "savePartButton";
            this.savePartButton.Size = new System.Drawing.Size(88, 27);
            this.savePartButton.TabIndex = 18;
            this.savePartButton.Text = "Save";
            this.savePartButton.UseVisualStyleBackColor = true;
            this.savePartButton.Click += new System.EventHandler(this.SavePartButton_Click);
            // 
            // cancelPartCreationButton
            // 
            this.cancelPartCreationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelPartCreationButton.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPartCreationButton.Location = new System.Drawing.Point(375, 323);
            this.cancelPartCreationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelPartCreationButton.Name = "cancelPartCreationButton";
            this.cancelPartCreationButton.Size = new System.Drawing.Size(88, 27);
            this.cancelPartCreationButton.TabIndex = 19;
            this.cancelPartCreationButton.Text = "Cancel";
            this.cancelPartCreationButton.UseVisualStyleBackColor = true;
            this.cancelPartCreationButton.Click += new System.EventHandler(this.CancelPartCreationButton_Click);
            // 
            // addPartTitle
            // 
            this.addPartTitle.AutoSize = true;
            this.addPartTitle.Font = new System.Drawing.Font("Nirmala Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartTitle.Location = new System.Drawing.Point(29, 16);
            this.addPartTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addPartTitle.Name = "addPartTitle";
            this.addPartTitle.Size = new System.Drawing.Size(85, 25);
            this.addPartTitle.TabIndex = 20;
            this.addPartTitle.Text = "Add Part";
            // 
            // addPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 387);
            this.Controls.Add(this.addPartTitle);
            this.Controls.Add(this.cancelPartCreationButton);
            this.Controls.Add(this.savePartButton);
            this.Controls.Add(this.addPartMacComTextBox);
            this.Controls.Add(this.addPartMinTextBox);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.addPartCostTextBox);
            this.Controls.Add(this.addPartInventoryTextBox);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.addPartIDTextBox);
            this.Controls.Add(this.addPartMachineID);
            this.Controls.Add(this.addPartMin);
            this.Controls.Add(this.addPartMax);
            this.Controls.Add(this.addPartPrice);
            this.Controls.Add(this.addPartInventory);
            this.Controls.Add(this.addPartName);
            this.Controls.Add(this.addPartID);
            this.Controls.Add(this.addPartOutsourcedRadioButton);
            this.Controls.Add(this.addPartInhouseRadioButton);
            this.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "addPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton addPartInhouseRadioButton;
        private System.Windows.Forms.RadioButton addPartOutsourcedRadioButton;
        private System.Windows.Forms.Label addPartID;
        private System.Windows.Forms.Label addPartName;
        private System.Windows.Forms.Label addPartInventory;
        private System.Windows.Forms.Label addPartPrice;
        private System.Windows.Forms.Label addPartMax;
        private System.Windows.Forms.Label addPartMin;
        private System.Windows.Forms.Label addPartMachineID;
        private System.Windows.Forms.TextBox addPartIDTextBox;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.TextBox addPartInventoryTextBox;
        private System.Windows.Forms.TextBox addPartCostTextBox;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.TextBox addPartMinTextBox;
        private System.Windows.Forms.TextBox addPartMacComTextBox;
        private System.Windows.Forms.Button savePartButton;
        private System.Windows.Forms.Button cancelPartCreationButton;
        private System.Windows.Forms.Label addPartTitle;
    }
}