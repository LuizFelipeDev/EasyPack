using EasyPack.Application.Contratos;
using EasyPack.Domain.model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EasyPack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargasController : ControllerBase
    {
        private readonly ICargaService _cargaService;

        public CargasController(ICargaService cargaService)
        {
            _cargaService = cargaService;
        }
        // GET: api/<CargasController>
        [HttpGet("GetListCargas")]
        public async Task<ActionResult> Get()
        {
            var listaCargas = await _cargaService.GetAllCargaAsync(true);
            return  Ok(listaCargas);
        }

        // GET api/<CargasController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var carga = await _cargaService.GetCargaByIdAsync(id);
            return Ok(carga);
        }

        // POST api/<CargasController>
        [HttpPost]
        public void Post(Carga model)
        {

        }

        // PUT api/<CargasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CargasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
