using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bhagaskara.Models;
using System.Data.Entity;

namespace bhagaskara.Controllers
{
    public class HomeController : Controller
    {

        Feedback_context db = new Feedback_context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
          

            return View();
        }

        public ActionResult Contact()
        {
            

            return View();
        }
        public ActionResult Services()
        {
           

            return View();
        }
        public ActionResult Team()
        {


            return View();
        }
        public ActionResult Portfolio()
        {


            return View();
        }



        [HttpPost]
        public ActionResult CreateFeedback(Feedback feedback)
        {
            db.Feedback.Add(feedback);
            db.SaveChanges();
           ViewBag.Message = "Thanks for your message";
            return View("Contact");
        }


    //    [HttpPost]
    //    public JavaScriptResult CreateFeedback(Feedback feedback)
    //    {
    //        db.Feedback.Add(feedback);
    //        db.SaveChanges();

    //        //  var script = @"alert(""Email sent successfully"");";
    //        return RedirectToAction("<script language='javascript' type='text/javascript'>alert('Hello world!');</script>");
    //    }
    }
}