using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GreenTown.Domain.Abstract;
using GreenTown.Domain.Entities;

namespace GreenTown.UI.Controllers
{
    public class HomeController : Controller
    {
        private IHouseRepository repository;     
        public HomeController(IHouseRepository productRepository) 
        {
            this.repository = productRepository;   
        }

        public FileContentResult GetImage(int houseId) 
        {
            House house = repository.Houses.FirstOrDefault(p => p.HouseID == houseId);
            if (house != null) 
            {
                return File(house.ImageData, house.ImageMimeType); 
            }
            else 
            {
                return null; 
            }
        } 


        public ViewResult List(int id = 1)   
        {
            return View(repository.Houses.First(p => p.HouseID ==id));
        }

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult SocialPrograms()
        {
            return View();
        }

        public ViewResult Photo()
        {
            return View();
        }

        public ViewResult Map()
        {
            return View();
        }

    }
}
