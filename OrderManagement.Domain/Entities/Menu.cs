using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Domain.Entities
{

    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public Resturant resturant { get; set; }
    }
}
