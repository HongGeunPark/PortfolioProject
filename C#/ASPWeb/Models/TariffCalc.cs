namespace ASPWeb.Models
{
    public class TariffCalc
    {
        public int TariffCalcId { get; set; }
        public int CargoId { get; set; }
        public decimal DeclaredValue { get; set; }
        public decimal RatePercent { get; set; }
        public decimal TariffAmount { get; set; }
        public DateTime CalcDate { get; set; }
    }
}
