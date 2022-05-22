using CodeChallenge.Models;
using CodeChallenge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        private lotteryService _lotteryService;

        public HomeController()
        {
            // We can instantiate through Dependency injection
            _lotteryService = new lotteryService(); 

        }

        public async Task<ActionResult> Index()
        {
            var request = new LotteriesResultsRequest()
            {
                CompanyId = "Tattersalls",
                MaxDrawCountPerProduct = 1,
                OptionalProductFilter = new List<string>() { "OZlotto", "Powerball" } //  Getting error when filter for Gold Lotto

            };

            var result = await _lotteryService.GetLatestLotteriesResultsAsync(request);

            return View(result);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      
    }
}