using System;
using System.Collections.Generic;

namespace InventorySystem.Models
{
    public class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

    }
}      