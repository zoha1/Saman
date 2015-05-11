using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Buddy.Models;
using System.Data;
using System.Data.Entity;
namespace Project_Buddy.Controllers
{
    public class SignInController : Controller
    {
        //
        // GET: /Signip/
        IpBuddy pb;
        public SignInController(IpBuddy obj)
        {
            pb = obj;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult validation()
        {
            var emailid =Request["email"];
            var pas = Request["password"];
            User u = new User();
            u.email = emailid;
            u.password = pas;
            List<User> record = pb.save_signin(u);
            
            if (record.Count>0)
            {
               // ViewData["user_id"] = record[0].user_id;
                
               int user_id=record[0].user_id;


               return RedirectToAction("MainPage", "MainPage", new {id=user_id });
            }
            else
            {

                return Redirect("/ReSignIn/ReSignIn");
            }
            
        }

        

    }
}
