using ASPWeb.Models;
using ASPWeb.Service;
using Microsoft.AspNetCore.Mvc;

namespace ASPWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CargoController : ControllerBase
    {
        private readonly CargoService _cargoService;

        public CargoController(CargoService cargoService)
        {
            _cargoService = cargoService;
        }

        // GET api/cargo
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Cargo> cargoList = _cargoService.GetAll();
            return Ok(cargoList);
        }

        // GET api/cargo/1
        [HttpGet("{cargoId}")]
        public IActionResult GetById(int cargoId)
        {
            Cargo cargo = _cargoService.GetById(cargoId);
            if (cargo == null)
            {
                return NotFound("해당 화물을 찾을 수 없습니다.");
            }
            return Ok(cargo);
        }

        [HttpGet("{cargoId}/history")]
        public IActionResult GetHistoryById(int cargoId)
        {
            List<Cargo> cargoList = _cargoService.GetHistoryById(cargoId);
            return Ok(cargoList);
        }

        // POST api/cargo
        [HttpPost]
        public IActionResult Insert([FromBody] Cargo cargo)
        {
            try
            {
                int result = _cargoService.Insert(cargo);

                if (result > 0)
                    return Ok("화물 정보가 등록되었습니다.");

                return BadRequest("화물 정보 등록에 실패했습니다.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/cargo
        [HttpPut("{cargoId}")]
        public IActionResult Update(int cargoId, [FromBody] Cargo cargo)
        {
            try
            {
                int result = _cargoService.update(cargo);
                if (result > 0)
                {
                    return Ok("상태가 변경되었습니다.");
                }
                return NotFound("해당 화물을 찾을 수 없습니다.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/cargo/1
        [HttpDelete("{cargoId}/{userid}")]
        public IActionResult Delete(int cargoId, string userid)
        {
            int result = _cargoService.Delete(cargoId, userid);
            if (result > 0)
            {
                return Ok("화물이 삭제되었습니다.");
            }
            return NotFound("해당 화물을 찾을 수 없습니다.");
        }
    }
}
