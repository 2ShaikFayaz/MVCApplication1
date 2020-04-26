using MVCApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication1.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Page1()
        {
            return View();
        }
        public ActionResult Page2()
        {
            return View();
        }
        public ActionResult Page3()
        {
            //auto implemented object
            customer cust = new customer() { id = 1, Name = "Shaik", email = "2shaik.fayaz@gmail.com" };

            ViewBag.CurrentCustomer = cust;
            return View();
        }
        public ActionResult Page4()
        {
            customer cust=new customer() { id = 1, Name = "Shaik", email = "2shaik.fayaz@gmail.com" };

            return View();
        }
        public ActionResult Page5()
        {
            customer1 cust1 = new customer1() { CustomerID = 1, CustomerName = "Shaik", Email = "2shaik.fayaz@gmail.com" };
            supplier supp1 = new supplier() { SupplierID = 1, SupplierName = "Binladen", OrderID = 6363 };
            CustomerAndSupplierViewModel cs1 = new CustomerAndSupplierViewModel { cust = cust1, supp = supp1 };
            return View(cs1);
        }
        public ActionResult Page6()
        {
            ViewData["Message2"] = "Message2 from HelloWorld Controller";

            TempData["Message3"] = "Message3 from HelloWorld Controller";

            return RedirectToAction("Page5");
            
        }
        public ActionResult Page7()
        {
            return View();
        }
        public ActionResult Page8()
        {
            return View();
        }
        //adding view using create
        public ActionResult Page9()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Page9(UserLogin model)
        
        {
            if (model.Username == "admin" && model.Password == "123")
                return RedirectToAction("success");
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password";
            return View(model);
            }
        }
        public ActionResult success()
        {
            return View();
        }

    }

}