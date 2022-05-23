using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Models
{
    public class Product
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public Product(string pName,decimal price,string desc)
        {
            this.ProductName = pName;
            this.Price = price;
            this.Description = desc;
        }

    }
}
