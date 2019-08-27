using CloudBerryRehber.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CloudBerryRehber.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string file = Server.MapPath("~/App_Data/data.json");
            string Json = System.IO.File.ReadAllText(file);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var personList = ser.Deserialize<List<Person>>(Json);
            return View(personList);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Person model)
        {
            string file = Server.MapPath("~/App_Data/data.json");
            var json = System.IO.File.ReadAllText(file);
            var persons = JsonConvert.DeserializeObject<List<Person>>(json);
            persons.Add(model);
            System.IO.File.WriteAllText(file, JsonConvert.SerializeObject(persons));
            return RedirectToAction("Index");
        }
    }
}