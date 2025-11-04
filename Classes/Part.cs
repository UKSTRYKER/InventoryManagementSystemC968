using System;

namespace Inventory_Management_System
{
    public abstract class Part
    {
        // Only the 'price' field is needed as a backing store due to custom get/set logic.
        private decimal price;

        public int PartID { get; set; }
        public string Name { get; set; }
        public int Inventory { get; set; }
        public string Price
        {
            get { return price.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    price = decimal.Parse(value.Substring(1));
                }
                else
                {
                    price = decimal.Parse(value);
                }
            }
        }
        public int Max { get; set; }
        public int Min { get; set; }
    }
}