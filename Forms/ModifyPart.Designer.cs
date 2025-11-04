namespace Inventory_Management_System
{
    partial class modPart
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
            this.modPartBtnCancel = new System.Windows.Forms.Button();
            this.modPartBtnSave = new System.Windows.Forms.Button();
            this.modPartMachineIDBox = new System.Windows.Forms.TextBox();
            this.modPartMinBox = new System.Windows.Forms.TextBox();
            this.modPartMaxBox = new System.Windows.Forms.TextBox();
            this.modPartPriceBox = new System.Windows.Forms.TextBox();
            this.modPartInventoryBox = new System.Windows.Forms.TextBox();
            this.modPartNameBox = new System.Windows.Forms.TextBox();
            this.modPartIDBox = new System.Windows.Forms.TextBox();
            this.modPartLabelMachineID = new System.Windows.Forms.Label();
            this.modPartLabelMin = new System.Windows.Forms.Label();
            this.modPartLabelMax = new System.Windows.Forms.Label();
            this.modPartLabelPrice = new System.Windows.Forms.Label();
            this.modPartLabelInventory = new System.Windows.Forms.Label();
            this.modPartLabelName = new System.Windows.Forms.Label();
            this.modPartLabelID = new System.Windows.Forms.Label();
            this.modPartOutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.modPartInhouseRadioButton = new System.Windows.Forms.RadioButton();
            this.modPartTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modPartBtnCancel
            // 
            this.modPartBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modPartBtnCancel.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartBtnCancel.Location = new System.Drawing.Point(442, 342);
            this.modPartBtnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modPartBtnCancel.Name = "modPartBtnCancel";
            this.modPartBtnCancel.Size = new System.Drawing.Size(88, 27);
            this.modPartBtnCancel.TabIndex = 39;
            this.modPartBtnCancel.Text = "Cancel";
            this.modPartBtnCancel.UseVisualStyleBackColor = true;
            this.modPartBtnCancel.Click += new System.EventHandler(this.CancelPartCreationButton_Click);
            // 
            // modPartBtnSave
            // 
            this.modPartBtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modPartBtnSave.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartBtnSave.Location = new System.Drawing.Point(336, 342);
            this.modPartBtnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modPartBtnSave.Name = "modPartBtnSave";
            this.modPartBtnSave.Size = new System.Drawing.Size(88, 27);
            this.modPartBtnSave.TabIndex = 38;
            this.modPartBtnSave.Text = "Save";
            this.modPartBtnSave.UseVisualStyleBackColor = true;
            this.modPartBtnSave.Click += new System.EventHandler(this.SavePartButton_Click);
            // 
            // modPartMachineIDBox
            // 
            this.modPartMachineIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartMachineIDBox.Location = new System.Drawing.Point(231, 275);
            this.modPartMachineIDBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modPartMachineIDBox.Name = "modPartMachineIDBox";
            this.modPartMachineIDBox.Size = new System.Drawing.Size(116, 30);
            this.modPartMachineIDBox.TabIndex = 37;
            // 
            // modPartMinBox
            // 
            this.modPartMinBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartMinBox.Location = new System.Drawing.Point(403, 233);
            this.modPartMinBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modPartMinBox.Name = "modPartMinBox";
            this.modPartMinBox.Size = new System.Drawing.Size(86, 30);
            this.modPartMinBox.TabIndex = 36;
            // 
            // modPartMaxBox
            // 
            this.modPartMaxBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartMaxBox.Location = new System.Drawing.Point(231, 235);
            this.modPartMaxBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modPartMaxBox.Name = "modPartMaxBox";
            this.modPartMaxBox.Size = new System.Drawing.Size(79, 30);
            this.modPartMaxBox.TabIndex = 35;
            // 
            // modPartPriceBox
            // 
            this.modPartPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartPriceBox.Location = new System.Drawing.Point(231, 194);
            this.modPartPriceBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modPartPriceBox.Name = "modPartPriceBox";
            this.modPartPriceBox.Size = new System.Drawing.Size(116, 30);
            this.modPartPriceBox.TabIndex = 34;
            // 
            // modPartInventoryBox
            // 
            this.modPartInventoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartInventoryBox.Location = new System.Drawing.Point(231, 159);
            this.modPartInventoryBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modPartInventoryBox.Name = "modPartInventoryBox";
            this.modPartInventoryBox.Size = new System.Drawing.Size(116, 30);
            this.modPartInventoryBox.TabIndex = 33;
            // 
            // modPartNameBox
            // 
            this.modPartNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartNameBox.Location = new System.Drawing.Point(231, 125);
            this.modPartNameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modPartNameBox.Name = "modPartNameBox";
            this.modPartNameBox.Size = new System.Drawing.Size(116, 30);
            this.modPartNameBox.TabIndex = 32;
            // 
            // modPartIDBox
            // 
            this.modPartIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartIDBox.Location = new System.Drawing.Point(231, 91);
            this.modPartIDBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modPartIDBox.Name = "modPartIDBox";
            this.modPartIDBox.ReadOnly = true;
            this.modPartIDBox.Size = new System.Drawing.Size(116, 30);
            this.modPartIDBox.TabIndex = 31;
            // 
            // modPartLabelMachineID
            // 
            this.modPartLabelMachineID.AutoSize = true;
            this.modPartLabelMachineID.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartLabelMachineID.Location = new System.Drawing.Point(125, 277);
            this.modPartLabelMachineID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modPartLabelMachineID.Name = "modPartLabelMachineID";
            this.modPartLabelMachineID.Size = new System.Drawing.Size(67, 15);
            this.modPartLabelMachineID.TabIndex = 30;
            this.modPartLabelMachineID.Text = "Machine ID";
            // 
            // modPartLabelMin
            // 
            this.modPartLabelMin.AutoSize = true;
            this.modPartLabelMin.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartLabelMin.Location = new System.Drawing.Point(345, 240);
            this.modPartLabelMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modPartLabelMin.Name = "modPartLabelMin";
            this.modPartLabelMin.Size = new System.Drawing.Size(28, 15);
            this.modPartLabelMin.TabIndex = 29;
            this.modPartLabelMin.Text = "Min";
            // 
            // modPartLabelMax
            // 
            this.modPartLabelMax.AutoSize = true;
            this.modPartLabelMax.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartLabelMax.Location = new System.Drawing.Point(166, 238);
            this.modPartLabelMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modPartLabelMax.Name = "modPartLabelMax";
            this.modPartLabelMax.Size = new System.Drawing.Size(29, 15);
            this.modPartLabelMax.TabIndex = 28;
            this.modPartLabelMax.Text = "Max";
            // 
            // modPartLabelPrice
            // 
            this.modPartLabelPrice.AutoSize = true;
            this.modPartLabelPrice.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartLabelPrice.Location = new System.Drawing.Point(125, 196);
            this.modPartLabelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modPartLabelPrice.Name = "modPartLabelPrice";
            this.modPartLabelPrice.Size = new System.Drawing.Size(68, 15);
            this.modPartLabelPrice.TabIndex = 27;
            this.modPartLabelPrice.Text = "Price / Cost";
            // 
            // modPartLabelInventory
            // 
            this.modPartLabelInventory.AutoSize = true;
            this.modPartLabelInventory.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartLabelInventory.Location = new System.Drawing.Point(138, 163);
            this.modPartLabelInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modPartLabelInventory.Name = "modPartLabelInventory";
            this.modPartLabelInventory.Size = new System.Drawing.Size(57, 15);
            this.modPartLabelInventory.TabIndex = 26;
            this.modPartLabelInventory.Text = "Inventory";
            // 
            // modPartLabelName
            // 
            this.modPartLabelName.AutoSize = true;
            this.modPartLabelName.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartLabelName.Location = new System.Drawing.Point(157, 127);
            this.modPartLabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modPartLabelName.Name = "modPartLabelName";
            this.modPartLabelName.Size = new System.Drawing.Size(39, 15);
            this.modPartLabelName.TabIndex = 25;
            this.modPartLabelName.Text = "Name";
            // 
            // modPartLabelID
            // 
            this.modPartLabelID.AutoSize = true;
            this.modPartLabelID.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartLabelID.Location = new System.Drawing.Point(177, 93);
            this.modPartLabelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modPartLabelID.Name = "modPartLabelID";
            this.modPartLabelID.Size = new System.Drawing.Size(18, 15);
            this.modPartLabelID.TabIndex = 24;
            this.modPartLabelID.Text = "ID";
            // 
            // modPartOutsourcedRadioButton
            // 
            this.modPartOutsourcedRadioButton.AutoSize = true;
            this.modPartOutsourcedRadioButton.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartOutsourcedRadioButton.Location = new System.Drawing.Point(359, 21);
            this.modPartOutsourcedRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modPartOutsourcedRadioButton.Name = "modPartOutsourcedRadioButton";
            this.modPartOutsourcedRadioButton.Size = new System.Drawing.Size(87, 19);
            this.modPartOutsourcedRadioButton.TabIndex = 23;
            this.modPartOutsourcedRadioButton.TabStop = true;
            this.modPartOutsourcedRadioButton.Text = "Outsourced";
            this.modPartOutsourcedRadioButton.UseVisualStyleBackColor = true;
            this.modPartOutsourcedRadioButton.CheckedChanged += new System.EventHandler(this.OutsourcedRadioButton_CheckedChanged);
            // 
            // modPartInhouseRadioButton
            // 
            this.modPartInhouseRadioButton.AutoSize = true;
            this.modPartInhouseRadioButton.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartInhouseRadioButton.Location = new System.Drawing.Point(231, 21);
            this.modPartInhouseRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.modPartInhouseRadioButton.Name = "modPartInhouseRadioButton";
            this.modPartInhouseRadioButton.Size = new System.Drawing.Size(74, 19);
            this.modPartInhouseRadioButton.TabIndex = 22;
            this.modPartInhouseRadioButton.TabStop = true;
            this.modPartInhouseRadioButton.Text = "In-House";
            this.modPartInhouseRadioButton.UseVisualStyleBackColor = true;
            this.modPartInhouseRadioButton.CheckedChanged += new System.EventHandler(this.InhouseRadioButton_CheckedChanged);
            // 
            // modPartTitle
            // 
            this.modPartTitle.AutoSize = true;
            this.modPartTitle.Font = new System.Drawing.Font("Nirmala Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modPartTitle.Location = new System.Drawing.Point(23, 16);
            this.modPartTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modPartTitle.Name = "modPartTitle";
            this.modPartTitle.Size = new System.Drawing.Size(109, 25);
            this.modPartTitle.TabIndex = 40;
            this.modPartTitle.Text = "Modify Part";
            // 
            // modPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 386);
            this.Controls.Add(this.modPartTitle);
            this.Controls.Add(this.modPartBtnCancel);
            this.Controls.Add(this.modPartBtnSave);
            this.Controls.Add(this.modPartMachineIDBox);
            this.Controls.Add(this.modPartMinBox);
            this.Controls.Add(this.modPartMaxBox);
            this.Controls.Add(this.modPartPriceBox);
            this.Controls.Add(this.modPartInventoryBox);
            this.Controls.Add(this.modPartNameBox);
            this.Controls.Add(this.modPartIDBox);
            this.Controls.Add(this.modPartLabelMachineID);
            this.Controls.Add(this.modPartLabelMin);
            this.Controls.Add(this.modPartLabelMax);
            this.Controls.Add(this.modPartLabelPrice);
            this.Controls.Add(this.modPartLabelInventory);
            this.Controls.Add(this.modPartLabelName);
            this.Controls.Add(this.modPartLabelID);
            this.Controls.Add(this.modPartOutsourcedRadioButton);
            this.Controls.Add(this.modPartInhouseRadioButton);
            this.Font = new System.Drawing.Font("Nirmala Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "modPart";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button modPartBtnCancel;
        private System.Windows.Forms.Button modPartBtnSave;
        private System.Windows.Forms.TextBox modPartMachineIDBox;
        private System.Windows.Forms.TextBox modPartMinBox;
        private System.Windows.Forms.TextBox modPartMaxBox;
        private System.Windows.Forms.TextBox modPartPriceBox;
        private System.Windows.Forms.TextBox modPartInventoryBox;
        private System.Windows.Forms.TextBox modPartNameBox;
        private System.Windows.Forms.TextBox modPartIDBox;
        private System.Windows.Forms.Label modPartLabelMachineID;
        private System.Windows.Forms.Label modPartLabelMin;
        private System.Windows.Forms.Label modPartLabelMax;
        private System.Windows.Forms.Label modPartLabelPrice;
        private System.Windows.Forms.Label modPartLabelInventory;
        private System.Windows.Forms.Label modPartLabelName;
        private System.Windows.Forms.Label modPartLabelID;
        private System.Windows.Forms.RadioButton modPartOutsourcedRadioButton;
        private System.Windows.Forms.RadioButton modPartInhouseRadioButton;
        private System.Windows.Forms.Label modPartTitle;
    }
}