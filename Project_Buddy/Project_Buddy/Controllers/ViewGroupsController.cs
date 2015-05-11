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
    public class ViewGroupsController : Controller
    {
        //
        // GET: /ViewGroup/
        IpBuddy pb;
        public ViewGroupsController(IpBuddy obj)
        {
            pb = obj;
        }
        public ActionResult ViewGroups(int id)
        {

            List<User> user = pb.viewGroupList(id);
            ViewBag.UserName = user[0].name;
            ViewBag.userId = user[0].user_id; 
            return View();
        }

    }
}
