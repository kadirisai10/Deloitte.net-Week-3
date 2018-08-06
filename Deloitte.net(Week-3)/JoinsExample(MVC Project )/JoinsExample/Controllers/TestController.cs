using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JoinsExample.Models;
namespace JoinsExample.Controllers
{
    public class TestController : Controller
    {
        TrainingDBEntities2 db = new TrainingDBEntities2();
        // GET: Test
        public ActionResult ShowProduct()
        {
            var data = new SelectList(db.Products, "prodid", "pname");
            Session["pdata"] = data;
            return View();
        }
        [HttpPost]

        public ActionResult ShowProduct(string Command)
        {
            if (Command == "ShowModel")
            {

             int  id = int.Parse(Request.Form["ddlprod"].ToString());
                var join = (from p in db.Products
                            join m in db.Models
                            on p.prodid equals m.prodid
                            where m.prodid == id
                            select m).ToList();                
                Session["mdata"] = new SelectList(join, "modelid", "modelname");
             
                return View();
            }
            if (Command == "Confirm")
            {
                Order ord = new Order();
                ord.modelid = int.Parse(Request.Form["ddlmodel"].ToString());
                ord.Productid = int.Parse(Request.Form["ddlprod"].ToString());
                ord.orderdate = DateTime.Now;

                ord.Qty = int.Parse(Request.Form["txtquantity"].ToString());
                ord.address = Request.Form["txtaddress"].ToString();
                //ord.pname = Request.Form["ddlprod"].ToString();
                // ord.mname = Request.Form["ddlmodel"].ToString();
                db.Orders.Add(ord);
                var r = db.SaveChanges();
                if (r > 0)
                {
                    ModelState.AddModelError("", "Order Confirmed");
                    Session["oid"] = ord.OrderId;
                }
                return RedirectToAction("OrderSummary");
               // return View();
            }
            return View();
            
        }


        [HttpGet]

        public ActionResult TrackOrder()
        {
          
            return View();
           
        }

        [HttpPost]
        public ActionResult TrackOrder(string Command)
        {
            int orderid = int.Parse(Request.Form["txtorderid"].ToString());
            var data = db.Orders.Where(x => x.OrderId == orderid).SingleOrDefault();
            ViewData["userdata"] = data;
            int pid = data.modelid;
            int qty = data.Qty;
            var result = db.Models.Where(x => x.modelid == pid).SingleOrDefault();
            float price = (float)result.price;
            float amt = price * qty;
            Session["amount"] = amt;
            var mname = data.Model.modelname;
            Session["modelname"] = mname;
            var dt = DateTime.Parse(data.orderdate.Date.ToString());
            var del = dt.AddDays(5);
            Session["delivery"] = del;
            var dt1 = dt.AddDays(1);
            var dt2 = dt.AddDays(2);
            var dt3 = dt.AddDays(3);
            var dt4 = dt.AddDays(4);
            var dt5 = dt.AddDays(5);
            if (DateTime.Now.Year == dt.Year && DateTime.Now.Month == dt.Month)
            {
                if(dt==DateTime.Now.Date)
                {
                    var status = "Packing";
                    Session["stat"] = status;

                }
                else if (dt1 == DateTime.Now.Date)
                {
                    var status = "Dispatched";
                    Session["stat"] = status;
                  
                }

               else if (dt2 == DateTime.Now.Date)
                {
                    var status = "Shipped";
                    Session["stat"] = status;
                  
                }
                else if (dt3 == DateTime.Now.Date)
                {
                    var status = "Shipped";
                    Session["stat"] = status;
                   
                }
                else if (dt4 == DateTime.Now.Date)
                {
                    var status = "Shipped";
                    Session["stat"] = status;
                   
                }
                else if (dt5 == DateTime.Now.Date)
                {
                    var status = "On the Way";
                    Session["stat"] = status;
                  
                }

                

            }
            return View();
        }
        [HttpGet]
        public ActionResult OrderSummary()
        {
            int id = int.Parse(Session["oid"].ToString());
            var data = db.Orders.Where(x => x.OrderId == id).SingleOrDefault();
            ViewData["userdata"] = data;
            int mid = data.modelid;
            int qty = data.Qty;
            Session["qty"] = qty;
            var result = db.Models.Where(x => x.modelid == mid).SingleOrDefault();
            float price = (float)result.price;
            Session["price"] = price;
            float amt1 = price * qty;
            Session["amount1"] = amt1;
            var mname1 = data.Model.modelname;
            Session["modelname1"] = mname1;
            var dt = DateTime.Parse(data.orderdate.Date.ToString());
            var del1 = dt.AddDays(5);
            Session["delivery1"] = del1;

            return View();
        }
        }
    }
