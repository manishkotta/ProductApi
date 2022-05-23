using ProductApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Services
{
    public class OfferService
    {

        private IEnumerable<Product> _inventory;

        public OfferService()
        {
            this._seedInventory();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return this._inventory;
        }

        public void AddProduct(Product p)
        {
            if (p != null)
                this._inventory.ToList().Add(p);
        }

        public IEnumerable<Offer> GetTodaysOffers()
        {
            var offers = new List<Offer>();
            for (int f = 0; f < 4; f++)
            {

                var products = new List<Product>();
                for (int i = 0; i < 3; i++)
                {
                    var random = new Random();
                    var index = random.Next(this._inventory.Count());
                    products.Add(this._inventory.ElementAt(index));
                }

                offers.Add(new Offer($"ComboPackage{f + 1}", products));
            }

            return offers;
        }
        private void _seedInventory()
        {
            this._inventory = new List<Product>
            {
                new Product("P1", 1000, "P1 Desc"),
                new Product("P2", 1000, "P2 Desc"),
                new Product("P3", 1000, "P3 Desc"),
                new Product("P4", 1000, "P4 Desc"),
                new Product("P5", 1000, "P5 Desc"),
                new Product("P6", 1000, "P6 Desc"),
            };

        }
    }
}
