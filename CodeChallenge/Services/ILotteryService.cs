using CodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
  public  interface ILotteryService
    {
        Task<LatestLotteriesResultsResponse> GetLatestLotteriesResultsAsync(LotteriesResultsRequest request);

         Task<OpenLotteriesDrawsResponse> GetOpenLotteriesDrawsAsync(OpenLotteriesDrawsRequest request);
    }
}
