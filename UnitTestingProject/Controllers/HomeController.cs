﻿using Microsoft.AspNetCore.Mvc;
using UnitTestingProject.Models;

namespace UnitTestingProject.Controllers
{
    public class HomeController : Controller
    {
        SimpleRepository Repository = SimpleRepository.ShaRepository;

        public IActionResult Index()
            => View(SimpleRepository.ShaRepository.Products);

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