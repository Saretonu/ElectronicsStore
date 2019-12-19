using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicsStore.Models
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }

        public double Sum { get; set; }

        public DateTime DateCreated { get; set; }

        public double PaidSum { get; private set; }

        public bool Paid { get
            {
                if (PaidSum >= Sum && Sum > 0)
                    return true;
                return false;
            } private set { }
        }

        public virtual ICollection<SCItem> SCItems { get; set; }

        public ShoppingCart()
        {
            Id = Guid.NewGuid();
            Sum = 0;
            DateCreated = DateTime.Now;
            SCItems = new List<SCItem>();
        }

        public void AddToCart(Item item)
        {
            SCItem scItem = SCItems.FirstOrDefault(x => x.Item_id == item.Id);
            if (scItem == null)
                SCItems.Add(new SCItem(item));
            else
                scItem.Quantity++;
            Sum += item.Price;
            Sum = Math.Round(Sum, 2);

        }

        public void RemoveFromCart(SCItem sCItem)
        {
            SCItems.Remove(sCItem);
            Sum -= sCItem.Price * sCItem.Quantity;
            Sum = Math.Round(Sum, 2);
        }

        public void Pay()
        {
            PaidSum = Sum;
        }
    }
}