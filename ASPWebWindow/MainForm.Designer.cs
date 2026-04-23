namespace ASPWebWindow
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSearch = new Button();
            btnAdd = new Button();
            btnChange = new Button();
            btnDelete = new Button();
            label1 = new Label();
            gridMain = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            btnTariff = new Button();
            ((System.ComponentModel.ISupportInitialize)gridMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 77);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 50);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "조회";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(118, 77);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "신고 접수";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(224, 77);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(100, 50);
            btnChange.TabIndex = 0;
            btnChange.Text = "신고 수정";
            btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(330, 77);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 50);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "신고 취소";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(431, 50);
            label1.TabIndex = 1;
            label1.Text = "수출입 화물 관리 시스템";
            // 
            // gridMain
            // 
            gridMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridMain.Location = new Point(12, 133);
            gridMain.MainView = gridView1;
            gridMain.Name = "gridMain";
            gridMain.Size = new Size(776, 305);
            gridMain.TabIndex = 2;
            gridMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridMain;
            gridView1.Name = "gridView1";
            // 
            // btnTariff
            // 
            btnTariff.Location = new Point(688, 77);
            btnTariff.Name = "btnTariff";
            btnTariff.Size = new Size(100, 50);
            btnTariff.TabIndex = 0;
            btnTariff.Text = "세금계산";
            btnTariff.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridMain);
            Controls.Add(label1);
            Controls.Add(btnTariff);
            Controls.Add(btnDelete);
            Controls.Add(btnChange);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Name = "MainForm";
            Text = "수출입 화물 관리 시스템";
            ((System.ComponentModel.ISupportInitialize)gridMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Button btnAdd;
        private Button btnChange;
        private Button btnDelete;
        private Label label1;
        private DevExpress.XtraGrid.GridControl gridMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private Button btnTariff;
    }
}
