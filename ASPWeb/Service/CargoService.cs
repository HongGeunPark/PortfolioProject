using ASPWeb.Models;
using ASPWeb.Repositories;
using Microsoft.Data.SqlClient;

namespace ASPWeb.Service
{
    public class CargoService
    {
        private readonly CargoRepository _cargoRepository;

        public CargoService(CargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        public List<Cargo> GetAll()
        {
            return _cargoRepository.GetAll();
        }

        public Cargo GetById(int cargoId)
        {
            return _cargoRepository.GetById(cargoId);
        }

        public List<Cargo> GetHistoryById(int cargoId)
        {
            return _cargoRepository.GetHistoryById(cargoId);
        }

        public int Insert(Cargo cargo)
        {
            return _cargoRepository.Insert(cargo);
        }

        public int update(Cargo cargo)
        {
            return _cargoRepository.Update(cargo);
        }

        public int UpdateStatus(int cargoId, int status)
        {
            // 상태값 유효성 검사 (0:신고 / 1:심사중 / 2:통관완료)
            if (status < 0 || status > 2)
            {
                throw new ArgumentException("유효하지 않은 상태값입니다.");
            }

            return _cargoRepository.UpdateStatus(cargoId, status);
        }

        public int Delete(int cargoId, string userid)
        {
            return _cargoRepository.Delete(cargoId, userid);
        }

        // 관세 계산 (비즈니스 로직)
        public decimal CalcTariff(decimal declaredValue, decimal ratePercent)
        {
            return declaredValue * ratePercent / 100;
        }
    }
}
