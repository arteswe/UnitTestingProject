using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UnitTestingProject.Models;

namespace UnitTestingProject.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository = SimpleRepository.Repository;

        public IActionResult Index()
            => View(SimpleRepository.Repository.Products);

        [HttpGet]
        public IActionResult AddProduct() => View(new Product());

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            Repository.AddProduct(p);
            return Redirect("Index");
        }
    }
}