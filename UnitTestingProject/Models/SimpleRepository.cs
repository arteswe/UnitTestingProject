using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace UnitTestingProject.Models
{
    public class SimpleRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        public static SimpleRepository ShaRepository => sharedRepository;
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public SimpleRepository()
        {
            var initalItem = new[]
            {
                new Product {Name = "kayak", Price = 275M},
                new Product {Name = "lifejacket", Price = 300M},
                new Product {Name = "flag", Price = 285M},
                new Product {Name = "doggijacket", Price = 300M},
                new Product {Name = "bikini", Price = 275M},
                new Product {Name = "siming", Price = 300M}
            };
            foreach (Product p in initalItem)
            {
                AddProduct(p);
            }
        }

        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p);
    }
}
