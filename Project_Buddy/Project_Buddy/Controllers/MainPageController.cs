using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Buddy.Models;

namespace Project_Buddy.Controllers
{
    public class MainPageController : Controller
    {
        //
        // GET: /Profile/
        IpBuddy pb;
        public MainPageController(IpBuddy obj)
        {
            pb = obj;
        }
        public ActionResult MainPage(int id)
        {

            List<User> user = pb.mainPage(id); 
            ViewBag.UserName=user[0].name;
            ViewBag.userId = user[0].user_id;
            return View();
        }
       
        

    }
}
