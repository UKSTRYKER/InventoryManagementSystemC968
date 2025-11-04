using System;
using System.Collections;
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
    public partial class addProduct : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();
        public addProduct()
        {
            InitializeComponent();

            var topTable = new BindingSource();
            topTable.DataSource = Inventory.Parts;
            addProductGrid1.DataSource = topTable;

            var botTable = new BindingSource();
            botTable.DataSource = addedParts;
            addProductGrid2.DataSource = botTable;
        }

        private void CancelAddProductbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in addProductGrid2.SelectedRows)
                {
                    addProductGrid2.Rows.RemoveAt(row.Index);
                }
            }
            else return;

        }

        private void SearchPartListButton_Click(object sender, EventArgs e)
        {
            string searchText = addProductSearchBox.Text.Trim();
            bool found = false;

            foreach (DataGridViewRow row in addProductGrid1.Rows)
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
                    foreach (DataGridViewRow row in addProductGrid1.Rows)
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
                foreach (DataGridViewRow row in addProductGrid1.Rows)
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

        private void AddAssociatedPartButton_Click(object sender, EventArgs e)
        {
            Part part = (Part)addProductGrid1.CurrentRow.DataBoundItem;
            addedParts.Add(part);
        }

        private void SaveAddProductButton_Click(object sender, EventArgs e)
        {
            int min;
            int max;
            int inventory;
            decimal price;

            try
            {
                min = int.Parse(addProductMinTextBox.Text);
                max = int.Parse(addProductMaxTextBox.Text);
                inventory = int.Parse(addProductInventoryTextBox.Text);
                price = decimal.Parse(addProductPriceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max and Min text fields must be numeric values.");
                return;
            }

            string name = addProductNameTextBox.Text;
            inventory = int.Parse(addProductInventoryTextBox.Text);
            price = decimal.Parse(addProductPriceTextBox.Text);
            min = int.Parse(addProductMinTextBox.Text);
            max = int.Parse(addProductMaxTextBox.Text);

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
            Product product = new Product((Inventory.Products.Count + 1), name, inventory, price, max, min);
            Inventory.AddProduct(product);

            foreach (Part part in addedParts)
            {
                product.AddAssociatedPart(part);
            }
            Close();
        }

        private void addProductLabelGrid1_Click(object sender, EventArgs e)
        {

        }

        private void addProductMinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProductLabelPrice_Click(object sender, EventArgs e)
        {

        }
    }
}