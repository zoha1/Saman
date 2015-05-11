using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Buddy.Models;

namespace Project_Buddy.Controllers
{
    public class CreateGroupController : Controller
    {
        //
        // GET: /CreateGroup/

        public ActionResult CreateGroup(int id)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            List<User> user = db.Users.Where(x => x.user_id == id).ToList();
            ViewBag.UserName = user[0].name;
            ViewBag.userId = user[0].user_id;

            return View();
        }

    }
}
