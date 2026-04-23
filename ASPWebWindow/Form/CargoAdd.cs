using ASPWebWindow.Models;
using ASPWebWindow.Services;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace ASPWebWindow
{
    public partial class CargoAdd : Form
    {
        private CargoApiClient cargoApiClient = new CargoApiClient();
        private TariffApiClient tariffApiClient = new TariffApiClient();

        public CargoAdd()
        {
            InitializeComponent();
            InitEvent();
        }

        private void InitEvent()
        {
            this.Load += CargoAdd_Load;
            btnSave.Click += BtnSave_Click;
            btnClear.Click += BtnClear_Click;
            btnCancel.Click += BtnCancel_Click;

            cboItemName.EditValueChanged += CboItemName_EditValueChanged;
        }

        private void CargoAdd_Load(object? sender, EventArgs e)
        {
            SetItemName();
        }

        private void CboItemName_EditValueChanged(object? sender, EventArgs e)
        {
            if (cboItemName.EditValue != null)
            {                
                TariffRate selectedRow = cboItemName.Properties.GetRowByKeyValue(cboItemName.EditValue) as TariffRate;

                if(selectedRow != null)
                    txtHsCode.Text = selectedRow.HsCode;
                else
                    txtHsCode.Text = string.Empty;
            }
            else
                txtHsCode.Text = string.Empty;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Cargo cargo = new Cargo();            
            cargo.CargoNumber = txtCargoNumber.Text;
            cargo.ItemName = txtDestCountry.Text;
            cargo.HsCode = txtHsCode.Text;
            cargo.OriginCountry = txtOriginCountry.Text;
            cargo.DestCountry = txtDestCountry.Text;
            cargo.WeightKg = Convert.ToDecimal(txtWeight.Text);
            cargo.userID = txtUser.Text;
            cargo.DeclaredValue = Convert.ToInt32(txtDeclaredValue.Text);
            cargo.DeclaredDate = dtpDeclaredDate.Value;

            if(cargoApiClient.ExecuteDML(cargo, "I"))
            {
                MessageBox.Show("저장에 성공 했습니다.");

                this.Close();
            }
            else
            {
                MessageBox.Show("저장에 실패 했습니다.");
            }
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtCargoNumber.Text = string.Empty;
            txtDeclaredValue.Text = string.Empty;
            txtDestCountry.Text = string.Empty;
            txtDestCountry.Text = string.Empty;
            txtOriginCountry.Text = string.Empty;
            txtWeight.Text = string.Empty;
            dtpDeclaredDate.Value = DateTime.Now;
            txtUser.Text = string.Empty;

            SetItemName();
            txtHsCode.Text = string.Empty;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
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
    }
}
