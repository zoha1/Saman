using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using Project_Buddy.Models;

namespace Project_Buddy.Models
{
    public class pBuddy:IpBuddy
    {
        DatabaseEntities2 db = new DatabaseEntities2();
        public List<User> save_signup(User u)
        {
                db.Users.Add(u);
                db.SaveChanges();
                List<User> user = db.Users.Where(x => x.email.Equals(u.email)).ToList();
                return user;          
        }
        public List<User> save_signin(User u)
        {
            List<User> record = (db.Users.Where(x => x.email.Equals(u.email) && x.password.Equals(u.password))).ToList();
                return record;
        }
        public List<User> viewGroupList(int id)
         {
             List<User> user = db.Users.Where(x => x.user_id == id).ToList();
             return user;
         }
        public List<User> searchGroup(int id)
         {
             List<User> user = db.Users.Where(x => x.user_id == id).ToList();
             return user;
         }
        public List<User> mainPage(int id)
         {
             List<User> user = db.Users.Where(x => x.user_id == id).ToList();
             return user;
         }
        public List<Group> viewGroup(int gId)
        {
            List<Group> group = db.Groups.Where(x => x.group_id == gId).ToList();
            return group;
        }
        public int getManagerCount()
        {
            int count=db.Managers.Select(x => x).Count();
            return count;
        }
        public List<Group> createGroup(Group new_group)
        {
            db.Groups.Add(new_group);
            db.SaveChanges();
            List<Group> record = db.Groups.Where(x => x.uId == new_group.group_id).ToList();
            return record;
        }
        public void addManager(Manager mgr)
        {
            db.Managers.Add(mgr);
            db.SaveChanges();
        }
    }
}