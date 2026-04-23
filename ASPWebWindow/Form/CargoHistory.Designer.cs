namespace ASPWebWindow
{
    partial class CargoHistory
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
            gridHistory = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtItemName = new DevExpress.XtraEditors.TextEdit();
            txtCargoNumber = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)gridHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtItemName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCargoNumber.Properties).BeginInit();
            SuspendLayout();
            // 
            // gridHistory
            // 
            gridHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridHistory.Location = new Point(12, 38);
            gridHistory.MainView = gridView1;
            gridHistory.Name = "gridHistory";
            gridHistory.Size = new Size(776, 400);
            gridHistory.TabIndex = 0;
            gridHistory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridHistory;
            gridView1.Name = "gridView1";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Options.UseTextOptions = true;
            labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(191, 12);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(57, 20);
            labelControl2.TabIndex = 13;
            labelControl2.Text = "품명";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(12, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(67, 20);
            labelControl1.TabIndex = 14;
            labelControl1.Text = "신고번호";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(254, 12);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(100, 20);
            txtItemName.TabIndex = 11;
            // 
            // txtCargoNumber
            // 
            txtCargoNumber.Location = new Point(85, 12);
            txtCargoNumber.Name = "txtCargoNumber";
            txtCargoNumber.Size = new Size(100, 20);
            txtCargoNumber.TabIndex = 12;
            // 
            // CargoHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(txtItemName);
            Controls.Add(txtCargoNumber);
            Controls.Add(gridHistory);
            Name = "CargoHistory";
            Text = "CargoHistory";
            ((System.ComponentModel.ISupportInitialize)gridHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtItemName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCargoNumber.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridHistory;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtItemName;
        private DevExpress.XtraEditors.TextEdit txtCargoNumber;
    }
}