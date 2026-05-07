using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebWindow.Models
{
    public class TariffCalc
    {
        public int TariffCalcId { get; set; }
        public int CargoId { get; set; }
        public double DeclaredValue { get; set; }
        public double RatePercent { get; set; }
        public double TariffAmount { get; set; }
        public DateTime CalcDate { get; set; }
    }
}
