using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPWebWindow.Models
{
    public class Cargo
    {       
        public int CargoId { get; set; } // SQL Server에서 자동 
        public int LastHistSeq { get; set; }
        public int HistSeq { get; set; }
        public string CargoNumber { get; set; }
        public string ItemName { get; set; }
        public string HsCode { get; set; }
        public string OriginCountry { get; set; }
        public string DestCountry { get; set; }
        public decimal WeightKg { get; set; }
        public decimal DeclaredValue { get; set; }
        public int Status { get; set; } // 초기 값 : 0  ( 0 : 신고, 1 : 심사중, 2 : 통관 완료)
        public string userID { get; set; } // 초기 값 : 0  ( 0 : 신고, 1 : 심사중, 2 : 통관 완료)
        public DateTime DeclaredDate { get; set; }
        public DateTime CreatedAt { get; set; } // SQL Server에서 현재 시간으로 정의
    }
}
