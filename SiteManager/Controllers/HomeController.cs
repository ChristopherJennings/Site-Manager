using SiteManager.Models;
using SiteManager.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SiteManager.Repositories.Implementations;

namespace SiteManager.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
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

            var repo = new WebsiteRepository();
            var homeViewModel = new HomeViewModel() {
                Websites = repo.GetWebsites().ToList()
            };

            return View(homeViewModel);
        }
    }
}