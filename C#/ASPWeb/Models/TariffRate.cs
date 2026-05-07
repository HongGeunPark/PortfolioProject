namespace ASPWeb.Models
{
    public class TariffRate
    {
        public int TariffRateId { get; set; }
        public string HsCode { get; set; }
        public string ItemCategory { get; set; }
        public decimal RatePercent { get; set; }
    }
}
