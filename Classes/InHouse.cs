using System;

namespace Inventory_Management_System
{
    public class InHouse : Part
    {
        public int MachineID { get; set; }

        public InHouse() { }

        // Chains to the 7-parameter constructor with a default MachineID of 0
        public InHouse(int partID, string name, int inventory, decimal price, int max, int min)
            : this(partID, name, inventory, price, max, min, 0) { }

        public InHouse(int partID, string name, int inventory, decimal price, int max, int min, int machID)
        {
            PartID = partID;
            Name = name;
            Inventory = inventory;
            Price = price.ToString();
            Max = max;
            Min = min;
            MachineID = machID;
        }
    }
}