﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egid_Assesment_Final
{
     class Item
    {

        public string Name { get; set; } 
        public double Price { get; set; }
        public Item(string name, double price)
        {
            Name = name;
            Price = price;

        }

    }
}
