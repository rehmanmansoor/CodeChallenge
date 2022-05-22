using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeChallenge.Models
{
    public class OpenLotteriesDrawsRequest
    {
        public string CompanyId { get; set; }
        public int MaxDrawCount { get; set; }
        public List<string> OptionalProductFilter { get; set; }
    }
}