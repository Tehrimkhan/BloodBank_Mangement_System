using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BBMS.Models;


namespace BBMS.Controllers
{
    public class RecieverController : Controller
    {
        [HttpGet]
        public ActionResult Reciever()
        {
            Reciever recieverModel = new Reciever();
            return View(recieverModel);
        }
        [HttpPost]
        public ActionResult Reciever(Reciever recieverModel)
        {
            using (DbmsEntities2 dbModel = new DbmsEntities2())
            {
                dbModel.Recievers.Add(recieverModel);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Succesfull";
            return View("Reciever", new Reciever());
        }
    }
}