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
    public partial class modProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        mainForm MainWindow = (mainForm)Application.OpenForms["MainForm"];
        public modProduct(Product prod)
        {
            InitializeComponent();

            modProductIDBox.Text = prod.ProductID.ToString();
            modProductNameBox.Text = prod.Name;
            modProductInventoryBox.Text = prod.Inventory.ToString();
            modProductPriceBox.Text = prod.Price.Substring(1).ToString();
            modProductMaxBox.Text = prod.Max.ToString();
            modProductMinBox.Text = prod.Min.ToString();

            var topTable = new BindingSource();
            topTable.DataSource = Inventory.Parts;
            modProductGrid1.DataSource = topTable;

            foreach (Part part in prod.AssociatedParts)
            {
                addedParts.Add(part);
            }
            var botTable = new BindingSource();
            botTable.DataSource = addedParts;
            modProductGrid2.DataSource = botTable;
        }

        private void CancelModifyProductButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddAssociatedPartButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)modProductGrid1.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }

        private void SaveModifyProductButton_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inventory;
            decimal price;
            int id = int.Parse(modProductIDBox.Text);

            try
            {
                min = int.Parse(modProductMinBox.Text);
                max = int.Parse(modProductMaxBox.Text);
                inventory = int.Parse(modProductInventoryBox.Text);
                price = decimal.Parse(modProductPriceBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }

            string name = modProductNameBox.Text;
            inventory = int.Parse(modProductInventoryBox.Text);
            price = decimal.Parse(modProductPriceBox.Text);
            min = int.Parse(modProductMinBox.Text);
            max = int.Parse(modProductMaxBox.Text);

            if (min > max)
            {
                MessageBox.Show("Error: min cannot be greater than max");
                return;
            }

            if (inventory > max || inventory < min)
            {
                MessageBox.Show("Error: Inventory must be between max and min inventory");
                return;
            }

            Product product = new Product(id, name, inventory, price, max, min);
            Inventory.UpdateProduct(id, product);

            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }

            Close();
            MainWindow.mainFormProductGrid.Update();
            MainWindow.mainFormProductGrid.Refresh();
        }

        private void SearchPartListButton_Click(object sender, EventArgs e)
        {
            string searchText = modProductPartSearchBox.Text.Trim();
            bool found = false;

            foreach (DataGridViewRow row in modProductGrid1.Rows)
            {
                row.Selected = false;
            }

            if (string.IsNullOrEmpty(searchText))
            {
                return;
            }

            if (int.TryParse(searchText, out int partID))
            {
                Part match = Inventory.LookupPart(partID);

                if (match.PartID != 0)
                {
                    foreach (DataGridViewRow row in modProductGrid1.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if (part.PartID == match.PartID)
                        {
                            row.Selected = true;
                            found = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in modProductGrid1.Rows)
                {
                    Part part = (Part)row.DataBoundItem;

                    if (part.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Selected = true;
                        found = true;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show($"No part found matching '{searchText}' by ID or Name.");
            }
        }

        private void DeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Part part = (Part)modProductGrid2.CurrentRow.DataBoundItem;
                int id = int.Parse(modProductIDBox.Text);

                Product product = Inventory.LookupProduct(id);
                product.RemoveAssociatedPart(part.PartID);

                foreach (DataGridViewRow row in modProductGrid2.SelectedRows)
                {
                    modProductGrid2.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}