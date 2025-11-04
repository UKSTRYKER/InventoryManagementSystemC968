using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class addPart : Form
    {

        public addPart()
        {
            InitializeComponent();
        }
        private void SavePartButton_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;

            try
            {
                minStock = int.Parse(addPartMinTextBox.Text);
                maxStock = int.Parse(addPartMaxTextBox.Text);
                invInStock = int.Parse(addPartInventoryTextBox.Text);
                price = decimal.Parse(addPartCostTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }



            string name = addPartNameTextBox.Text;
            price = decimal.Parse(addPartCostTextBox.Text);
            minStock = int.Parse(addPartMinTextBox.Text);
            maxStock = int.Parse(addPartMaxTextBox.Text);
            invInStock = int.Parse(addPartInventoryTextBox.Text);


            if (minStock > maxStock)
            {
                MessageBox.Show("Error: Max must be greater than min");
                return;
            }

            if (invInStock > maxStock || invInStock < minStock)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }


            if (addPartInhouseRadioButton.Checked)
            {
                InHouse inPart = new InHouse((Inventory.Parts.Count + 1), name, invInStock, price, maxStock, minStock, int.Parse(addPartMacComTextBox.Text));
                Inventory.AddPart(inPart);

            }
            else
            {
                Outsourced outPart = new Outsourced((Inventory.Parts.Count + 1), name, invInStock, price, maxStock, minStock, addPartMacComTextBox.Text);
                Inventory.AddPart(outPart);

            }
            Close();

        }
        private void InhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            addPartMachineID.Text = "Machine ID";
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            addPartMachineID.Text = "Company Name";
        }
        private void CancelPartCreationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}