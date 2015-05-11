using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Buddy.Models;

namespace Project_Buddy.Controllers
{
    public class GroupViewController : Controller
    {
        //
        // GET: /GroupView/
        IpBuddy pb;
        public GroupViewController(IpBuddy obj)
        {
            pb = obj;
        }
        [HttpPost]
        public ActionResult Create(int id)
        {
            int count = pb.getManagerCount();
            int userId = id;
            var date = DateTime.Now.Date;
            var visibility = Request["visibility"];
            var groupname = Request["groupname"];

            Group new_group = new Group();
            new_group.uId = userId;
            new_group.group_name = groupname;
            new_group.uId = userId;
            new_group.visibility = visibility;
            new_group.date_created = date.ToString();
            
            List<Group> record = pb.createGroup(new_group);
            
                var grId = record[0].group_id;
                int mgrId = count;
                Manager new_manager = new Manager();
                new_manager.gId = grId;
                //  new_manager.manager_id = mgrId;
                new_manager.user_id = userId;
                pb.addManager(new_manager);
               
               return RedirectToAction("GroupView", new { gId = grId });
            
            
        }
        public ActionResult GroupView(int gId)
        {
            List<Group> group = pb.viewGroup(gId);
            ViewBag.groupname = group[0].group_name;
            ViewBag.vissibility = "This Group Is " + group[0].visibility;
         //   List<User> user = db.Users.Where(x => x.user_id == group[0].uId).ToList();
         //   ViewBag.managername = user[0].name;

            return View();
        }

    }
}
