using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeChallenge.Controllers;
using CodeChallenge.Services;
using CodeChallenge.Models;

namespace CodeChallenge.Tests.Services
{
    [TestClass]
    public class lotteryServiceTest
    {
        [TestMethod]
        public async System.Threading.Tasks.Task TestGetLatestLotteriesResultsNotNull()
        {
            var lotteryService = new lotteryService();

            var request = new LotteriesResultsRequest()
            {
                CompanyId = "Tattersalls",
                MaxDrawCountPerProduct = 1
            };

            var result = await lotteryService.GetLatestLotteriesResultsAsync(request);
            // Assert
            Assert.IsNotNull(result.DrawResults);

        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestProductDisplay_OZlotto_Powerball()
        {
            var lotteryService = new lotteryService();

            var request = new LotteriesResultsRequest()
            {
                CompanyId = "Tattersalls",
                MaxDrawCountPerProduct = 1,
                OptionalProductFilter = new List<string>() { "OZlotto", "Powerball" } //  Getting error when filter for Gold Lotto

            };

            var result = await lotteryService.GetLatestLotteriesResultsAsync(request);

            // Assert
            Assert.IsNotNull(result.DrawResults);

        }


        [TestMethod]
        public async System.Threading.Tasks.Task GetOpenLotteriesDrawsNotNull()
        {
            var lotteryService = new lotteryService();

            var request = new OpenLotteriesDrawsRequest()
            {
                CompanyId = "Tattersalls",
                MaxDrawCount = 1,
                OptionalProductFilter = new List<string>() { "Pools", "Super66" } 

            };

            var result = await lotteryService.GetOpenLotteriesDrawsAsync(request);

            // Assert
            Assert.IsNotNull(result.Draws);

        }

    }
}
