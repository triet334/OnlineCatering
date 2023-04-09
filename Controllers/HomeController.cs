using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pro3_Sem3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pro3_Sem3.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext db;

        public HomeController(DatabaseContext _db)
        {
            db = _db;
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult Index()
        {
            var district = db.Districts.ToList();
            ViewBag.data = new SelectList(district, "DistrictId", "DistrictName");
            var viewHomeT = new List<ViewHome>();
            if (HttpContext.Session.GetString("no") == null)
            {
                var caterern = db.Caterers.Where(a => a.Caterstatus == true).ToList();

                foreach (var item in caterern)
                {
                    var viewHome = new ViewHome();
                    viewHome.wishlist = false;

                    viewHome.CaterersN = item;

                    viewHomeT.Add(viewHome);
                }
            }
            else
            {
                var id = int.Parse(HttpContext.Session.GetString("no"));
                var caterern = db.Caterers.Where(a => a.Caterstatus == true).ToList();
                var wl = db.Wishlists.Where(a => a.Cusid == id).ToList();
                ViewBag.wlcount = wl.Count();


                foreach (var item in caterern)
                {
                    var viewHome = new ViewHome();
                    viewHome.wishlist = false;
                    foreach (var wish in wl)
                    {
                        if (wish.Caterid == item.Caterid)
                        {
                            viewHome.wishlist = true;
                            break;
                        }
                    }
                    viewHome.CaterersN = item;

                    viewHomeT.Add(viewHome);
                }
            }


            return View(viewHomeT);
        }

        [HttpPost]
        public IActionResult Index(string name, int? address, int? people)
        {
            var district = db.Districts.ToList();
            ViewBag.data = new SelectList(district, "DistrictId", "DistrictName");
            var viewHomeT = new List<ViewHome>();

            if (name == null && people == null && address == null)
            {
                if (HttpContext.Session.GetString("no") == null)
                {
                    var caterern = db.Caterers.Where(a => a.Caterstatus == true).ToList();

                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;

                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
                else
                {
                    var id = int.Parse(HttpContext.Session.GetString("no"));
                    var caterern = db.Caterers.Where(a => a.Caterstatus == true).ToList();

                    var wl = db.Wishlists.Where(a => a.Cusid == id).ToList();
                    ViewBag.wlcount = wl.Count();


                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;
                        foreach (var wish in wl)
                        {
                            if (wish.Caterid == item.Caterid)
                            {
                                viewHome.wishlist = true;
                                break;
                            }
                        }
                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
            }

            else if (name != null && people != null && address != null)
            {
                if (HttpContext.Session.GetString("no") == null)
                {
                    var caterern = db.Caterers.Where(a => a.DistrictId.Equals(address) && a.Caterfullname.Contains(name) && a.MaxPeople > people && a.Caterstatus==true).ToList();
                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;

                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
                else
                {
                    var id = int.Parse(HttpContext.Session.GetString("no"));
                    var caterern = db.Caterers.Where(a => a.DistrictId.Equals(address) && a.Caterfullname.Contains(name) && a.MaxPeople > people && a.Caterstatus == true).ToList();


                    var wl = db.Wishlists.Where(a => a.Cusid == id).ToList();
                    ViewBag.wlcount = wl.Count();


                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;
                        foreach (var wish in wl)
                        {
                            if (wish.Caterid == item.Caterid)
                            {
                                viewHome.wishlist = true;
                                break;
                            }
                        }
                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
            }

            else if (name == null && people == null && address != null)
            {
                if (HttpContext.Session.GetString("no") == null)
                {
                    var caterern = db.Caterers.Where(a => a.DistrictId.Equals(address) && a.Caterstatus == true).ToList();
                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;

                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
                else
                {
                    var id = int.Parse(HttpContext.Session.GetString("no"));
                    var caterern = db.Caterers.Where(a => a.DistrictId.Equals(address) && a.Caterstatus == true).ToList();

                    var wl = db.Wishlists.Where(a => a.Cusid == id).ToList();
                    ViewBag.wlcount = wl.Count();


                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;
                        foreach (var wish in wl)
                        {
                            if (wish.Caterid == item.Caterid)
                            {
                                viewHome.wishlist = true;
                                break;
                            }
                        }
                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
            }


            else if (address == null && people == null && name != null)
            {
                if (HttpContext.Session.GetString("no") == null)
                {
                    var caterern = db.Caterers.Where(a => a.Caterfullname.Contains(name) && a.Caterstatus == true).ToList();
                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;

                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
                else
                {
                    var id = int.Parse(HttpContext.Session.GetString("no"));
                    var caterern = db.Caterers.Where(a => a.Caterfullname.Contains(name) && a.Caterstatus == true).ToList();

                    var wl = db.Wishlists.Where(a => a.Cusid == id).ToList();
                    ViewBag.wlcount = wl.Count();


                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;
                        foreach (var wish in wl)
                        {
                            if (wish.Caterid == item.Caterid)
                            {
                                viewHome.wishlist = true;
                                break;
                            }
                        }
                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
            }
            else if (address == null && name == null && people != null)
            {
                if (HttpContext.Session.GetString("no") == null)
                {
                    var caterern = db.Caterers.Where(a => a.MaxPeople >= people && a.Caterstatus == true).ToList();
                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;

                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
                else
                {
                    var id = int.Parse(HttpContext.Session.GetString("no"));
                    var caterern = db.Caterers.Where(a => a.MaxPeople >= people && a.Caterstatus == true).ToList();

                    var wl = db.Wishlists.Where(a => a.Cusid == id).ToList();
                    ViewBag.wlcount = wl.Count();


                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;
                        foreach (var wish in wl)
                        {
                            if (wish.Caterid == item.Caterid)
                            {
                                viewHome.wishlist = true;
                                break;
                            }
                        }
                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
            }
            else if (address == null && name != null && people != null)
            {
                if (HttpContext.Session.GetString("no") == null)
                {
                    var caterern = db.Caterers.Where(a => a.MaxPeople >= people && a.Caterfullname.Contains(name) && a.Caterstatus == true).ToList();
                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;

                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
                else
                {
                    var id = int.Parse(HttpContext.Session.GetString("no"));
                    var caterern = db.Caterers.Where(a => a.MaxPeople >= people && a.Caterfullname.Contains(name) && a.Caterstatus == true).ToList();

                    var wl = db.Wishlists.Where(a => a.Cusid == id).ToList();
                    ViewBag.wlcount = wl.Count();


                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;
                        foreach (var wish in wl)
                        {
                            if (wish.Caterid == item.Caterid)
                            {
                                viewHome.wishlist = true;
                                break;
                            }
                        }
                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
            }

            else if (address != null && name == null && people != null)
            {
                if (HttpContext.Session.GetString("no") == null)
                {
                    var caterern = db.Caterers.Where(a => a.MaxPeople >= people && a.DistrictId.Equals(address) && a.Caterstatus == true).ToList();
                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;

                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
                else
                {
                    var id = int.Parse(HttpContext.Session.GetString("no"));
                    var caterern = db.Caterers.Where(a => a.MaxPeople >= people && a.DistrictId.Equals(address) && a.Caterstatus == true).ToList();

                    var wl = db.Wishlists.Where(a => a.Cusid == id).ToList();
                    ViewBag.wlcount = wl.Count();


                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;
                        foreach (var wish in wl)
                        {
                            if (wish.Caterid == item.Caterid)                     
                            {
                                viewHome.wishlist = true;
                                break;
                            }
                        }
                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
            }

            else if (address != null && name != null && people == null)
            {
                if (HttpContext.Session.GetString("no") == null)
                {
                    var caterern = db.Caterers.Where(a => a.Caterfullname.Contains(name) && a.DistrictId.Equals(address) && a.Caterstatus == true).ToList();
                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;

                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
                else
                {
                    var id = int.Parse(HttpContext.Session.GetString("no"));
                    var caterern = db.Caterers.Where(a => a.Caterfullname.Contains(name) && a.DistrictId.Equals(address) && a.Caterstatus == true).ToList();

                    var wl = db.Wishlists.Where(a => a.Cusid == id).ToList();
                    ViewBag.wlcount = wl.Count();


                    foreach (var item in caterern)
                    {
                        var viewHome = new ViewHome();
                        viewHome.wishlist = false;
                        foreach (var wish in wl)
                        {
                            if (wish.Caterid == item.Caterid)
                            {
                                viewHome.wishlist = true;
                                break;
                            }
                        }
                        viewHome.CaterersN = item;

                        viewHomeT.Add(viewHome);
                    }
                }
            }

            return View(viewHomeT);
        }
        public IActionResult WishList()
        {
            int id = int.Parse(HttpContext.Session.GetString("no"));
            var viewHomeT = new List<ViewHome>();
            var catererL = new List<Caterer>();
            var wishlist = db.Wishlists.Where(a => a.Cusid.Equals(id)).Join(db.Caterers, a => a.Caterid, w => w.Caterid, (w, a) => new { a.Cateraddress, a.Catername, a.Caterid, a.Caterstatus, a.Cateremail, a.Caterpasss, a.Caterphone,a.Caterfullname, a.Photo }).ToList();
            foreach (var item in wishlist)
            {
                var caterer = new Caterer();
                caterer.Cateraddress = item.Cateraddress;
                caterer.Catername = item.Catername;
                caterer.Caterid = item.Caterid;
                caterer.Caterstatus = true;
                caterer.Caterfullname = item.Caterfullname;
                caterer.Caterpasss = item.Caterpasss;
                caterer.Caterphone = item.Caterphone;
                caterer.Photo = item.Photo;
                catererL.Add(caterer);
            }

            foreach (var item in catererL)
            {
                var viewHome = new ViewHome();
                viewHome.wishlist = true;
                viewHome.CaterersN = item;
                viewHomeT.Add(viewHome);
            }
            return View(viewHomeT);
        }

        public IActionResult RemoveWishList(int id)
        {
            int idc = int.Parse(HttpContext.Session.GetString("no"));
            var wl = db.Wishlists.Where(a => a.Caterid == id && a.Cusid == idc).FirstOrDefault();
            db.Wishlists.Remove(wl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult RemoveWishListN(int id)
        {
            int idc = int.Parse(HttpContext.Session.GetString("no"));
            var wl = db.Wishlists.Where(a => a.Caterid == id && a.Cusid == idc).FirstOrDefault();
            db.Wishlists.Remove(wl);
            db.SaveChanges();
            return RedirectToAction("WishList");
        }

        public IActionResult AddWishList(int id)
        {
            var wl = new Wishlist();
            wl.Caterid = id;
            wl.Cusid = int.Parse(HttpContext.Session.GetString("no"));
            db.Wishlists.Add(wl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("no") == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Session.Remove("no");
                HttpContext.Session.Remove("customerName");
                return RedirectToAction("Index");

            }

        }

        public IActionResult DetailsCaterer(int id)
        {
            var caterer = db.Caterers.Find(id);
            var food = db.Foods.Where(a => a.Caterid.Equals(id) && a.Foodstatus== true).ToList();
            var details = new CatererFoods();
            details.CaterersN = caterer;
            details.FoodList = food;
            return View(details);
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
