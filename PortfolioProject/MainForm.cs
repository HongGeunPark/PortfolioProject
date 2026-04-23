using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            initEvent();
        }

        void initEvent()
        {
            this.Load += MainForm_Load;
            btnSpcChart.Click += BtnSpcChart_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSpcChart_Click(object sender, EventArgs e)
        {
            SPCChart spcChart = new SPCChart();
            spcChart.Show();
        }
    }
}
