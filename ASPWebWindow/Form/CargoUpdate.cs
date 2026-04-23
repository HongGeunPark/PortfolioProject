using ASPWebWindow.Models;
using ASPWebWindow.Services;
using DevExpress.XtraGrid.Views.Grid;

namespace ASPWebWindow
{
    public partial class CargoUpdate : Form
    {
        public Cargo OriginCargo = new Cargo();
        private CargoApiClient cargoApiClient = new CargoApiClient();
        private TariffApiClient tariffApiClient = new TariffApiClient();

        public CargoUpdate()
        {
            InitializeComponent();
            InitEvent();
        }

        private void InitEvent()
        {
            this.Load += CargoUpdate_Load;
            btnSave.Click += BtnSave_Click;
            btnClear.Click += BtnClear_Click;
            btnCancel.Click += BtnCancel_Click;

            cboItemName.EditValueChanged += CboItemName_EditValueChanged;
        }

        private void CargoUpdate_Load(object? sender, EventArgs e)
        {
            SetItemName();

            // 수정시 참고 데이터
            txtCargoNumber.Text = OriginCargo.CargoNumber;
            txtDestCountryB.Text = OriginCargo.DestCountry;
            txtHsCodeB.Text = OriginCargo.HsCode;
            txtItemNameB.Text = OriginCargo.ItemName;
            txtOriginCountryB.Text = OriginCargo.OriginCountry;
            txtWeightB.Text = OriginCargo.WeightKg.ToString();
            txtDeclaredValueB.Text = OriginCargo.DeclaredValue.ToString();
            dtpDeclaredDateB.Value = OriginCargo.DeclaredDate;
            txtUserB.Text = OriginCargo.userID;

            // 수정 데이터
            txtDestCountryA.Text = OriginCargo.DestCountry;
            txtHsCodeA.Text = OriginCargo.HsCode;
            cboItemName.EditValue = OriginCargo.ItemName;
            txtOriginCountryA.Text = OriginCargo.OriginCountry;
            txtWeightA.Text = OriginCargo.WeightKg.ToString();
            txtDeclaredValueA.Text = OriginCargo.DeclaredValue.ToString();
            dtpDeclaredDateA.Value = OriginCargo.DeclaredDate;
            txtUserA.Text = OriginCargo.userID;
        }

        private void CboItemName_EditValueChanged(object? sender, EventArgs e)
        {
            if (cboItemName.EditValue != null)
            {
                TariffRate selectRow = cboItemName.Properties.GetRowByKeyValue(cboItemName.EditValue) as TariffRate;
                if (selectRow != null)
                    txtHsCodeA.Text = selectRow.HsCode;
                else
                    txtHsCodeA.Text = string.Empty;
            }
            else
                txtHsCodeA.Text = string.Empty;
        }
        private void SetItemName()
        {
            cboItemName.Clear();
            List<TariffRate> list = tariffApiClient.GetRate();
            cboItemName.Properties.DataSource = list;
            cboItemName.Properties.DisplayMember = "ItemCategory";
            cboItemName.Properties.ValueMember = "ItemCategory";
            cboItemName.Properties.NullText = "";

            // 컬럼 설정 (보여줄 컬럼만)
            GridView view = cboItemName.Properties.View;
            view.Columns.Clear();
            view.Columns.AddField("ItemCategory").VisibleIndex = 0;
            view.Columns["ItemCategory"].Caption = "품목명";
            view.OptionsView.ShowIndicator = false;  // 왼쪽 화살표 제거
            view.OptionsView.ShowAutoFilterRow = false;  // 필터 행 제거 
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Cargo changeCargo = new Cargo();
            changeCargo.CargoId = OriginCargo.CargoId;
            changeCargo.CargoNumber = txtCargoNumber.Text;
            changeCargo.DestCountry = txtDestCountryA.Text;
            changeCargo.HsCode = txtHsCodeA.Text;
            changeCargo.ItemName = cboItemName.Text;
            changeCargo.OriginCountry = txtOriginCountryA.Text;
            changeCargo.WeightKg = Convert.ToDecimal(txtWeightA.Text);
            changeCargo.DeclaredValue = Convert.ToDecimal(txtDeclaredValueA.Text);
            changeCargo.DeclaredDate = dtpDeclaredDateA.Value;
            changeCargo.userID = txtUserA.Text;

            if (cargoApiClient.ExecuteDML(changeCargo, "U"))
            {
                MessageBox.Show("성공 했습니다.");

                this.Close();
            }
            else
            {
                MessageBox.Show(cargoApiClient.returnMessage);
            }
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtCargoNumber.Text = OriginCargo.CargoNumber;
            txtDestCountryA.Text = OriginCargo.DestCountry;
            txtHsCodeA.Text = OriginCargo.HsCode;
            cboItemName.Text = OriginCargo.ItemName;
            txtOriginCountryA.Text = OriginCargo.OriginCountry;
            txtWeightA.Text = OriginCargo.WeightKg.ToString();
            txtDeclaredValueA.Text = OriginCargo.DeclaredValue.ToString();
            dtpDeclaredDateA.Value = OriginCargo.DeclaredDate;
            txtUserA.Text = OriginCargo.userID;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
