﻿using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{

    public class Product2
    {
        public int Id { get; set; }
        public string Name   { get; set; }
    }
    public class OrnekController : Controller
    {
        public IActionResult Index()

        {
            var productlist = new List<Product2>()
            {
                new(){Id=1,Name="Kalem"},
                new(){Id=2,Name="Defter" },
                new (){Id=3,Name="Silgi"}
            }; 
            


           
          
            return View(productlist);
     
        }
        public IActionResult Index3()
        {
            var soyad=TempData["soyad"];
            return View(); 
        }
        public IActionResult ParametereView(int id)
        {
            return RedirectToAction("JsonResaultParametere", "Ornek", new {id=id});
        }
        public IActionResult JsonResaultParametere(int id)
        {
            return Json(new { Id = id });
        }
       

        public IActionResult ContentResault() {

            return Content(" String bir ifade yani content resault");

        
        }
        public IActionResult JsonResault()
        {
            return Json(new { id = 1, name = "kalem 1", price = "100 $" });
        }

    }

}
