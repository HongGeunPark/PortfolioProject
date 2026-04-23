using ASPWeb.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Text;

namespace ASPWeb.Repositories
{
    public class TariffRateRepository
    {
        private readonly string _connectionString;

        public TariffRateRepository(string connectionString)
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

        private T ExecuteQueryFirst<T>(string sql, object param = null)
        {
            using (SqlConnection conn = CreateConnection())
            {
                return conn.QueryFirstOrDefault<T>(sql, param);
            }
        }
        public List<TariffRate> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" SELECT *                  ");
            sb.AppendLine("   FROM customs.TariffRate ");

            return ExecuteQuery<TariffRate>(sb.ToString());
        }

        public TariffRate GetByHsCode(string hsCode)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" SELECT *                  ");
            sb.AppendLine("   FROM customs.TariffRate ");
            sb.AppendLine("  WHERE HsCode = @HsCode   ");

            DynamicParameters param = new DynamicParameters();
            param.Add("HsCode", hsCode);

            return ExecuteQueryFirst<TariffRate>(sb.ToString(), param);
        }
    }
}
