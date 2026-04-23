using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace PortfolioProject
{
    public class Oracle : IDatabase
    {
        private OracleConnection connect;
        private OracleCommand command;

        public void Create(string connectString)
        {
            connect = new OracleConnection();
            connect.ConnectionString = connectString;
            connect.Open();

            OracleGlobalization sessionInfo = connect.GetSessionInfo();

            command = connect.CreateCommand();
        }

        public void Close()
        {
            connect.Close();
        }
        public DataTable View(string query, DictPara para, bool duplicate_column = false)
        {
            command.CommandText = query;
            command.BindByName = true;
            command.Parameters.Clear();
            foreach (DictParaTag kvp in para)
            {
                command.Parameters.Add(kvp.key, kvp.value);
            }

            OracleDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            if (duplicate_column)
            {
                dt.Load(reader);
            }
            else
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                }
                while (reader.Read())
                {
                    object[] objs = new object[reader.FieldCount];
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        objs[i] = reader.GetValue(i);
                    }
                    dt.Rows.Add(objs);
                }
            }

            return dt;
        }

        public int Execute(string query, DictPara para)
        {
            command.CommandText = query;
            command.BindByName = true;
            command.Parameters.Clear();

            foreach (DictParaTag kvp in para)
            {
                command.Parameters.Add(kvp.key, kvp.value);
            }

            int rowcount = command.ExecuteNonQuery();

            return rowcount;
        }

        public int CallProc(string query, DictPara para)
        {
            command.CommandText = query;
            command.CommandType = CommandType.StoredProcedure;
            command.BindByName = true;
            command.Parameters.Clear();

            foreach (DictParaTag kvp in para)
            {
                command.Parameters.Add(kvp.key, kvp.value);

                if (kvp.output == true)
                {
                    command.Parameters[kvp.key].Direction = ParameterDirection.Output;
                }
                if (kvp.size > 0)
                {
                    command.Parameters[kvp.key].Size = kvp.size;
                }
            }

            int rowcount = command.ExecuteNonQuery();

            for (int i = 0; i < para.Count; i++)
            {
                DictParaTag kvp = para[i] as DictParaTag;
                kvp.value = command.Parameters[kvp.key].Value;
            }
            return rowcount;
        }

        public void BeginTran()
        {
            command.Transaction = connect.BeginTransaction();
        }

        public void Commit()
        {
            command.Transaction.Commit();
        }

        public void Rollback()
        {
            command.Transaction.Rollback();
        }
    }
}
