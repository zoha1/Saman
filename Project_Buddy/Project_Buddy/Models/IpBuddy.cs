using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using Project_Buddy.Models; 

namespace Project_Buddy.Models
{
    public interface IpBuddy
    {
        List<User> save_signup(User u);
         List<User> save_signin(User u);
         List<User> viewGroupList(int id);
         List<User> searchGroup(int id);
        List<User> mainPage(int id);
        List<Group> viewGroup(int gId);
        List<Group> createGroup(Group new_group);
        int getManagerCount();
        void addManager(Manager mgr);
    }
}
