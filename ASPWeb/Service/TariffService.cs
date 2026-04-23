using ASPWeb.Models;
using ASPWeb.Repositories;

namespace ASPWeb.Service
{
    public class TariffService
    {
        private readonly TariffRateRepository _tariffRateRepository;
        private readonly TariffCalcRepository _tariffCalcRepository;
        private readonly CargoRepository _cargoRepository;

        public TariffService(
            TariffRateRepository tariffRateRepository,
            TariffCalcRepository tariffCalcRepository,
            CargoRepository cargoRepository)
        {
            _tariffRateRepository = tariffRateRepository;
            _tariffCalcRepository = tariffCalcRepository;
            _cargoRepository = cargoRepository;
        }

        // 관세율 전체 조회
        public List<TariffRate> GetAllRates()
        {
            return _tariffRateRepository.GetAll();
        }

        // 관세 계산 + 결과 저장
        // decimal 대신 TariffCalc 객체로 반환
        public TariffCalc CalcAndSave(int cargoId)
        {
            Cargo cargo = _cargoRepository.GetById(cargoId);
            if (cargo == null)
                throw new ArgumentException("해당 화물을 찾을 수 없습니다.");

            TariffRate rate = _tariffRateRepository.GetByHsCode(cargo.HsCode);
            if (rate == null)
                throw new ArgumentException("해당 HS코드의 관세율을 찾을 수 없습니다.");

            decimal tariffAmount = cargo.DeclaredValue * rate.RatePercent / 100;

            TariffCalc calc = new TariffCalc
            {
                CargoId = cargoId,
                DeclaredValue = cargo.DeclaredValue,
                RatePercent = rate.RatePercent,
                TariffAmount = tariffAmount
            };
            _tariffCalcRepository.Insert(calc);

            return calc;  // ← TariffCalc 통째로 반환
        }

        // 화물별 관세 계산 이력 조회
        public List<TariffCalc> GetCalcHistory(int cargoId)
        {
            return _tariffCalcRepository.GetByCargoId(cargoId);
        }
    }
}
