namespace ASPWeb.Models
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public int LastHistSeq { get; set; }
        public int HistSeq { get; set; }
        public string CargoNumber { get; set; }
        public string ItemName { get; set; }
        public string HsCode { get; set; }
        public string OriginCountry { get; set; }
        public string DestCountry { get; set; }
        public decimal WeightKg { get; set; }
        public decimal DeclaredValue { get; set; }
        public int Status { get; set; }
        public string UserID { get; set; }
        public DateTime DeclaredDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
