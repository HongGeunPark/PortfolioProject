using ASPWebWindow.Models;
using ASPWebWindow.Services;
using DevExpress.XtraGrid.Views.Grid;

namespace ASPWebWindow
{
    public partial class CargoHistory : Form
    {
        public Cargo cargo = new Cargo();
        CargoApiClient cargoApiClient = new CargoApiClient();
        GridView gridView;

        public CargoHistory()
        {
            InitializeComponent();
            InitEvent();
        }

        private void InitEvent()
        {
            this.Load += CargoHistory_Load;
        }

        private void CargoHistory_Load(object? sender, EventArgs e)
        {
            gridView = gridHistory.MainView as GridView;

            txtCargoNumber.Text = cargo.CargoNumber;
            txtItemName.Text = cargo.ItemName;

            LoadHistroy();
        }

        private void LoadHistroy()
        {
            List<Cargo> list = cargoApiClient.GetHistory(cargo.CargoId);
            gridHistory.DataSource = list;

            gridView.Columns.Clear();
            gridView.Columns.AddField("CargoNumber").VisibleIndex = 0;
            gridView.Columns.AddField("HistSeq").VisibleIndex = 1;
            gridView.Columns.AddField("ItemName").VisibleIndex = 2;
            gridView.Columns.AddField("HsCode").VisibleIndex = 3;
            gridView.Columns.AddField("OriginCountry").VisibleIndex = 4;
            gridView.Columns.AddField("DestCountry").VisibleIndex = 5;
            gridView.Columns.AddField("WeightKg").VisibleIndex = 6;
            gridView.Columns.AddField("DeclaredValue").VisibleIndex = 7;
            gridView.Columns.AddField("userID").VisibleIndex = 8;
            gridView.Columns.AddField("Status").VisibleIndex = 9;
            gridView.Columns.AddField("DeclaredDate").VisibleIndex = 10;

            // 컬럼 헤더명 변경
            gridView.Columns["CargoNumber"].Caption = "화물번호";
            gridView.Columns["HistSeq"].Caption = "이력 순번";
            gridView.Columns["ItemName"].Caption = "품명";
            gridView.Columns["HsCode"].Caption = "HS코드";
            gridView.Columns["OriginCountry"].Caption = "수입국";
            gridView.Columns["DestCountry"].Caption = "수출국";
            gridView.Columns["WeightKg"].Caption = "중량(kg)";
            gridView.Columns["DeclaredValue"].Caption = "신고 가격";
            gridView.Columns["userID"].Caption = "신고인";
            gridView.Columns["Status"].Caption = "상태";
            gridView.Columns["DeclaredDate"].Caption = "신고 일자";

            gridView.Columns["CargoNumber"].Width = 90;
            gridView.Columns["HistSeq"].Width = 70;
            gridView.Columns["ItemName"].Width = 100;
            gridView.Columns["DeclaredValue"].Width = 70;
            gridView.Columns["Status"].Width = 30;
            gridView.Columns["DeclaredDate"].Width = 120;
        }
    }
}
