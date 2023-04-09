using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using Pro3_Sem3.Models;
using Microsoft.AspNetCore.Http;

using Pro3_Sem3.ServicesIMP;
using Microsoft.EntityFrameworkCore;

namespace Pro3_Sem3.Controllers
{
    public class UserController : Controller
    {
        private readonly DatabaseContext db;
        private readonly Services ser;
       
        public UserController(DatabaseContext _db, Services _ser)
        {
            db = _db;
            ser = _ser;
        }

        public IActionResult Index()
        { 
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string UserName, string pass)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    var UserLogin = ser.checkLogin(UserName, pass);
                    if(UserLogin != null)
                    {
                        HttpContext.Session.SetString("no", UserLogin.Cusid.ToString());
                        HttpContext.Session.SetString("customerName", UserLogin.Cusfullname.ToString());
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Login","User");
                    }
                    
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Fail!!!");
                }
            }
            catch (Exception ex)
            {

                //ViewBag.msg = ex.Message;
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("no") == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                HttpContext.Session.Remove("no");
                HttpContext.Session.Remove("customerName");
                return RedirectToAction("Login");
            }

        }

        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Register(Customer Newcus)
        {
            var models = db.Customers.SingleOrDefault(n => n.Username.Equals(Newcus.Username));
            if (models != null && models.Cusemail.Equals(Newcus.Cusemail))
            {
                ViewBag.msg = "This email has been register!!";
                return RedirectToAction("Register");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    db.Customers.Add(Newcus);
                    db.SaveChanges();
                    ViewBag.msg = "Register Successfull!! Please Login.";
                    return RedirectToAction("Login");
                }
                return View();
            }

        }
        [HttpGet]
        public IActionResult Details()
        {
            var UserID = int.Parse(HttpContext.Session.GetString("no")) ;
            var detail = db.Customers.Where(c => c.Cusid.Equals(UserID)).SingleOrDefault();
            if (detail != null)
            {
                return View(detail);
            }
            else
            {
                return View("Login");
            }
        }
        [HttpGet]
        public IActionResult EditInfomation(int? id)
        {
            var edit = db.Customers.Find(id);

            // if (edit == null) return NotFound();
            return View(edit);
        }
        [HttpPost]
        public IActionResult EditInfomation(Customer EditCus)
        {
            try
            {
                var edit = db.Customers.SingleOrDefault(e => e.Cusid.Equals(EditCus.Cusid));
                if (edit != null && ModelState.IsValid)
                {
                    edit.Cusaddress = EditCus.Cusaddress;
                    edit.Userpass = EditCus.Userpass;
                    edit.Cusphone = EditCus.Cusphone;
                    edit.Cusemail = EditCus.Cusemail;
                    db.Customers.Update(edit);
                    db.SaveChanges();
                    return View("Login");
                }
                else
                {
                    ViewBag.msg = "Update fail !!";
                }

            }
            catch (Exception e)
            {
                ViewBag.ms = e.Message;
            }
            return View("EditInfomation");
        }

        public IActionResult DeletePayment(int paid) 
        {
            var delete = db.PaymentDetails.Where(x=> x.Paymentid == paid).ToList();
            
            db.PaymentDetails.RemoveRange(delete);
            db.SaveChanges();
            var dele = db.Payments.Where(x => x.Paymentid == paid).SingleOrDefault();
            db.Payments.Remove(dele);
            db.SaveChanges();
            return RedirectToAction(nameof(GetAllPayment));
        }

        public IActionResult GetAllPayment()
        {
            if (HttpContext.Session.GetString("no") == null)
            {
                return RedirectToAction("Login");
            }
            var s = int.Parse(HttpContext.Session.GetString("no")) ;
            var result = db.Payments.Where(x=> x.Cusid==s).ToList();
            return View(result);

        }

        public IActionResult GetPaymentDetails(int paid)
        {
            var findInDetails = db.PaymentDetails.Where(x => x.Paymentid == paid).ToList();
            List<Food> getFood = new List<Food>();
            foreach (var item in findInDetails)
            {
                ViewBag.quan = item.Quantity;
                var food = db.Foods.Where(f => f.Foodid == item.Foodid).SingleOrDefault();
                getFood.Add(food);
            }
            return View("GetPaymentDetails", getFood);
        }









    }
}

