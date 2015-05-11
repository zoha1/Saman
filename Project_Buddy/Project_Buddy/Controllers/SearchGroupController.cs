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
    public class SearchGroupController : Controller
    {
        //
        // GET: /SearchGroup/
        IpBuddy pb;
        public SearchGroupController(IpBuddy obj)
        {
            pb = obj;
        }
        public ActionResult SearchGroup(int id)
        {

            List<User> user = pb.searchGroup(id);
            ViewBag.UserName = user[0].name;
            ViewBag.userId = user[0].user_id;
            return View();
        }

    }
}
