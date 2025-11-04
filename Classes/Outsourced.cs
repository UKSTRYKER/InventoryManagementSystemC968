using System;

namespace Inventory_Management_System
{
    public class Outsourced : Part
    {
        public string CompName { get; set; }

        public Outsourced() { }

        // Chains to the 7-parameter constructor with a default CompName of string.Empty
        public Outsourced(int partID, string name, int inventory, decimal price, int max, int min)
            : this(partID, name, inventory, price, max, min, string.Empty) { }

        public Outsourced(int partID, string name, int inventory, decimal price, int max, int min, string compName)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            CompName = compName;
        }
    }
}