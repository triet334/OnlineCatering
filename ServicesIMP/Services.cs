using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pro3_Sem3.Models;

namespace Pro3_Sem3.ServicesIMP
{
    public class Services
    {
        private readonly DatabaseContext db;
        public Services(DatabaseContext _db)
        {
            db = _db;
        }

        
        public Customer checkLogin(string name,string pass)
        {
            var resurl = db.Customers.SingleOrDefault(x => x.Username == name);
            if (resurl != null)
            {
                if(resurl.Userpass == pass)
                {
                    return resurl;
                }
                return null;
            }
            return null;
        }
        public Caterer checkLoginCaterer(string name, string pass)
        {
            var resurl = db.Caterers.SingleOrDefault(x => x.Catername == name);
            if (resurl != null)
            {
                if (resurl.Caterpasss == pass)
                {
                    return resurl;
                }
                return null;
            }
            return null;
        }

        public void ThemItemgiohang(int food_id)
        {
            List<PaymentDetail> paymentDetails = new List<PaymentDetail>();
           // var proID = db.Foods.SingleOrDefault(p => p.Foodid.Equals(food_id));
            var addproduct = paymentDetails.SingleOrDefault(x => x.Foodid.Equals(food_id));
            if (addproduct != null)
            {
                addproduct.Quantity++;
                
            }
            PaymentDetail newpay = new PaymentDetail()
            {
                Foodid = addproduct.Foodid,
                Quantity = 1,
                Total = addproduct.Food.Foodprice,
            };
                db.PaymentDetails.Add(newpay);
                db.SaveChanges();
            
        }

        public void DeleteItem(int food_id)
        {
            var deleteItem = db.PaymentDetails.Find(food_id);
            db.PaymentDetails.Remove(deleteItem);
            db.SaveChanges();
        }

        public void UpdateQuantity(int food_id, int soluongmoi)
        {
            List<PaymentDetail> cartlist = new List<PaymentDetail>();
            var foodfind = cartlist.SingleOrDefault(x => x.Foodid.Equals(food_id));
            foodfind.Quantity = soluongmoi;
           // foodfind.Total = foodfind.Food.Foodprice * soluongmoi;
            db.PaymentDetails.Update(foodfind);
            db.SaveChanges();
        }

        public List<Payment> Laygiohang(int id) // theo user khi đăng nhập
        {
            
            List<Payment> Usercart = new List<Payment>();
            var resurl = Usercart.Find(x=> x.Cusid == id);
            if (resurl == null)
            {
                return null;
            }
            Usercart.Add(resurl);
            return Usercart;
        }

        public Caterer GetRes(int resid)
        {
            return db.Caterers.SingleOrDefault(x => x.Caterid==resid);
        }
        
    }
}
