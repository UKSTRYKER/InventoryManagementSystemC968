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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            Inventory.ExampleItems();

            var partTable = new BindingSource();
            partTable.DataSource = Inventory.Parts;
            mainFormPartGrid.DataSource = partTable;

            var prodTable = new BindingSource();
            prodTable.DataSource = Inventory.Products;
            mainFormProductGrid.DataSource = prodTable;
        }


        private void AddPartButton_Click(object sender, EventArgs e)
        {
            new addPart().ShowDialog();
        }


        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            if (mainFormPartGrid.CurrentRow.DataBoundItem.GetType() == typeof(Inventory_Management_System.InHouse))
            {
                InHouse inHousePart = (InHouse)mainFormPartGrid.CurrentRow.DataBoundItem;
                new modPart(inHousePart).ShowDialog();
            }
            else
            {
                Outsourced outsourcedPart = (Outsourced)mainFormPartGrid.CurrentRow.DataBoundItem;
                new modPart(outsourcedPart).ShowDialog();
            }
        }
        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in mainFormPartGrid.SelectedRows)
                {
                    mainFormPartGrid.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }

        private void SearchPartButton_Click(object sender, EventArgs e)
        {
            string searchText = mainFormPartSeachBox.Text.Trim();
            bool found = false;

            foreach (DataGridViewRow row in mainFormPartGrid.Rows)
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
                    foreach (DataGridViewRow row in mainFormPartGrid.Rows)
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
                foreach (DataGridViewRow row in mainFormPartGrid.Rows)
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
        private void AddProductButton_Click(object sender, EventArgs e)
        {

            new addProduct().ShowDialog();
        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            Product selectedProd = (Product)mainFormProductGrid.CurrentRow.DataBoundItem;
            new modProduct(selectedProd).ShowDialog();
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? This cannot be undone.", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Product product = (Product)mainFormProductGrid.CurrentRow.DataBoundItem;
                if (product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete product with associated parts. Please remove parts attached to this product.");
                    return;
                }
                foreach (DataGridViewRow row in mainFormProductGrid.SelectedRows)
                {
                    mainFormProductGrid.Rows.RemoveAt(row.Index);
                }
            }
            else return;
        }
        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            string searchText = mainFormProductSeachBox.Text.Trim();
            bool found = false;

            foreach (DataGridViewRow row in mainFormProductGrid.Rows)
            {
                row.Selected = false;
            }

            if (string.IsNullOrEmpty(searchText))
            {
                return;
            }

            if (int.TryParse(searchText, out int productID))
            {
                Product match = Inventory.LookupProduct(productID);

                if (match.ProductID != 0)
                {
                    foreach (DataGridViewRow row in mainFormProductGrid.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;
                        if (product.ProductID == match.ProductID)
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
                foreach (DataGridViewRow row in mainFormProductGrid.Rows)
                {
                    Product product = (Product)row.DataBoundItem;

                    if (product.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        row.Selected = true;
                        found = true;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show($"No product found matching '{searchText}' by ID or Name.");
            }
        }
        private void ExitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}