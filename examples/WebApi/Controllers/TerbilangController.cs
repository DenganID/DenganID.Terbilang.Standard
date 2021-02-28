using System.Threading.Tasks;
using DenganID.Terbilang.Standard;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TerbilangController : ControllerBase
    {
        private readonly ITerbilang _terbilang;
        public TerbilangController(ITerbilang terbilang)
        {
            _terbilang = terbilang;
        }

        [HttpGet("{number}")]
        public IActionResult GetTerbilang(long number)
        {
            var hasil = _terbilang.From(number);
            return Ok(hasil);
        }
        
        [HttpGet("withAsync/{number}")]
        public async Task<IActionResult> GetTerbilangAsync(long number)
        {
            var hasil = await _terbilang.FromAsync(number);
            return Ok(hasil);
        }
    }
}