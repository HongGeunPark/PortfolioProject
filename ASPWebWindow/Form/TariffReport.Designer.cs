namespace ASPWebWindow
{
    partial class TariffReport
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TariffReport));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.txtCalcDate = new DevExpress.XtraReports.UI.XRRichText();
            this.txtTariffAmount = new DevExpress.XtraReports.UI.XRRichText();
            this.txtRatePercent = new DevExpress.XtraReports.UI.XRRichText();
            this.txtDeclaredValue = new DevExpress.XtraReports.UI.XRRichText();
            this.txtOriginCountry = new DevExpress.XtraReports.UI.XRRichText();
            this.txtHsCode = new DevExpress.XtraReports.UI.XRRichText();
            this.txtItemName = new DevExpress.XtraReports.UI.XRRichText();
            this.txtCargoNumber = new DevExpress.XtraReports.UI.XRRichText();
            this.lblCalcDate = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTariffAmount = new DevExpress.XtraReports.UI.XRLabel();
            this.lblOriginCountry = new DevExpress.XtraReports.UI.XRLabel();
            this.lblDeclaredValue = new DevExpress.XtraReports.UI.XRLabel();
            this.lblRatePercent = new DevExpress.XtraReports.UI.XRLabel();
            this.lblHsCode = new DevExpress.XtraReports.UI.XRLabel();
            this.lblItemName = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCargoNumber = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this.txtCalcDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTariffAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRatePercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeclaredValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOriginCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHsCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargoNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(204.1667F, 23.91666F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(225F, 23F);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "수출입 통관 예상 세액 계산서";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrLine1,
            this.txtCalcDate,
            this.txtTariffAmount,
            this.txtRatePercent,
            this.txtDeclaredValue,
            this.txtOriginCountry,
            this.txtHsCode,
            this.txtItemName,
            this.txtCargoNumber,
            this.lblCalcDate,
            this.lblTariffAmount,
            this.lblOriginCountry,
            this.lblDeclaredValue,
            this.lblRatePercent,
            this.lblHsCode,
            this.lblItemName,
            this.lblCargoNumber});
            this.detailBand1.HeightF = 317.7083F;
            this.detailBand1.Name = "detailBand1";
            // 
            // txtCalcDate
            // 
            this.txtCalcDate.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.txtCalcDate.LocationFloat = new DevExpress.Utils.PointFloat(127.0833F, 268.6667F);
            this.txtCalcDate.Name = "txtCalcDate";
            this.txtCalcDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.txtCalcDate.SerializableRtfString = resources.GetString("txtCalcDate.SerializableRtfString");
            this.txtCalcDate.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            // 
            // txtTariffAmount
            // 
            this.txtTariffAmount.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.txtTariffAmount.LocationFloat = new DevExpress.Utils.PointFloat(127.0833F, 235F);
            this.txtTariffAmount.Name = "txtTariffAmount";
            this.txtTariffAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.txtTariffAmount.SerializableRtfString = resources.GetString("txtTariffAmount.SerializableRtfString");
            this.txtTariffAmount.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            // 
            // txtRatePercent
            // 
            this.txtRatePercent.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.txtRatePercent.LocationFloat = new DevExpress.Utils.PointFloat(127.0833F, 178.0417F);
            this.txtRatePercent.Name = "txtRatePercent";
            this.txtRatePercent.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.txtRatePercent.SerializableRtfString = resources.GetString("txtRatePercent.SerializableRtfString");
            this.txtRatePercent.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            // 
            // txtDeclaredValue
            // 
            this.txtDeclaredValue.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.txtDeclaredValue.LocationFloat = new DevExpress.Utils.PointFloat(127.0833F, 144.375F);
            this.txtDeclaredValue.Name = "txtDeclaredValue";
            this.txtDeclaredValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.txtDeclaredValue.SerializableRtfString = resources.GetString("txtDeclaredValue.SerializableRtfString");
            this.txtDeclaredValue.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            // 
            // txtOriginCountry
            // 
            this.txtOriginCountry.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.txtOriginCountry.LocationFloat = new DevExpress.Utils.PointFloat(127.0833F, 111.0417F);
            this.txtOriginCountry.Name = "txtOriginCountry";
            this.txtOriginCountry.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.txtOriginCountry.SerializableRtfString = resources.GetString("txtOriginCountry.SerializableRtfString");
            this.txtOriginCountry.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            // 
            // txtHsCode
            // 
            this.txtHsCode.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.txtHsCode.LocationFloat = new DevExpress.Utils.PointFloat(127.0833F, 76.99998F);
            this.txtHsCode.Name = "txtHsCode";
            this.txtHsCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.txtHsCode.SerializableRtfString = resources.GetString("txtHsCode.SerializableRtfString");
            this.txtHsCode.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.txtItemName.LocationFloat = new DevExpress.Utils.PointFloat(127.0833F, 43.33334F);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.txtItemName.SerializableRtfString = resources.GetString("txtItemName.SerializableRtfString");
            this.txtItemName.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            // 
            // txtCargoNumber
            // 
            this.txtCargoNumber.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.txtCargoNumber.LocationFloat = new DevExpress.Utils.PointFloat(127.0833F, 10.00001F);
            this.txtCargoNumber.Name = "txtCargoNumber";
            this.txtCargoNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.txtCargoNumber.SerializableRtfString = resources.GetString("txtCargoNumber.SerializableRtfString");
            this.txtCargoNumber.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            // 
            // lblCalcDate
            // 
            this.lblCalcDate.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 268.6667F);
            this.lblCalcDate.Multiline = true;
            this.lblCalcDate.Name = "lblCalcDate";
            this.lblCalcDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.lblCalcDate.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblCalcDate.StylePriority.UseTextAlignment = false;
            this.lblCalcDate.Text = "계산일시";
            this.lblCalcDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblTariffAmount
            // 
            this.lblTariffAmount.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 235F);
            this.lblTariffAmount.Multiline = true;
            this.lblTariffAmount.Name = "lblTariffAmount";
            this.lblTariffAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.lblTariffAmount.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblTariffAmount.StylePriority.UseTextAlignment = false;
            this.lblTariffAmount.Text = "예상 관세액";
            this.lblTariffAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblOriginCountry
            // 
            this.lblOriginCountry.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 111.0417F);
            this.lblOriginCountry.Multiline = true;
            this.lblOriginCountry.Name = "lblOriginCountry";
            this.lblOriginCountry.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.lblOriginCountry.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblOriginCountry.StylePriority.UseTextAlignment = false;
            this.lblOriginCountry.Text = "지원산";
            this.lblOriginCountry.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblDeclaredValue
            // 
            this.lblDeclaredValue.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 144.375F);
            this.lblDeclaredValue.Multiline = true;
            this.lblDeclaredValue.Name = "lblDeclaredValue";
            this.lblDeclaredValue.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.lblDeclaredValue.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblDeclaredValue.StylePriority.UseTextAlignment = false;
            this.lblDeclaredValue.Text = "신고 가격";
            this.lblDeclaredValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblRatePercent
            // 
            this.lblRatePercent.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 178.0417F);
            this.lblRatePercent.Multiline = true;
            this.lblRatePercent.Name = "lblRatePercent";
            this.lblRatePercent.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.lblRatePercent.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblRatePercent.StylePriority.UseTextAlignment = false;
            this.lblRatePercent.Text = "관세율";
            this.lblRatePercent.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblHsCode
            // 
            this.lblHsCode.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 76.99998F);
            this.lblHsCode.Multiline = true;
            this.lblHsCode.Name = "lblHsCode";
            this.lblHsCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.lblHsCode.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblHsCode.StylePriority.UseTextAlignment = false;
            this.lblHsCode.Text = "HS 코드";
            this.lblHsCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblItemName
            // 
            this.lblItemName.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 43.33334F);
            this.lblItemName.Multiline = true;
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.lblItemName.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblItemName.StylePriority.UseTextAlignment = false;
            this.lblItemName.Text = "품명";
            this.lblItemName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblCargoNumber
            // 
            this.lblCargoNumber.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.lblCargoNumber.Multiline = true;
            this.lblCargoNumber.Name = "lblCargoNumber";
            this.lblCargoNumber.Padding = new DevExpress.XtraPrinting.PaddingInfo(2F, 2F, 0F, 0F, 100F);
            this.lblCargoNumber.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblCargoNumber.StylePriority.UseTextAlignment = false;
            this.lblCargoNumber.Text = "화물번호";
            this.lblCargoNumber.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 218.75F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(300F, 2F);
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(300F, 2F);
            // 
            // TariffReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.detailBand1});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Version = "25.2";
            ((System.ComponentModel.ISupportInitialize)(this.txtCalcDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTariffAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRatePercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeclaredValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOriginCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHsCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCargoNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRRichText txtCalcDate;
        private DevExpress.XtraReports.UI.XRRichText txtTariffAmount;
        private DevExpress.XtraReports.UI.XRRichText txtRatePercent;
        private DevExpress.XtraReports.UI.XRRichText txtDeclaredValue;
        private DevExpress.XtraReports.UI.XRRichText txtOriginCountry;
        private DevExpress.XtraReports.UI.XRRichText txtHsCode;
        private DevExpress.XtraReports.UI.XRRichText txtItemName;
        private DevExpress.XtraReports.UI.XRRichText txtCargoNumber;
        private DevExpress.XtraReports.UI.XRLabel lblCalcDate;
        private DevExpress.XtraReports.UI.XRLabel lblTariffAmount;
        private DevExpress.XtraReports.UI.XRLabel lblOriginCountry;
        private DevExpress.XtraReports.UI.XRLabel lblDeclaredValue;
        private DevExpress.XtraReports.UI.XRLabel lblRatePercent;
        private DevExpress.XtraReports.UI.XRLabel lblHsCode;
        private DevExpress.XtraReports.UI.XRLabel lblItemName;
        private DevExpress.XtraReports.UI.XRLabel lblCargoNumber;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
    }
}
