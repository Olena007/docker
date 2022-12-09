using Application.Interfaces;
using Domen.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApi.Dto;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
   // [Authorize(Roles = "Admin")]
    public class TransportController : Controller
    {
        private readonly ITransportProvider _provider;

        public TransportController(ITransportProvider provider)
        {
            _provider = provider;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transport>>> GetAll()
        {
            var getAll = await _provider.GetAll();

            return getAll;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Transport>> Get([FromRoute] int id)
        {
            var get = await _provider.Get(id);

            return get;
        }

        [HttpPost]
        public async Task<ActionResult<Transport>> Post([FromBody] TransportDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            var d = new Transport() { TransportId = dto.TransportId, Type = dto.Type, TransportNumber = dto.TransportNumber, CitName = dto.CityName};
            await _provider.Post(d);

            return Ok(d);
        }

        [HttpPut]
        public async Task<ActionResult<Transport>> Put([FromBody] TransportDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            var d = new Transport() { TransportId = dto.TransportId, Type = dto.Type, TransportNumber = dto.TransportNumber, CitName = dto.CityName };
            await _provider.Put(d);

            return Ok(d);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            try
            {
                var k = _provider.Delete(id);
                return Ok(k);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpPost("&byType")]
        public async Task<ActionResult<IEnumerable<Transport>>> FilterType([FromBody] SearchStringDto search)
        {
            var info = await _provider.FilterByType(search.Element);

            return info;
        }

        [HttpPost("&byNumber")]
        public async Task<ActionResult<IEnumerable<Transport>>> FilterNumber([FromBody] SearchIntDto search)
        {
            var info = await _provider.FilterByNumber(search.Element);

            return info;
        }

        [HttpPost("&byCity")]
        public async Task<ActionResult<IEnumerable<Transport>>> FilterCity([FromBody] SearchStringDto search)
        {
            var info = await _provider.FilterByCity(search.Element);

            return info;
        }
    }
}
