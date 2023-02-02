using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egid_Assesment_Final
{
     class OrderSystem
    {

        List<Item> items = new List<Item>
        {

            new Item("Item 1", 10),
            new Item("Item 2", 20),
            new Item ("Item 3 ", 30)

        };  

        public List<Order> orders = new List<Order>();

        public void CreateOrder(List<Item> orderItems)
        {
            Order order = new Order();
            foreach (var item in orderItems)
            {
                order.AddItem(item);
            }
            orders.Add(order);
        }

        public void DeleteOrder(Order order)
        {
            orders.Remove(order);
        }


    }
}
