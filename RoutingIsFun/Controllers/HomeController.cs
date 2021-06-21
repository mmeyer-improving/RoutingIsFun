﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RoutingIsFun.Models;

namespace RoutingIsFun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("watch")]
        public IActionResult Watch(string v)
        {
            List<KeyValuePair<string, string>> properties = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("v", v)
            };

            ViewBag.Properties = properties;

            return View("AllForOne");
        }

        [Route("gp/buyagain")]
        public IActionResult BuyAgain(string ie, string ref_)
        {
            List<KeyValuePair<string, string>> properties = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("ie", ie),
                new KeyValuePair<string, string>("ref_", ref_)
            };

            ViewBag.Properties = properties;

            return View("AllForOne");
        }

        [Route("{product}/dp/{productCode}")]
        public IActionResult DefinitelyPurchase(string product, string productCode, string pd_rd_w, string pf_rd_p, string pf_rd_r, string pd_rd_r, string pd_rd_wg, string pd_rd_i, string psc, string ref_)
        {
            List<KeyValuePair<string, string>> properties = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("product", product),
                new KeyValuePair<string, string>("productCode", productCode),
                new KeyValuePair<string, string>("pd_rd_w", pd_rd_w),
                new KeyValuePair<string, string>("pf_rd_p", pf_rd_p),
                new KeyValuePair<string, string>("pf_rd_r", pf_rd_r),
                new KeyValuePair<string, string>("pd_rd_r", pd_rd_r),
                new KeyValuePair<string, string>("pd_rd_wg", pd_rd_wg),
                new KeyValuePair<string, string>("pd_rd_i", pd_rd_i),
                new KeyValuePair<string, string>("psc", psc),
                new KeyValuePair<string, string>("ref_", ref_)
            };

            ViewBag.Properties = properties;

            return View("AllForOne");
        }

        [Route("{year}/{month}/{day}/{category}/{title}")]
        public IActionResult Cnn(string year, string month, string day, string category, string title)
        {
            List<KeyValuePair<string, string>> properties = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("year", year),
                new KeyValuePair<string, string>("month", month),
                new KeyValuePair<string, string>("day", day),
                new KeyValuePair<string, string>("category", category),
                new KeyValuePair<string, string>("title", title)
            };

            ViewBag.Properties = properties;

            return View("AllFOrOne");
        }

        [Route("shows/{showName}/episode-guide/{season}/{episode}")]
        public IActionResult EpisodeGuide(string showName, string season, string episode)
        {
            List<KeyValuePair<string, string>> properties = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("showName", showName),
                new KeyValuePair<string, string>("season", season),
                new KeyValuePair<string, string>("episode", episode)
            };

            ViewBag.Properties = properties;

            return View("AllForOne");
        }

        [Route("shows/{showName}/video/{probablyImportantGUID}/{titleAndDate}")]
        public IActionResult WatchEpisode(string showName, string probablyImportantGUID, string titleAndDate)
        {
            List<KeyValuePair<string, string>> properties = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("showName", showName),
                new KeyValuePair<string, string>("probablyImportantGUID", probablyImportantGUID),
                new KeyValuePair<string, string>("titleAndDate", titleAndDate)
            };

            ViewBag.Properties = properties;

            return View("AllForOne");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
