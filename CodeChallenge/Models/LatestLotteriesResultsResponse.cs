using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeChallenge.Models
{
    public class LatestLotteriesResultsResponse
    {
        public List<DrawResult> DrawResults { get; set; }
        public object ErrorInfo { get; set; }
        public bool Success { get; set; }

    }


    public class Dividend
    {
        public int Division { get; set; }
        public int BlocNumberOfWinners { get; set; }
        public double BlocDividend { get; set; }
        public string CompanyId { get; set; }
        public int CompanyNumberOfWinners { get; set; }
        public double CompanyDividend { get; set; }
        public string PoolTransferType { get; set; }
        public int PoolTransferredTo { get; set; }
    }

    public class DrawResult
    {
        public string ProductId { get; set; }
        public int DrawNumber { get; set; }
        public DateTime DrawDate { get; set; }
        public string DrawDisplayName { get; set; }
        public string DrawLogoUrl { get; set; }
        public List<int> PrimaryNumbers { get; set; }
        public List<int> SecondaryNumbers { get; set; }
        public object TicketNumbers { get; set; }
        public List<Dividend> Dividends { get; set; }
    }
}