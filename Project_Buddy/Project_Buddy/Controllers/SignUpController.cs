using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using Project_Buddy.Models;

namespace Project_Buddy.Controllers
{
    public class SignUpController : Controller
    {
        //
        // GET: /Signup/
        IpBuddy pb;
        public SignUpController(IpBuddy obj)
        {
            pb = obj;
        }
        
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult registration()
        {
            string name = Request["name"];
            string email = Request["email"];
            string pas = Request["password"];
            string num = Request["mobileNumber"];
            string country = Request["Country"];
            string city = Request["City"];
            
            User u = new User();
          
            u.name = name;
            u.email = email;
            u.password = pas;
            u.mobileNo = num;
            u.country = country;
            u.city = city;

            List<User> user= pb.save_signup(u);
             
            return RedirectToAction("MainPage", "MainPage", new { id= user[0].user_id });
        }

    }
}
