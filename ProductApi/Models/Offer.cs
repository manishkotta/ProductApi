using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Models
{
    public class Offer
    {
        public string OfferName { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public Offer(string offerName, IEnumerable<Product> products)
        {
            this.OfferName = offerName;
            this.Products = products;
        }
    }
}
