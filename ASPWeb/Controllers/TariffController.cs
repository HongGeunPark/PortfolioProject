using ASPWeb.Models;
using ASPWeb.Service;
using Microsoft.AspNetCore.Mvc;

namespace ASPWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TariffController:ControllerBase
    {
        private readonly TariffService _tariffService;

        public TariffController(TariffService tariffService)
        {
            _tariffService = tariffService;
        }

        // GET api/Tariff/rates
        [HttpGet("rates")]
        public IActionResult GetAllRates()
        {
            var list = _tariffService.GetAllRates();
            return Ok(list);
        }

        // POST api/Tariff/calc/1
        [HttpPost("calc/{cargoId}")]
        public IActionResult CalcAndSave(int cargoId)
        {
            try
            {
                TariffCalc calc = _tariffService.CalcAndSave(cargoId);
                return Ok(new
                {
                    CargoId = cargoId,
                    TariffAmount = calc.TariffAmount,
                    RatePercent = calc.RatePercent,
                    Message = $"관세액: {calc.TariffAmount:N0}원"
                });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/Tariff/history/1
        [HttpGet("history/{cargoId}")]
        public IActionResult GetCalcHistory(int cargoId)
        {
            var list = _tariffService.GetCalcHistory(cargoId);
            return Ok(list);
        }
    }
}
