using System.Collections.Generic;

namespace Product_Inventory_Project
{
    class Inventory
    {
        static public Dictionary<string, int> inventory = new Dictionary<string, int>();
        static public int TotalQuantity()
        {
            var TotalQuantity = 0;
            foreach (KeyValuePair<string, int> item in inventory)
            {
                TotalQuantity += item.Value;
            }
            return TotalQuantity;
            
        }
    }
}