using SiteManager.Models;
using SiteManager.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteManager.Core.DependencyInjection;

namespace SiteManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebsiteRepository websiteRepository;

        public HomeController(IWebsiteRepository websiteRepository)
        {
            this.websiteRepository = websiteRepository;
        }

        public ActionResult Index()
        {
            //var homeViewModel = new HomeViewModel() {
            //    Websites = new List<Models.Website>() {
            //     new Website() {
            //         Name = "Test",
            //         PrimaryUrl = "http://localhost"
            //     }
            //    }
            //};

            var homeViewModel = new HomeViewModel() {
                Websites = websiteRepository.GetWebsites().ToList()
            };

            return View(homeViewModel);
        }
    }
}