using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace TaviscaHotel.Controllers
{
    public class HomeController : Controller
    {
        public List<HotelStaticData> hotelList;
        public HomeController()
        {
            RdWrJsonFile obj =new RdWrJsonFile();       //reading JSON file
            hotelList = obj.GetAllHotels();

        }                
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpGet]
        public void GetAllHotelById(int id) // on click get hotel details (COMBINED from both database)
        {
            
        }
        [HttpPut]
        public void UpdateHotels() //book and save
        {

        }
        
    }
}
