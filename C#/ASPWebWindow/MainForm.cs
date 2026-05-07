using ASPWebWindow.Models;
using ASPWebWindow.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace ASPWebWindow
{
    public partial class MainForm : Form
    {
        private CargoApiClient cargoApiClient = new CargoApiClient();
        private TariffApiClient tariffApiClient = new TariffApiClient();
        GridView gridView;

        public MainForm()
        {
            InitializeComponent();
            InitEvent();
        }

        private void InitEvent()
        {
            this.Load += Form1_Load;
            btnSearch.Click += BtnSearch_Click;
            btnAdd.Click += BtnAdd_Click;
            btnChange.Click += BtnChange_Click;
            btnDelete.Click += BtnDelete_Click;
            btnTariff.Click += BtnTariff_Click;

            gridMain.DoubleClick += GridMain_DoubleClick;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            gridView = gridMain.MainView as GridView;
            gridView.OptionsBehavior.Editable = false;
            LoadCargo();
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            LoadCargo();
        }
        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            CargoAdd cargoAdd = new CargoAdd();
            cargoAdd.ShowDialog();

            btnSearch.PerformClick();
        }

        private void BtnChange_Click(object? sender, EventArgs e)
        {           
            if (gridView.GetFocusedRow == null)
            {
                MessageBox.Show("신고 번호를 선택해주세요.");
                return;
            }

            CargoUpdate cargoUpdate = new CargoUpdate();
            cargoUpdate.OriginCargo = gridView.GetFocusedRow() as Cargo;
            cargoUpdate.ShowDialog();

            btnSearch.PerformClick();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (gridView.GetFocusedRow == null)
            {
                MessageBox.Show("신고 번호를 선택해주세요.");
                return;
            }

            Cargo cargo = gridView.GetFocusedRow() as Cargo;

            if (MessageBox.Show("화물번호: " + cargo.CargoNumber + "를 취소 하시겠습니까?", "신고 취소", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (cargoApiClient.ExecuteDML(cargo, "D"))
            {
                MessageBox.Show("성공 했습니다.");

                btnSearch.PerformClick();
            }
            else
            {
                MessageBox.Show(cargoApiClient.returnMessage);
            }
        }

        private void BtnTariff_Click(object? sender, EventArgs e)
        {
            Cargo selectedCargo = gridView.GetFocusedRow() as Cargo;

            if (selectedCargo == null)
            {
                MessageBox.Show("신고 번호를 선택해주세요.");
                return;
            }

            // 관세 계산 API 호출
            var result = tariffApiClient.CalcAndSave(selectedCargo.CargoId);

            // Report 생성 및 데이터 설정
            TariffReport report = new TariffReport();
            report.SetData(selectedCargo, result.TariffAmount, result.RatePercent);

            // Report 미리보기
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void GridMain_DoubleClick(object? sender, EventArgs e)
        {
            CargoHistory cargoHistory = new CargoHistory();
            cargoHistory.cargo = gridView.GetFocusedRow() as Cargo;
            cargoHistory.Show();
        }

        private void LoadCargo()
        {
            List<Cargo> list = cargoApiClient.GetAll();
            gridMain.DataSource = list;

            gridView.Columns.Clear();
            gridView.Columns.AddField("CargoNumber").VisibleIndex = 0;
            gridView.Columns.AddField("ItemName").VisibleIndex = 1;
            gridView.Columns.AddField("HsCode").VisibleIndex = 2;
            gridView.Columns.AddField("OriginCountry").VisibleIndex = 3;
            gridView.Columns.AddField("DestCountry").VisibleIndex = 4;
            gridView.Columns.AddField("WeightKg").VisibleIndex = 5;
            gridView.Columns.AddField("DeclaredValue").VisibleIndex = 6;
            gridView.Columns.AddField("userID").VisibleIndex = 7;
            gridView.Columns.AddField("Status").VisibleIndex = 8;
            gridView.Columns.AddField("DeclaredDate").VisibleIndex = 9;

            // 컬럼 헤더명 변경
            gridView.Columns["CargoNumber"].Caption = "화물번호";
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
            gridView.Columns["ItemName"].Width = 100;
            gridView.Columns["DeclaredDate"].Width = 120;
        }
    }
}
