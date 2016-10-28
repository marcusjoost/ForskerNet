using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ForskerNet.Services;

namespace ForskerNet.Controllers
{
    public class HomeController : Controller
    {
        private IPublicationData _publicationData;

        public HomeController(IPublicationData publicationData)
        {
            _publicationData = publicationData;
        }
        public IActionResult Publications()
        {
            var model = _publicationData.GetAll();
            return Json(model);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}