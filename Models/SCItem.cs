using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicsStore.Models
{
    public class SCItem
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public Category Category { get; set; }

        public String Manufacturer { get; set; }

        public double Price { get; set; }
        public int Quantity { get; set; }
        public Guid Item_id { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

        public SCItem()
        {
            Id = Guid.NewGuid();
        }
        public SCItem(Item item)
        {
            Id = Guid.NewGuid();
            Item_id = item.Id;
            Name = item.Name;
            Category = item.Category;
            Manufacturer = item.Manufacturer;
            Price = item.Price;
            Quantity = 1;
        }
    }
}