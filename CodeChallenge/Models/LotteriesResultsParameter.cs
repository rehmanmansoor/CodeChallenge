using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeChallenge.Models
{
    public class LotteriesResultsRequest
    {
        public string CompanyId { get; set; }
        public int MaxDrawCountPerProduct { get; set; }
        public List<string> OptionalProductFilter { get; set; }
    }
}