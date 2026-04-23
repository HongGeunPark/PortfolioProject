namespace PortfolioProject
{
    partial class MainForm
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
            this.btnSpcChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpcChart
            // 
            this.btnSpcChart.Location = new System.Drawing.Point(81, 55);
            this.btnSpcChart.Name = "btnSpcChart";
            this.btnSpcChart.Size = new System.Drawing.Size(243, 140);
            this.btnSpcChart.TabIndex = 0;
            this.btnSpcChart.Text = "SPC Chart";
            this.btnSpcChart.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSpcChart);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpcChart;
    }
}