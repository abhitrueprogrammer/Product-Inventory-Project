using System;
using System.Collections.Generic;

namespace Product_Inventory_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var carrot = new Product(price: 33, id : 1, quantity: 22, name: "carrot");
            carrot.Quantity += 1;
            

            var parrot = new Product(price: 33, id : 1, quantity: 88, name: "parrot");
            parrot.Quantity = 1;
            carrot.Quantity -= 229;
            
            foreach (KeyValuePair<string,int> productInv in Inventory.inventory)
            {
                Console.WriteLine(productInv);
            }
            Console.WriteLine(Inventory.TotalQuantity());
            Console.ReadLine();

        }
        
    }
}
