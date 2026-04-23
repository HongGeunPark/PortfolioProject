using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebWindow.Models
{
    public class TariffRate
    {
        public int TariffRateId { get; set; }
        public string HsCode { get; set; }
        public string ItemCategory { get; set; }
        public double RatePercent { get; set; }
    }
}
