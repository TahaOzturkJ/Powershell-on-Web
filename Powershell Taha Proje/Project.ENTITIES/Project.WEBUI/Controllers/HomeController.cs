using Project.BLL.DesignPatterns.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
using Project.WEBUI.VMClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Project.WEBUI.Controllers
{
    public class HomeController : Controller
    {
        UserRepository _uRep;

        public HomeController()
        {
            _uRep = new UserRepository();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user, string username, string password)
        {
            User u = _uRep.FirstOrDefault(x => x.UserName == username && x.Password == password);

            if (u != null)
            {
                return RedirectToAction("Index", "Panel");
            }
            return View();
        }

    }
}