using System;
using System.Collections.Generic;

namespace CompanyDomain.Entities
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Nullable<decimal> UnitePrice { get; set; }
        public virtual Category Category { get; set; }
    }
}
