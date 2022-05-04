using Customer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Customer.DAL;


namespace Customer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CustomerDAL custDAL = new CustomerDAL();
            List<Customers> CustomerList = new List<Customers>();
            CustomerList = custDAL.GetAllCustomers();
            return View(CustomerList);
        }
        [Route("Home/Insert")]
        public IActionResult Insert()
        {

            return View();
        }
        public IActionResult NewCustomer(Customers cust)
        {

            CustomerDAL cobj = new CustomerDAL();
            int result = cobj.NewCustomer(cust);
            if (result == 1)
                return RedirectToAction("Index");
            else
                return View("Insert");
        }
        [Route("Home/Update")]
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Upd(Customers c)
        {
            CustomerDAL cobj = new CustomerDAL();
            int result = cobj.UpdCustomer(c);
            if (result == 1)
            {
                return RedirectToAction("Index");
            }
            else return RedirectToAction("Update");
        }
        [Route("Home/Delete")]
        public IActionResult Delete()
        {
            return View();
        }
        
        public IActionResult Del(Customers c)
        {
            CustomerDAL cobj = new CustomerDAL();
            int result = cobj.DelCustomer(c);
            if (result == 1)
            {
                return RedirectToAction("Index");
            }
            else return RedirectToAction("Delete");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
