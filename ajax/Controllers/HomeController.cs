using ajax.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ajax.Controllers
{
    public class HomeController : Controller
    {
        public static List<userModel> users = new List<userModel>
        {
            new userModel(){ fullName = "rabia akbulut", date = DateTime.Now, age = 22, city="İSTANBUL"},
            new userModel(){ fullName = "ayşe demir", date = DateTime.Now, age = 18, city="BURSA"},
            new userModel(){ fullName = "ali yılmaz", date = DateTime.Now, age = 30, city="RİZE"},
        };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.cities = GetDropdownValues();
            return View(users);
        }
        [HttpPost]
        public void AddUser(userModel user)
        {
            users.Add(user);
        }

        public dynamic GetDropdownValues()
        {
            var webClient = new WebClient() { Encoding = Encoding.UTF8 };
            var json = webClient.DownloadString("C:/Users/LENOVO/source/repos/ajax/ajax/App_Data/iller.json");
            var dynamicObject = JsonConvert.DeserializeObject<dynamic>(json);
            return dynamicObject;
        }

    }
}