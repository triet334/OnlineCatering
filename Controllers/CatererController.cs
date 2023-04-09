using Pro3_Sem3.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Pro3_Sem3.ServicesIMP;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pro3_Sem3.Controllers
{
    public class CatererController : Controller
    {
        private DatabaseContext db;
        private readonly IWebHostEnvironment hostEnvironment;
        private readonly Services ser;

        public CatererController(DatabaseContext _db, IWebHostEnvironment _hostEnvironment,Services _ser)
        {
            db = _db;
            hostEnvironment = _hostEnvironment;
            ser = _ser;
        }

        public IActionResult GetAllPayment()
        {
            if (HttpContext.Session.GetString("res") == null)
            {
                return RedirectToAction("LoginRes", "Caterer");
            }
            var ID = int.Parse(HttpContext.Session.GetString("res"));
            /*string s = HttpContext.Session.GetString("res");*/
            var result = db.Payments.Where(f => f.Caterid.Equals(ID)).Include(a => a.Cus).Include(b => b.Cater).Include(x => x.Cater.Foods).ToList();          
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> editFood(int? id)
        {
            var edit = await db.Foods.AsNoTracking().FirstOrDefaultAsync(m => m.Foodid == id);
            return View(edit);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> editFood(int id, Food fo)
        {
            var edit = await db.Foods.FirstOrDefaultAsync(m => m.Foodid == id);
            var imagePath = Path.Combine(hostEnvironment.WebRootPath, "images", edit.Foodimage);
            if (fo.PhotoUpload != null)
            {
                if (ModelState.IsValid)
                {
                    //xóa file ảnh
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                    //Save image to wwwroot/images
                    string wwwRootPath = hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(fo.PhotoUpload.FileName);
                    string extension = Path.GetExtension(fo.PhotoUpload.FileName);
                    fo.Foodimage = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    edit.Foodimage = fo.Foodimage;
                    string path = Path.Combine(wwwRootPath + "/images/food/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        fo.PhotoUpload.CopyTo(fileStream);
                    }
                    edit.Foodname = fo.Foodname;
                    edit.Foodstatus = fo.Foodstatus;
                    edit.Fooddescription = fo.Fooddescription;
                    edit.Foodprice = fo.Foodprice;
                    //insert
                    db.Entry(edit).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                }
            }
            else
            {
                edit.Foodname = fo.Foodname;
                edit.Foodstatus = fo.Foodstatus;
                edit.Fooddescription = fo.Fooddescription;
                edit.Foodprice = fo.Foodprice;
                //insert
                db.Entry(edit).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(FoodListOfRestaurant));
        }

        [HttpGet]
        public async Task<IActionResult> editWorker(int? id)
        {
            var edit = await db.Workers.AsNoTracking().FirstOrDefaultAsync(m => m.Workerid == id);
            return View(edit);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> editWorker(int id, Worker wo)
        {
            var edit = await db.Workers.FirstOrDefaultAsync(m => m.Workerid == id);
            edit.Wokername = wo.Wokername;
            edit.Workeraddress = wo.Workeraddress;
            edit.Workerphone = wo.Workerphone;
            edit.Status = wo.Status;
            edit.Workersalary = wo.Workersalary;
            edit.Workertype = wo.Workertype;
            db.Entry(edit).State = EntityState.Modified;
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(WorkerListOfRestaurant));
        }

        public async Task<IActionResult> deleteFood(int id)
        {
            var checkId = await db.Foods.SingleOrDefaultAsync(f => f.Foodid.Equals(id));
            var imagePath = Path.Combine(hostEnvironment.WebRootPath, "images", checkId.Foodimage);
            //xóa file ảnh
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
                db.Foods.Remove(checkId);
                await db.SaveChangesAsync();
                await Task.Delay(3000);
                return RedirectToAction(nameof(FoodListOfRestaurant));
            }
            else
            {
                db.Foods.Remove(checkId);
                await db.SaveChangesAsync();
                await Task.Delay(3000);
                return RedirectToAction(nameof(FoodListOfRestaurant));
            }      
        }

        public async Task<IActionResult> deleteWorker(int id)
        {
            var checkId = await db.Workers.SingleOrDefaultAsync(f => f.Workerid.Equals(id));
            db.Workers.Remove(checkId);
            await db.SaveChangesAsync();
            await Task.Delay(3000);
            return RedirectToAction(nameof(WorkerListOfRestaurant));     
        }

        [HttpGet]
        public IActionResult createFood()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> createFood(Food fo)
        {
            if (ModelState.IsValid)
            {
                var ID = int.Parse(HttpContext.Session.GetString("res"));
                var result = await db.Caterers.SingleOrDefaultAsync(f => f.Caterid.Equals(ID));
                if (result != null)
                {
                    //Save image to wwwroot/images
                    string wwwRootPath = hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(fo.PhotoUpload.FileName);
                    string extension = Path.GetExtension(fo.PhotoUpload.FileName);
                    fo.Foodimage = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/images/food/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        fo.PhotoUpload.CopyTo(fileStream);
                    }
                    Food newFood = new Food()
                    {
                        Caterid = ID,
                        Foodname = fo.Foodname,
                        Foodimage = fo.Foodimage,
                        Foodstatus = fo.Foodstatus,
                        Foodprice = fo.Foodprice,
                        Fooddescription = fo.Fooddescription
                    };
                    //insert
                    await db.Foods.AddAsync(newFood);
                    await db.SaveChangesAsync();
                }
                return RedirectToAction(nameof(FoodListOfRestaurant));
            }
            return RedirectToAction(nameof(FoodListOfRestaurant));
        }


        [HttpGet]
        public IActionResult createWorker()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> createWorker(Worker wo)
        {
            if (ModelState.IsValid)
            {
                var ID = int.Parse(HttpContext.Session.GetString("res"));
                var result = await db.Caterers.SingleOrDefaultAsync(f => f.Caterid.Equals(ID));
                if (result != null)
                {
                    Worker newWorker = new Worker()
                    {
                        Caterid = ID,
                        Wokername = wo.Wokername,
                        Workerphone = wo.Workerphone,
                        Workeraddress = wo.Workeraddress,
                        Status = true,
                        Workersalary = wo.Workersalary,
                        Workertype = wo.Workertype
                    };
                    //insert
                    await db.Workers.AddAsync(newWorker);
                    await db.SaveChangesAsync();
                }
            }
            return RedirectToAction(nameof(WorkerListOfRestaurant));
        }


        [HttpGet]
        public IActionResult FoodListOfRestaurant()
        {
            var ID = int.Parse(HttpContext.Session.GetString("res"));
            var result = db.Foods.Where(f => f.Caterid.Equals(ID)).ToList();
            return View(result);
        }
      
        [HttpGet]
        public IActionResult WorkerListOfRestaurant()
        {
            var ID = int.Parse(HttpContext.Session.GetString("res"));
            var result = db.Workers.Where(f => f.Caterid.Equals(ID)).ToList();
            return View(result);
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult LoginRes()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginRes(string UserName, string pass)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var ResLogin = ser.checkLoginCaterer(UserName, pass);
                    if (ResLogin != null)
                    {
                        HttpContext.Session.SetString("res", ResLogin.Caterid.ToString());
                        HttpContext.Session.SetString("res2", ResLogin.Catername.ToString());
                        return RedirectToAction("Index", "Caterer", ResLogin);
                    }
                    else
                    {
                        return RedirectToAction("LoginRes");
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
            if (HttpContext.Session.GetString("res") == null)
            {
                return RedirectToAction("LoginRes", "Caterer");
            }
            else
            {
                HttpContext.Session.Remove("res");
                return RedirectToAction("LoginRes", "Caterer");
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditCaterer()
        {
            var district = db.Districts.ToList();
            ViewBag.data = new SelectList(district, "DistrictId", "DistrictName");
            var ID = int.Parse(HttpContext.Session.GetString("res"));
            var edit = await db.Caterers.SingleOrDefaultAsync(f => f.Caterid.Equals(ID));
            return View(edit);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCaterer(Caterer cate, int addressDistrict)
        {
            var district = db.Districts.ToList();
            ViewBag.data = new SelectList(district, "DistrictId", "DistrictName");

            var ID = int.Parse(HttpContext.Session.GetString("res"));
            var edit = await db.Caterers.SingleOrDefaultAsync(f => f.Caterid.Equals(ID));

            var imagePath = Path.Combine(hostEnvironment.WebRootPath, "images", edit.Photo);
            if (cate.PhotoUpload != null)
            {
                if (ModelState.IsValid)
                {
                    //xóa file ảnh
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                    //Save image to wwwroot/images
                    string wwwRootPath = hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(cate.PhotoUpload.FileName);
                    string extension = Path.GetExtension(cate.PhotoUpload.FileName);
                    cate.Photo = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    edit.Photo = cate.Photo;
                    string path = Path.Combine(wwwRootPath + "/images/caterer/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        cate.PhotoUpload.CopyTo(fileStream);
                    }
                    edit.Caterpasss = cate.Caterpasss;
                    edit.Caterfullname = cate.Caterfullname;
                    edit.Cateraddress = cate.Cateraddress;
                    edit.Caterphone = cate.Caterphone;
                    edit.Caterstatus = cate.Caterstatus;
                    edit.Cateremail = cate.Cateremail;
                    edit.DistrictId = addressDistrict;
                    edit.MaxPeople = cate.MaxPeople;

                    //insert
                    db.Entry(edit).State = EntityState.Modified;
                    await db.SaveChangesAsync();
                }
            }
            else
            {
                edit.Caterpasss = cate.Caterpasss;
                edit.Caterfullname = cate.Caterfullname;
                edit.Cateraddress = cate.Cateraddress;
                edit.Caterphone = cate.Caterphone;
                edit.Caterstatus = cate.Caterstatus;
                edit.Cateremail = cate.Cateremail;
                edit.DistrictId = addressDistrict;
                edit.MaxPeople = cate.MaxPeople;

                //insert
                db.Entry(edit).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Register()
        {
            var district = db.Districts.ToList();
            ViewBag.data = new SelectList(district, "DistrictId", "DistrictName");
            return View();
        }
        [HttpPost]
        public IActionResult Register(Caterer Newcarter, int addressDistrict)
        {
            var district = db.Districts.ToList();
            ViewBag.data = new SelectList(district, "DistrictId", "DistrictName");

            var models = db.Caterers.SingleOrDefault(n => n.Catername.Equals(Newcarter.Catername));

            if (models != null && models.Caterfullname.Equals(Newcarter.Caterfullname))
            {
                ViewBag.msg = "This username has been register !!!";
                return RedirectToAction("Register", "Caterer");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    //Save image to wwwroot/images
                    string wwwRootPath = hostEnvironment.WebRootPath;
                    string fileName = Path.GetFileNameWithoutExtension(Newcarter.PhotoUpload.FileName);
                    string extension = Path.GetExtension(Newcarter.PhotoUpload.FileName);
                    Newcarter.Photo = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/images/caterer/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        Newcarter.PhotoUpload.CopyTo(fileStream);
                    }
                    Caterer newCat = new Caterer()
                    {
                        Catername = Newcarter.Catername,
                        Caterpasss = Newcarter.Caterpasss,
                        Caterfullname = Newcarter.Caterfullname,
                        Cateraddress = Newcarter.Cateraddress,
                        Caterphone = Newcarter.Caterphone,
                        Photo = Newcarter.Photo,
                        Caterstatus = true,
                        Cateremail = Newcarter.Cateremail,
                        DistrictId = addressDistrict,
                        MaxPeople = Newcarter.MaxPeople
                    };
                    //insert
                    db.Caterers.AddAsync(newCat);
                    db.SaveChanges();
                    ViewBag.msg = "Register Successfull <3";
                    return RedirectToAction("LoginRes", "Caterer");
                }
                return View();
            }

        }

    }
}
