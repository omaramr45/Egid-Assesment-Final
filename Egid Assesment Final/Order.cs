using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egid_Assesment_Final
{
     class Order
    {

        public List<Item> Items { get; set; } 
        public Order(List<Item> items)
        {
            Items= items;
        }

        public Order()
        {
        }

        public void AddItem(Item item)
        {

            Items.Add(item);
        }
        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }
    }
}
