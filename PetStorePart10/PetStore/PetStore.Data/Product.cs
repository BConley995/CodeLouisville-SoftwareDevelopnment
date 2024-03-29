﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Data
{
    public class Product
    {
        public decimal Price { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
        public int ProductId { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

    }
}
