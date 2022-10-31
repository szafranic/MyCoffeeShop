using System;
using System.Collections.Generic;

namespace MyCoffeeShop.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? Product1 { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? Category { get; set; }
    }
}
