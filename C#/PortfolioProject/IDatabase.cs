using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject
{
    internal interface IDatabase
    {
        void Create(string connectString);

        void Close();

        DataTable View(string query, DictPara para, bool duplicate_column = false);

        int Execute(string query, DictPara para);

        int CallProc(string query, DictPara para);

        void BeginTran();

        void Commit();

        void Rollback();
    }
}
