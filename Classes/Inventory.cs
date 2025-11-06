using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        // Methods for products
        public static void AddProduct(Product prod)
        {
            Products.Add(prod);
        }

        public static bool RemoveProduct(int prodID)
        {
            bool success = false;
            Product prodToRemove = null;

            foreach (Product prod in Products)
            {
                if (prodID == prod.ProductID)
                {
                    prodToRemove = prod;
                    success = true;
                    break; 
                }
            }

            if (success)
            {
                Products.Remove(prodToRemove);
                return true;
            }
            else
            {
                MessageBox.Show("ERROR: Removal failed.");
                return false;
            }
        }

        public static Product LookupProduct(int prodID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    return prod;
                }
            }
            Product emptyProduct = new Product();
            return emptyProduct;
        }

        public static void UpdateProduct(int prodID, Product product)
        {
            int index = -1;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == prodID)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Products[index] = product;
            }
        }

        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        public static bool DeletePart(int part)
        {
            Part partToDelete = LookupPart(part);
            if (partToDelete == null)
            {
                return false;
            }
            else
            {
                Parts.Remove(partToDelete);
                return true;
            }
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Part emptyPart = new InHouse();
            return emptyPart;
        }

        public static void UpdatePart(int partID, Part part)
        {
            int index = -1;
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].PartID == partID)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Parts[index] = part;
            }
        }

        public static void ExampleItems()
        {
            Product Computer = new Product(1, "Computer", 5, 400.0m, 10, 5);
            Product Router = new Product(2, "Router", 20, 55.0m, 25, 10);
            Part Motherboard = new InHouse(1, "Motherboard", 10, 5.0m, 500, 50, 1001);
            Part WiFi_Card = new Outsourced(2, "WiFi-Card", 15, 10.0m, 250, 50, "ASUS");

            Products.Add(Computer);
            Products.Add(Router);
            Parts.Add(Motherboard);
            Parts.Add(WiFi_Card);
        }
    }
}