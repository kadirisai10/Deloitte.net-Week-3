using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers
{
    public class ResgisterShoppingCRUDController : Controller
    {
        TrainingDBEntities db = new TrainingDBEntities();
        // GET: ResgisterShoppingCRUD
        [HttpGet]
        public ActionResult InsertResgisterShopping()
        {
            return View();
        }
        [HttpPost]

        public ActionResult InsertResgisterShopping(ResgisterShopping rs)
        {
            rs.Name = Request.Form["txtname"].ToString();
            rs.Gender = Request.Form["gender"].ToString();
            rs.Membership = Request.Form["ddlmember"].ToString();
            rs.ShoppingPreference = Request.Form["shop"].ToString();
            var res =  Request.Form["cbcod"].ToString();
            if (res=="False")
                rs.COD = "No";
            else
                rs.COD = "Yes";
            rs.Password = Request.Form["txtpass"].ToString();
            db.ResgisterShoppings.Add(rs);
            var r = db.SaveChanges();
            if (r > 0)
                ModelState.AddModelError("", "Data Inserted");
            return View();

        }

        //default http get

        public ActionResult SelectAllResgisterShopping()
        {
            var data = db.ResgisterShoppings.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult SelectById()
        {
            var data = new SelectList(db.ResgisterShoppings, "Id", "Name");
            Session["rsdata"] = data;
            return View();
        }

        [HttpPost]
        public ActionResult SelectById(string Command)
        {
           int id = int.Parse(Request.Form["ddlid"].ToString());
            if (Command =="SelectById")
            {
                var data = db.ResgisterShoppings.Where(x => x.Id == id).SingleOrDefault();
                ViewData["userdata"] = data;
                return View();
            }
            if(Command=="Update")
            {
                int oldid = int.Parse(Request.Form["txtid"].ToString());
                var olddata = db.ResgisterShoppings.Where(x => x.Id == oldid).SingleOrDefault();
                olddata.Membership = Request.Form["txtmem"].ToString();
                olddata.ShoppingPreference = Request.Form["txtshop"].ToString();
                olddata.COD = Request.Form["txtcod"].ToString();
                olddata.Password = Request.Form["txtpass"].ToString();
            
                var res = db.SaveChanges();
                if (res > 0)
                    ModelState.AddModelError("", "Data Updated");
                return View();
            }
             


            if(Command=="Delete")
            {
                int oldid = int.Parse(Request.Form["txtid"].ToString());
                var olddata = db.ResgisterShoppings.Where(x => x.Id == oldid).SingleOrDefault();
                db.ResgisterShoppings.Remove(olddata);
                var res = db.SaveChanges();
                if (res > 0)
                    ModelState.AddModelError("", "Data Deleted");
            }
            return View();
        }
        [HttpGet]
        public ActionResult SelectandEdit()
        {
            var data = db.ResgisterShoppings.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var data = db.ResgisterShoppings.Where(x => x.Id == id).SingleOrDefault();
            Session["RSData"] = data;
            return View();
        }
        [HttpPost]
        public ActionResult Update()
        {
            int id = int.Parse(Request.Form["txtid"].ToString());
            var olddata = db.ResgisterShoppings.Where(x => x.Id == id).SingleOrDefault();
            olddata.Membership = Request.Form["txtmem"].ToString();
            olddata.COD = Request.Form["txtcod"].ToString();
            olddata.ShoppingPreference = Request.Form["txtshop"].ToString();
            olddata.Password = Request.Form["txtpass"].ToString();
            var res = db.SaveChanges();
            if (res > 0)
            {

                //Response.Write("Data Updated");
                return RedirectToAction("SelectandEdit");//redirecting from controller
            }
            return View();
        }
    }
}