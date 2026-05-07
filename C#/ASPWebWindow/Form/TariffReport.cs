using ASPWebWindow.Models;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace ASPWebWindow
{
    public partial class TariffReport : DevExpress.XtraReports.UI.XtraReport
    {
        public TariffReport()
        {
            InitializeComponent();
        }

        // Cargo 데이터 받아서 Label에 채우기
        public void SetData(Cargo cargo, decimal tariffAmount, decimal ratePercent)
        {
            txtCargoNumber.Text = cargo.CargoNumber;
            txtItemName.Text = cargo.ItemName;
            txtHsCode.Text = cargo.HsCode;
            txtOriginCountry.Text = cargo.OriginCountry;
            txtDeclaredValue.Text = cargo.DeclaredValue.ToString("N0") + "원";
            txtRatePercent.Text = ratePercent.ToString() + "%";
            txtTariffAmount.Text = tariffAmount.ToString("N0") + "원";
            txtCalcDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        }
    }
}
