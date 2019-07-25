using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NiRA_Clothes.Models;

namespace NiRA_Clothes.Controllers
{
    public class ClothesController : Controller
    {
        // GET: Clothes/Ramdom
        //public String Index()
        //{
        //    return "Please enter the right URL";
        //}
        public ActionResult Index(int? PageIndex, string SortBy)
        {

            if (!PageIndex.HasValue)
            {
                PageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(SortBy))
            {
                SortBy = "name";
            }
            return Content(string.Format("PageIndex = {0} & SortBy = {1}", PageIndex, SortBy));
            //return Content(string.Format("PageIndex = {0} & SortBy = {1}", PageIndex, SortBy));
        }
        public ActionResult Ramdom2(string name, int id, string price)
        {
            ViewBag.name = name;
            ViewBag.id = id;
            ViewBag.price = price;

            ViewBag.Message = "NirA Store";
            //var clothes = new Clothes() { NameOfProduct = name, ID = id, Price = price};

            return View();
        }

        public ActionResult Ramdom()
        {
            var clothes = new Clothes() { NameOfProduct = "Skirt", ID = 002, Price = 210000 };

            //return View(model:clothes);
            //return RedirectToAction("Index", "Home");
            return RedirectToAction("Ramdom2", "Clothes", new { page = "Edit", sortBy = "name" }); //Return to ../Clothes/Ramdom2 action. 
                                                                                                   //And give some COMMENT for user to understand
        }

        //public ActionResult TestParameter(int? PageIndex, string SortBy)
        //{
        //    if (!PageIndex.HasValue)
        //    {
        //        PageIndex = 1;
        //    }
        //    if (string.IsNullOrWhiteSpace(SortBy))
        //    {
        //        SortBy = "name";
        //    }
        //    return Content(String.Format("PageIndex = {0} & SortBy = {1}", PageIndex, SortBy));
        //}
        


    }
}