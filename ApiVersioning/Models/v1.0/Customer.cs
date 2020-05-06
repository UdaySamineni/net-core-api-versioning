﻿using System.Collections.Generic;

namespace Models.v1._0
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public List<Order> Orders { get; set; }
    }
}