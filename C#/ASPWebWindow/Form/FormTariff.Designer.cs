namespace ASPWebWindow
{
    partial class FormTariff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelControl7 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtDeclaredValue = new DevExpress.XtraEditors.TextEdit();
            txtHsCode = new DevExpress.XtraEditors.TextEdit();
            txtItemName = new DevExpress.XtraEditors.TextEdit();
            txtCargoNumber = new DevExpress.XtraEditors.TextEdit();
            txtRatePercent = new DevExpress.XtraEditors.TextEdit();
            lblRatePercent = new DevExpress.XtraEditors.LabelControl();
            txtTariffAmount = new DevExpress.XtraEditors.TextEdit();
            lblTariffAmount = new DevExpress.XtraEditors.LabelControl();
            btnCalc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtDeclaredValue.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHsCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItemName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCargoNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRatePercent.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTariffAmount.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl7
            // 
            labelControl7.Appearance.Options.UseTextOptions = true;
            labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl7.Location = new Point(16, 90);
            labelControl7.Name = "labelControl7";
            labelControl7.Size = new Size(67, 20);
            labelControl7.TabIndex = 7;
            labelControl7.Text = "신고가격";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.Location = new Point(16, 64);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(67, 20);
            labelControl3.TabIndex = 8;
            labelControl3.Text = "HS코드";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(26, 38);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(57, 20);
            labelControl2.TabIndex = 9;
            labelControl2.Text = "품명";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(16, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(67, 20);
            labelControl1.TabIndex = 10;
            labelControl1.Text = "화물번호";
            // 
            // txtDeclaredValue
            // 
            txtDeclaredValue.Location = new Point(89, 90);
            txtDeclaredValue.Name = "txtDeclaredValue";
            txtDeclaredValue.Size = new Size(100, 20);
            txtDeclaredValue.TabIndex = 3;
            // 
            // txtHsCode
            // 
            txtHsCode.Location = new Point(89, 64);
            txtHsCode.Name = "txtHsCode";
            txtHsCode.Size = new Size(100, 20);
            txtHsCode.TabIndex = 4;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(89, 38);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(100, 20);
            txtItemName.TabIndex = 5;
            // 
            // txtCargoNumber
            // 
            txtCargoNumber.Location = new Point(89, 12);
            txtCargoNumber.Name = "txtCargoNumber";
            txtCargoNumber.Size = new Size(100, 20);
            txtCargoNumber.TabIndex = 6;
            // 
            // txtRatePercent
            // 
            txtRatePercent.Location = new Point(89, 116);
            txtRatePercent.Name = "txtRatePercent";
            txtRatePercent.Size = new Size(100, 20);
            txtRatePercent.TabIndex = 3;
            // 
            // lblRatePercent
            // 
            lblRatePercent.Appearance.Options.UseTextOptions = true;
            lblRatePercent.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            lblRatePercent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblRatePercent.Location = new Point(16, 116);
            lblRatePercent.Name = "lblRatePercent";
            lblRatePercent.Size = new Size(67, 20);
            lblRatePercent.TabIndex = 7;
            lblRatePercent.Text = "관세율";
            // 
            // txtTariffAmount
            // 
            txtTariffAmount.Location = new Point(89, 142);
            txtTariffAmount.Name = "txtTariffAmount";
            txtTariffAmount.Size = new Size(100, 20);
            txtTariffAmount.TabIndex = 3;
            // 
            // lblTariffAmount
            // 
            lblTariffAmount.Appearance.Options.UseTextOptions = true;
            lblTariffAmount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            lblTariffAmount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lblTariffAmount.Location = new Point(16, 142);
            lblTariffAmount.Name = "lblTariffAmount";
            lblTariffAmount.Size = new Size(67, 20);
            lblTariffAmount.TabIndex = 7;
            lblTariffAmount.Text = "관세액";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(195, 142);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 20);
            btnCalc.TabIndex = 11;
            btnCalc.Text = "저장";
            // 
            // FormTariff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 184);
            Controls.Add(btnCalc);
            Controls.Add(lblTariffAmount);
            Controls.Add(lblRatePercent);
            Controls.Add(labelControl7);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(txtTariffAmount);
            Controls.Add(txtRatePercent);
            Controls.Add(txtDeclaredValue);
            Controls.Add(txtHsCode);
            Controls.Add(txtItemName);
            Controls.Add(txtCargoNumber);
            Name = "FormTariff";
            Text = "FormTariff";
            ((System.ComponentModel.ISupportInitialize)txtDeclaredValue.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHsCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItemName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCargoNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRatePercent.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTariffAmount.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDeclaredValue;
        private DevExpress.XtraEditors.TextEdit txtHsCode;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.TextEdit txtCargoNumber;
        private DevExpress.XtraEditors.TextEdit txtRatePercent;
        private DevExpress.XtraEditors.LabelControl lblRatePercent;
        private DevExpress.XtraEditors.TextEdit txtTariffAmount;
        private DevExpress.XtraEditors.LabelControl lblTariffAmount;
        private DevExpress.XtraEditors.SimpleButton btnCalc;
    }
}