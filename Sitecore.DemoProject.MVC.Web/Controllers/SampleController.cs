using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.DemoProject.MVC.Web.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult List()
        {
            List<string> model = new List<string>();
            model.Add("Sarthak");
            model.Add("Sushant");
            model.Add("Abhishek");
            model.Add("Yash");
            model.Add("Abhuday");
            return View(model); //return model details to the view
        }
    }
}