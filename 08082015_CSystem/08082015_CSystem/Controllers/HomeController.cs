using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utils;
using _08082015_CSystem.Models;

namespace _08082015_CSystem.Controllers
{
    public class HomeController : Controller
    {
        private static List<UserInfo> ms_users=new List<UserInfo>(); 
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Create(UserInfo ui)
        //{
        //    ms_users.Add(ui);

        //    return View(ms_users);
        //}

        public string Create(UserInfo ui)
        {
            ms_users.Add(ui);


            List<string> users=new List<string>();
            foreach (UserInfo u in ms_users)
                users.Add(string.Format("{0}-{1}",u.Name,u.Role));


            return HTMLGenerate.GenerateUnOrderedList(users.ToArray());
        }
	}
}