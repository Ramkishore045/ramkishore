using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Product.Models;

namespace Product.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("Products")]
        public IActionResult Create(Products pro)
        {
            if (ModelState.IsValid)
            {
                ProductDBContext DbContext = new ProductDBContext();
                DbContext.Add(pro);
                DbContext.SaveChanges();
                return Content("Product has been Added");
            }
            return View("Index");
        }
    }
}
