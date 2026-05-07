using PortfolioProject.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PortfolioProject
{
    public partial class SPCChart : UserControl
    {
        Series mainSeries = new Series();
        Series subSeries = new Series();

        List<string> days = new List<string>();

        SPCData spcData = new SPCData();
        
        public SPCChart()
        {
            InitializeComponent();
            initEvent();
        }

        private void initEvent()
        {
            this.Load += SPCChart_Load;
            btnSearch.Click += BtnSearch_Click;
        }

        private void SPCChart_Load(object sender, EventArgs e)
        {
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpTo.Format = DateTimePickerFormat.Short;

            // 날짜 초기화
            dtpTo.Value = DateTime.Now;
            dtpFrom.Value = DateTime.Now.AddDays(-30);

            // 조회 조건문 셋팅
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            getDays();
            setMainChart();
        }

        private void getDays()
        {
            for (DateTime date = dtpFrom.Value; date <= dtpTo.Value; date = date.AddDays(1))
            {
                days.Add(date.ToString("yyyyMMdd"));
            }
        }

        private void setMainChart()
        {
            DataTable dt = spcData.selectSPCData("PLANT1");

            mainSeries.Points.Clear();
            bool isOK = false;
            for (int i = 0; i < days.Count; i++)
            {
                isOK = false;

                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (days[i].Equals(dt.Rows[j]["trnstime"].ToString()))
                    {
                        mainSeries.Points.AddXY(i + 1, days[i]);
                        isOK = true;
                        break;
                    }
                }

                if (isOK) 
                {
                    mainSeries.Points.AddXY(i + 1, "");
                }
            }
        }

        private void setSubChart()
        {
            subSeries.Points.Clear();

            int days = (dtpFrom.Value - dtpTo.Value).Days;

            for (int i = 0; i < days; i++)
            {

            }
        }

        private void Clear()
        {
            dtpTo.Value = DateTime.Now;
            dtpFrom.Value = DateTime.Now.AddDays(-30);
        }
    }
}
