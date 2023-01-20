using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogicLayer;
using BusinessObjects;

namespace PresentationLayer.Controllers
{
    public class GenderController : Controller
    {
        // GET: Gender
        public ActionResult Index()
        {
            genderBusinessLogic gbl = new genderBusinessLogic();
            var genderList=gbl.GetAllGenders();
            return View(genderList);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(GenderModel genmodel)
        {
            genderBusinessLogic genderBusinessLogic = new genderBusinessLogic();
            genderBusinessLogic.AddGender(genmodel);

            return RedirectToAction("Index");
        }
    }
}