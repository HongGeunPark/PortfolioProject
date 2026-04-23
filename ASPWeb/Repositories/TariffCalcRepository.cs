using ASPWeb.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Text;

namespace ASPWeb.Repositories
{
    public class TariffCalcRepository
    {
        private readonly string _connectionString;

        public TariffCalcRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        private List<T> ExecuteQuery<T>(string sql, object param = null)
        {
            using (SqlConnection conn = CreateConnection())
            {
                return conn.Query<T>(sql, param).ToList();
            }
        }

        private int ExecuteCommand(string sql, object param = null)
        {
            using (SqlConnection conn = CreateConnection())
            {
                return conn.Execute(sql, param);
            }
        }

        public List<TariffCalc> GetByCargoId(int cargoId)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" SELECT *                  ");
            sb.AppendLine("   FROM customs.TariffCalc ");
            sb.AppendLine("  WHERE CargoId = @CargoId ");
            sb.AppendLine("  ORDER BY CalcDate DESC   ");

            DynamicParameters param = new DynamicParameters();
            param.Add("CargoId", cargoId);

            return ExecuteQuery<TariffCalc>(sb.ToString(), param);
        }

        public int Insert(TariffCalc tariffCalc)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" INSERT INTO customs.TariffCalc ");
            sb.AppendLine("        (CargoId,               ");
            sb.AppendLine("         DeclaredValue,         ");
            sb.AppendLine("         RatePercent,           ");
            sb.AppendLine("         TariffAmount)          ");
            sb.AppendLine(" VALUES                         ");
            sb.AppendLine("        (@CargoId,              ");
            sb.AppendLine("         @DeclaredValue,        ");
            sb.AppendLine("         @RatePercent,          ");
            sb.AppendLine("         @TariffAmount)         ");

            //DynamicParameters param = new DynamicParameters();
            //param.Add("", tariffCalc);

            return ExecuteCommand(sb.ToString(), tariffCalc);
        }
    }
}
