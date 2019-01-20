using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UnitTestingProject.Controllers;
using UnitTestingProject.Models;
using Xunit;

namespace XUnitTestProject
{
    public class HomeControllerTest
    {
        class FakeRepository : IRepository
        {
            public IEnumerable<Product> Products { get; } = new Product[]{
                new Product{Name = "P1", Price = 23M},
                new Product {Name = "P2", Price = 24M},
                new Product{Name = "P3", Price = 23M}
            };

            public void AddProduct(Product p)
            {
                throw new System.NotImplementedException();
            }
        }

        [Fact]
        public void IndexActionModelIsComplete()
        {
            var controller = new HomeController();
            controller.Repository = new FakeRepository();
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;
            Assert.Equal(controller.Repository.Products, model, Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name && p1.Price == p2.Price));
        }
    }

    
}
