namespace ASPWebWindow
{
    partial class CargoAdd
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            txtCargoNumber = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            txtHsCode = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            txtOriginCountry = new DevExpress.XtraEditors.TextEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            txtWeight = new DevExpress.XtraEditors.TextEdit();
            txtDeclaredValue = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl8 = new DevExpress.XtraEditors.LabelControl();
            btnSave = new DevExpress.XtraEditors.SimpleButton();
            btnCancel = new DevExpress.XtraEditors.SimpleButton();
            dtpDeclaredDate = new DateTimePicker();
            btnClear = new DevExpress.XtraEditors.SimpleButton();
            txtUser = new DevExpress.XtraEditors.TextEdit();
            labelControl9 = new DevExpress.XtraEditors.LabelControl();
            cboItemName = new DevExpress.XtraEditors.GridLookUpEdit();
            gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            txtDestCountry = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)txtCargoNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHsCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOriginCountry.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtWeight.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDeclaredValue.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUser.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboItemName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDestCountry.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtCargoNumber
            // 
            txtCargoNumber.Location = new Point(92, 25);
            txtCargoNumber.Name = "txtCargoNumber";
            txtCargoNumber.Size = new Size(100, 20);
            txtCargoNumber.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(19, 25);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(67, 20);
            labelControl1.TabIndex = 2;
            labelControl1.Text = "신고번호";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(198, 25);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(57, 20);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "품명";
            // 
            // txtHsCode
            // 
            txtHsCode.Location = new Point(261, 51);
            txtHsCode.Name = "txtHsCode";
            txtHsCode.Properties.ReadOnly = true;
            txtHsCode.Size = new Size(100, 20);
            txtHsCode.TabIndex = 1;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.Location = new Point(198, 51);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(57, 20);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "HS코드";
            // 
            // txtOriginCountry
            // 
            txtOriginCountry.Location = new Point(92, 77);
            txtOriginCountry.Name = "txtOriginCountry";
            txtOriginCountry.Size = new Size(100, 20);
            txtOriginCountry.TabIndex = 1;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Options.UseTextOptions = true;
            labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl4.Location = new Point(19, 77);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(67, 20);
            labelControl4.TabIndex = 2;
            labelControl4.Text = "수출국";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(92, 103);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 20);
            txtWeight.TabIndex = 1;
            // 
            // txtDeclaredValue
            // 
            txtDeclaredValue.Location = new Point(92, 130);
            txtDeclaredValue.Name = "txtDeclaredValue";
            txtDeclaredValue.Size = new Size(100, 20);
            txtDeclaredValue.TabIndex = 1;
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Options.UseTextOptions = true;
            labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl5.Location = new Point(29, 51);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(57, 20);
            labelControl5.TabIndex = 2;
            labelControl5.Text = "수입국";
            // 
            // labelControl6
            // 
            labelControl6.Appearance.Options.UseTextOptions = true;
            labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl6.Location = new Point(19, 103);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(67, 20);
            labelControl6.TabIndex = 2;
            labelControl6.Text = "중량(kg)";
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Options.UseTextOptions = true;
            labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl7.Location = new Point(19, 130);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(67, 20);
            labelControl7.TabIndex = 2;
            labelControl7.Text = "신고가격";
            // 
            // labelControl8
            // 
            labelControl8.Appearance.Options.UseTextOptions = true;
            labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl8.Location = new Point(198, 130);
            labelControl8.Name = "labelControl8";
            labelControl8.Size = new Size(57, 20);
            labelControl8.TabIndex = 2;
            labelControl8.Text = "신고일자";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(146, 182);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "저장";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(308, 182);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "취소";
            // 
            // dtpDeclaredDate
            // 
            dtpDeclaredDate.Location = new Point(261, 129);
            dtpDeclaredDate.Name = "dtpDeclaredDate";
            dtpDeclaredDate.Size = new Size(122, 23);
            dtpDeclaredDate.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.Location = new Point(227, 182);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "초기화";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(92, 156);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 20);
            txtUser.TabIndex = 1;
            // 
            // labelControl9
            // 
            labelControl9.Appearance.Options.UseTextOptions = true;
            labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl9.Location = new Point(29, 156);
            labelControl9.Name = "labelControl9";
            labelControl9.Size = new Size(57, 20);
            labelControl9.TabIndex = 2;
            labelControl9.Text = "신고인";
            // 
            // cboItemName
            // 
            cboItemName.Location = new Point(261, 25);
            cboItemName.Name = "cboItemName";
            cboItemName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboItemName.Properties.PopupView = gridLookUpEdit1View;
            cboItemName.Size = new Size(100, 20);
            cboItemName.TabIndex = 8;
            // 
            // gridLookUpEdit1View
            // 
            gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtDestCountry
            // 
            txtDestCountry.Location = new Point(92, 51);
            txtDestCountry.Name = "txtDestCountry";
            txtDestCountry.Size = new Size(100, 20);
            txtDestCountry.TabIndex = 1;
            // 
            // CargoAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 217);
            Controls.Add(cboItemName);
            Controls.Add(dtpDeclaredDate);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(labelControl8);
            Controls.Add(labelControl4);
            Controls.Add(labelControl7);
            Controls.Add(labelControl3);
            Controls.Add(labelControl6);
            Controls.Add(labelControl2);
            Controls.Add(labelControl9);
            Controls.Add(labelControl5);
            Controls.Add(labelControl1);
            Controls.Add(txtDestCountry);
            Controls.Add(txtOriginCountry);
            Controls.Add(txtDeclaredValue);
            Controls.Add(txtHsCode);
            Controls.Add(txtWeight);
            Controls.Add(txtUser);
            Controls.Add(txtCargoNumber);
            Name = "CargoAdd";
            Text = "수입 신고";
            ((System.ComponentModel.ISupportInitialize)txtCargoNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHsCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOriginCountry.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtWeight.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDeclaredValue.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUser.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboItemName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridLookUpEdit1View).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDestCountry.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCargoNumber;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHsCode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtOriginCountry;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtWeight;
        private DevExpress.XtraEditors.TextEdit txtDeclaredValue;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DateTimePicker dtpDeclaredDate;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GridLookUpEdit cboItemName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtDestCountry;
    }
}
