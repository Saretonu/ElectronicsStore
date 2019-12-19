using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicsStore.Models
{
    public class Item
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public Category Category { get; set; }

        public String Manufacturer { get; set; }

        public double Price { get; set; }


        public Item()
        {
            Id = Guid.NewGuid();

        }
        public Item(string name, Category category, string manufacturer, double price)
        { 
            Id = Guid.NewGuid();
            Name = name;
            Category = category;
            Manufacturer = manufacturer;
            Price = price;
        }
        public Item(Guid id, string name, Category category, string manufacturer, double price)
        {
            Id = id;
            Name = name;
            Category = category;
            Manufacturer = manufacturer;
            Price = price;
        }
        public Item(Item item)
        {
            Id = item.Id;
            Name = item.Name;
            Category = item.Category;
            Manufacturer = item.Manufacturer;
            Price = item.Price;
        }
    }

    public enum Category
    {
        TVs,
        Computers,
        Phones,
        HomeAppliances
    }
}