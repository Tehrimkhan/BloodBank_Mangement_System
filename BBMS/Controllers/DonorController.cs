using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BBMS.Models;


namespace BBMS.Controllers
{
    public class DonorController : Controller
    {
        [HttpGet]
        public ActionResult Donor()
        {
            Donor donorModel = new Donor();
            return View(donorModel);
        }
        [HttpPost]
        public ActionResult Donor(Donor donorModel)
        {
            using (DbmsEntities1 dbModel = new DbmsEntities1())
            {
                dbModel.Donors.Add(donorModel);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Succesfull";
            return View("Donor", new Donor());
        }
    }
}