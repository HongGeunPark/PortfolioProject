using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PortfolioProject
{
    public class DbHelper
    {
        public string Query;
        public DictPara Para = new DictPara();
        public string ErrorMsg;

        private List<string> queryList = new List<string>();
        private List<DictPara> paraList = new List<DictPara>();

        private IDatabase database;
        private string providerName;
        private string connectionString;

        public DbHelper(string name = "")
        {
            string[] connectionInfo = DBValue.GetConnectionInfo(name);

            providerName = connectionInfo[0];
            connectionString = connectionInfo[1];

            switch (providerName)
            {
                case "Oracle":
                    database = new Oracle();
                    break;
                //case "Mssql":
                //    database = new Mssql();
                //    break;
                default:
                    database = null;
                    break;
            }
        }

        public DataTable View(bool showError = true, bool duplicate_column = false)
        {
            Cursor.Current = Cursors.WaitCursor;

            database.Create(connectionString);

            DataTable dt = new DataTable();
            try
            {
                dt = database.View(Query, Para, duplicate_column);
            }
            catch (Exception ex)
            {
                Cursor.Current = Cursors.Default;
                if (showError)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //DebugLog(ex.Message, Query, Para);
            }
            database.Close();

            Cursor.Current = Cursors.Default;

            if (dt.Rows.Count > 0)
            {
                dt.Columns.Add("QUERY");
                dt.Rows[0]["QUERY"] = Query;
            }

            return dt;
        }
    }
}
