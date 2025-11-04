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
    public partial class modPart : Form
    {
        mainForm MainWindow = (mainForm)Application.OpenForms["MainForm"];

        public modPart(InHouse inPart)
        {
            InitializeComponent();
            modPartIDBox.Text = inPart.PartID.ToString();
            modPartNameBox.Text = inPart.Name;
            modPartInventoryBox.Text = inPart.Inventory.ToString();
            modPartPriceBox.Text = inPart.Price.Substring(1).ToString();
            modPartMaxBox.Text = inPart.Max.ToString();
            modPartMinBox.Text = inPart.Min.ToString();
            modPartMachineIDBox.Text = inPart.MachineID.ToString();
        }

        public modPart(Outsourced outPart)
        {
            InitializeComponent();
            modPartIDBox.Text = outPart.PartID.ToString();
            modPartNameBox.Text = outPart.Name;
            modPartInventoryBox.Text = outPart.Inventory.ToString();
            modPartPriceBox.Text = outPart.Price.Substring(1).ToString();
            modPartMaxBox.Text = outPart.Max.ToString();
            modPartMinBox.Text = outPart.Min.ToString();
            modPartMachineIDBox.Text = outPart.CompName;
            modPartOutsourcedRadioButton.Checked = true;
            modPartLabelMachineID.Text = "Company Name";
        }

        private void SavePartButton_Click(object sender, EventArgs e)
        {
            int minStock;
            int maxStock;
            int invInStock;
            decimal price;
            int id = int.Parse(modPartIDBox.Text);

            try
            {
                minStock = int.Parse(modPartMinBox.Text);
                maxStock = int.Parse(modPartMaxBox.Text);
                invInStock = int.Parse(modPartInventoryBox.Text);
                price = decimal.Parse(modPartPriceBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }

            string name = modPartNameBox.Text;
            price = decimal.Parse(modPartPriceBox.Text);
            minStock = int.Parse(modPartMinBox.Text);
            maxStock = int.Parse(modPartMaxBox.Text);
            invInStock = int.Parse(modPartInventoryBox.Text);

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

            if (modPartInhouseRadioButton.Checked)
            {
                InHouse inPart = new InHouse(id, name, invInStock, price, maxStock, minStock, int.Parse(modPartMachineIDBox.Text));
                Inventory.UpdatePart(id, inPart);
                modPartInhouseRadioButton.Checked = true;
            }
            else
            {
                Outsourced outPart = new Outsourced(id, name, invInStock, price, maxStock, minStock, modPartMachineIDBox.Text);
                Inventory.UpdatePart(id, outPart);
                modPartOutsourcedRadioButton.Checked = true;
            }
            Close();
            MainWindow.mainFormPartGrid.Update();
            MainWindow.mainFormPartGrid.Refresh();
        }
        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            modPartLabelMachineID.Text = "Company Name";
        }
        private void InhouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            modPartLabelMachineID.Text = "Machine ID";
        }
        private void CancelPartCreationButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}