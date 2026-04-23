using ASPWeb.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.ObjectPool;
using System.Collections.Generic;
using System.Text;

namespace ASPWeb.Repositories
{
    public class CargoRepository
    {
        private List<string> queryList = new List<string>();
        private List<object> paraList = new List<object>();
        private readonly string _connectionString;

        public CargoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private List<T> ExecuteQuery<T>(string sql, object param = null)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Query<T>(sql, param).ToList();
            }
        }

        private T ExecuteQueryFirst<T>(string sql, object param = null)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                return conn.QueryFirstOrDefault<T>(sql, param);
            }
        }

        private int ExecuteCommand(string sql, object param = null)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                return conn.Execute(sql, param);
            }
        }

        public int ExecuteCommand(List<string> sql, List<object> param = null)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        int result = 0;
                        for (int i = 0; i < sql.Count; i++)
                        {
                            result = conn.Execute(sql[i], param[i], transaction);

                            if (result <= 0) throw new Exception("등록 실패");
                        }
                        
                        // 둘 다 성공하면 커밋
                        transaction.Commit();
                        return 1;
                    }
                    catch
                    {
                        // 하나라도 실패하면 롤백
                        transaction.Rollback();
                        return 0;
                    }
                }
            }
        }

        public List<Cargo> GetAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" SELECT *                   ");
            sb.AppendLine("   FROM customs.CargoStatus ");
            sb.AppendLine("  ORDER BY CreatedAt DESC   ");

            return ExecuteQuery<Cargo>(sb.ToString());
        }

        public Cargo GetById(int cargoId)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" SELECT *                  ");
            sb.AppendLine("   FROM customs.CargoStatus      ");
            sb.AppendLine("  WHERE CargoId = @CargoId ");

            DynamicParameters param = new DynamicParameters();
            param.Add("CargoId", cargoId);

            return ExecuteQueryFirst<Cargo>(sb.ToString(), param);
        }

        public List<Cargo> GetHistoryById(int cargoId)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" SELECT *                    ");
            sb.AppendLine("   FROM customs.CargoHistory ");
            sb.AppendLine("  WHERE CargoId = @CargoId   ");
            sb.AppendLine("  ORDER BY HistSeq DESC      ");

            DynamicParameters param = new DynamicParameters();
            param.Add("CargoId", cargoId);

            return ExecuteQuery<Cargo>(sb.ToString(), param);
        }

        public Cargo GetByNumber(string cargoNumbser)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" SELECT *                  ");
            sb.AppendLine("   FROM customs.CargoStatus      ");
            sb.AppendLine("  WHERE CargoNumbser = @CargoNumbser ");

            DynamicParameters param = new DynamicParameters();
            param.Add("CargoNumbser", cargoNumbser);

            return ExecuteQueryFirst<Cargo>(sb.ToString(), param);
        }

        public int Insert(Cargo cargo)
        {
            StringBuilder sb = new StringBuilder();
            // CargoId가 "IDENTITY"로 정의되어 있어서 CargoId로 인해 OUTPUT 사용
            sb.AppendLine(" INSERT INTO customs.CargoStatus                                          ");
            sb.AppendLine("            (CargoNumber,                                                 ");
            sb.AppendLine("             LastHistSeq,                                                 ");
            sb.AppendLine("             ItemName,                                                    ");
            sb.AppendLine("             HsCode,                                                      ");
            sb.AppendLine("             OriginCountry,                                               ");
            sb.AppendLine("             DestCountry,                                                 ");
            sb.AppendLine("             WeightKg,                                                    ");
            sb.AppendLine("             DeclaredValue,                                               ");
            sb.AppendLine("             Status,                                                      ");
            sb.AppendLine("             UserID,                                                      ");
            sb.AppendLine("             DeclaredDate)                                                ");
            sb.AppendLine("     OUTPUT                                                               ");
            sb.AppendLine("             INSERTED.CargoId,       --방금 생성된 IDENTITY 값            ");
            sb.AppendLine("             INSERTED.CargoNumber,                                        ");
            sb.AppendLine("             1,                      --최초 신청 이력이므로 HistSeq는 1   ");
            sb.AppendLine("             INSERTED.ItemName,                                           ");
            sb.AppendLine("             INSERTED.HsCode,                                             ");
            sb.AppendLine("             INSERTED.OriginCountry,                                      ");
            sb.AppendLine("             INSERTED.DestCountry,                                        ");
            sb.AppendLine("             INSERTED.WeightKg,                                           ");
            sb.AppendLine("             INSERTED.DeclaredValue,                                      ");
            sb.AppendLine("             INSERTED.Status,                                             ");
            sb.AppendLine("             INSERTED.UserID,                                             ");
            sb.AppendLine("             INSERTED.DeclaredDate                                        ");
            sb.AppendLine("     INTO customs.CargoHistory -- 여기로 바로 입력                        ");
            sb.AppendLine("            (CargoId,                                                     ");
            sb.AppendLine("             CargoNumber,                                                 ");
            sb.AppendLine("             HistSeq,                                                     ");
            sb.AppendLine("             ItemName,                                                    ");
            sb.AppendLine("             HsCode,                                                      ");
            sb.AppendLine("             OriginCountry,                                               ");
            sb.AppendLine("             DestCountry,                                                 ");
            sb.AppendLine("             WeightKg,                                                    ");
            sb.AppendLine("             DeclaredValue,                                               ");
            sb.AppendLine("             Status,                                                      ");
            sb.AppendLine("             UserID,                                                      ");
            sb.AppendLine("             DeclaredDate)                                                ");
            sb.AppendLine("     VALUES                                                               ");
            sb.AppendLine("            (@CargoNumber,                                                ");
            sb.AppendLine("             1, --LastHistSeq 초기값                                      ");
            sb.AppendLine("             @ItemName,                                                   ");
            sb.AppendLine("             @HsCode,                                                     ");
            sb.AppendLine("             @OriginCountry,                                              ");
            sb.AppendLine("             @DestCountry,                                                ");
            sb.AppendLine("             @WeightKg,                                                   ");
            sb.AppendLine("             @DeclaredValue,                                              ");
            sb.AppendLine("             @Status,                                                     ");
            sb.AppendLine("             @UserID,                                                     ");
            sb.AppendLine("             @DeclaredDate)                                               ");

            return ExecuteCommand(sb.ToString(), cargo);
        }

        public int Update(Cargo cargo)
        {
            StringBuilder sb = new StringBuilder();
            // CargoId가 "IDENTITY"로 정의되어 있어서 CargoId로 인해 OUTPUT 사용
            sb.AppendLine(" UPDATE customs.CargoStatus                                        ");
            sb.AppendLine("    SET Status = @Status,                                          ");
            sb.AppendLine("        LastHistSeq = LastHistSeq + 1, --이력 번호 증가            ");
            sb.AppendLine("        UserID = @UserID,                                          ");
            sb.AppendLine("        ItemName = @ItemName,                                      ");
            sb.AppendLine("        HsCode = @HsCode,                                          ");
            sb.AppendLine("        OriginCountry = @OriginCountry,                            ");
            sb.AppendLine("        DestCountry = @DestCountry,                                ");
            sb.AppendLine("        WeightKg = @WeightKg,                                      ");
            sb.AppendLine("        DeclaredValue = @DeclaredValue,                            ");
            sb.AppendLine("        DeclaredDate = @DeclaredDate                               ");
            sb.AppendLine(" OUTPUT INSERTED.CargoId,       --메인 테이블의 PK                 ");
            sb.AppendLine("        INSERTED.CargoNumber,                                      ");
            sb.AppendLine("        INSERTED.LastHistSeq,   --방금 증가시킨 이력 번호          ");
            sb.AppendLine("        INSERTED.ItemName,                                         ");
            sb.AppendLine("        INSERTED.HsCode,                                           ");
            sb.AppendLine("        INSERTED.OriginCountry,                                    ");
            sb.AppendLine("        INSERTED.DestCountry,                                      ");
            sb.AppendLine("        INSERTED.WeightKg,                                         ");
            sb.AppendLine("        INSERTED.DeclaredValue,                                    ");
            sb.AppendLine("        INSERTED.Status,        --변경된 새 상태                   ");
            sb.AppendLine("        INSERTED.UserID,        --변경한 사람                      ");
            sb.AppendLine("        INSERTED.DeclaredDate-- 변경된 시간                        ");
            sb.AppendLine("   INTO customs.CargoHistory(CargoId,                              ");
            sb.AppendLine("                             CargoNumber,                          ");
            sb.AppendLine("                             HistSeq,                              ");
            sb.AppendLine("                             ItemName,                             ");
            sb.AppendLine("                             HsCode,                               ");
            sb.AppendLine("                             OriginCountry,                        ");
            sb.AppendLine("                             DestCountry,                          ");
            sb.AppendLine("                             WeightKg,                             ");
            sb.AppendLine("                             DeclaredValue,                        ");
            sb.AppendLine("                             Status,                               ");
            sb.AppendLine("                             UserID,                               ");
            sb.AppendLine("                             DeclaredDate)                         ");
            sb.AppendLine("  WHERE CargoId = @CargoId --특정 화물만 업데이트                  ");

            return ExecuteCommand(sb.ToString(), cargo);
        }

        public int UpdateStatus(int cargoId, int status)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" UPDATE customs.CargoStatus ");
            sb.AppendLine("    SET Status = @Status    ");
            sb.AppendLine("  WHERE CargoId = @CargoId  ");

            DynamicParameters param = new DynamicParameters();
            param.Add("CargoId", cargoId);
            param.Add("Status", status);

            return ExecuteCommand(sb.ToString(), param);
        }

        public int Delete(int cargoId, string userid)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" DELETE FROM customs.CargoStatus                        ");
            sb.AppendLine(" OUTPUT DELETED.CargoId,                                ");
            sb.AppendLine("        DELETED.CargoNumber,                            ");
            sb.AppendLine("        DELETED.LastHistSeq + 1, --이력 번호 하나 증가  ");
            sb.AppendLine("        DELETED.ItemName,                               ");
            sb.AppendLine("        DELETED.HsCode,                                 ");
            sb.AppendLine("        DELETED.OriginCountry,                          ");
            sb.AppendLine("        DELETED.DestCountry,                            ");
            sb.AppendLine("        DELETED.WeightKg,                               ");
            sb.AppendLine("        DELETED.DeclaredValue,                          ");
            sb.AppendLine("        '99',                    --상태를 '삭제'로 기록 ");
            sb.AppendLine("        @UserID,                 --삭제한 사람          ");
            sb.AppendLine("        GETDATE()-- 삭제 시간                           ");
            sb.AppendLine("   INTO customs.CargoHistory(CargoId,                   ");
            sb.AppendLine("                             CargoNumber,               ");
            sb.AppendLine("                             HistSeq,                   ");
            sb.AppendLine("                             ItemName,                  ");
            sb.AppendLine("                             HsCode,                    ");
            sb.AppendLine("                             OriginCountry,             ");
            sb.AppendLine("                             DestCountry,               ");
            sb.AppendLine("                             WeightKg,                  ");
            sb.AppendLine("                             DeclaredValue,             ");
            sb.AppendLine("                             Status,                    ");
            sb.AppendLine("                             UserID,                    ");
            sb.AppendLine("                             DeclaredDate)              ");
            sb.AppendLine("  WHERE CargoId = @CargoId                              ");

            DynamicParameters param = new DynamicParameters();
            param.Add("CargoId", cargoId);
            param.Add("userid", userid);

            return ExecuteCommand(sb.ToString(), param);
        }
    }
}
