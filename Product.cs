using System;

namespace Product_Inventory_Project
{
    class Product
    {
        private int quantity;
        public Product(double price, int id, int quantity, string name)
        {
            this.price = price;
            this.id = id;
            this.quantity = quantity;
            this.name = name;
            Inventory.inventory.Add(name , quantity);
        }
        public string name
        {
            get;
            set;
        }
        public double price
        {
            get;
            set;
        }
        public int id
        {
            get;
            private set;
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                Inventory.inventory[name] = value;
            }
        }

    }
}
//Product Inventory Project - Create an application which manages an inventory of products. Create a product class which has a price, id, and quantity on hand. Then create an inventory class which keeps track of various products and can sum up the inventory value.

