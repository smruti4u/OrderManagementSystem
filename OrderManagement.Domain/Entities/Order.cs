using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Domain.Entities
{
    public class Order : BaseEntity
    {
        public float Price { get; set; }
        public string Name { get; set; }
        public Resturant resturant { get; set; }
    }
}
