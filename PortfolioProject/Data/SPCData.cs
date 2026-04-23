using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.Data
{
    public class SPCData
    {
        public DataTable selectSPCData(string plant)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select * from dbmgr.spc_chart where plant = :plant");

            DbHelper sql = new DbHelper();
            sql.Query = sb.ToString();
            sql.Para.Add("plant", plant);

            return sql.View();
        }
    }
}
