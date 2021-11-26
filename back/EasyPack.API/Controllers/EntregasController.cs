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
    public class EntregasController : ControllerBase
    {
        private readonly IEntregaService _entregaService;

        public EntregasController(IEntregaService entregService)
        {
            _entregaService = entregService;
        }



        // GET: api/<EntregasController>
        [HttpGet("GetListEntregas")]
        public async Task<ActionResult> GetAllEntregas()
        {
            var listaEntregas = await _entregaService.GetAllEntregaAsync(true);
            return Ok(listaEntregas);
        }

        [HttpGet("GetListEntregasById/{id}")]
        public async Task<ActionResult> GetEntregaByIdAsync(int id)
        {
            var listaEntregas = await _entregaService.GetEntregaByIdAsync(id,true);
            return Ok(listaEntregas);
        }
        

        // POST api/<EntregasController>
        [HttpPost]
        public async Task<ActionResult> Post(Entrega model)
        {
            await _entregaService.AddEntrega(model);

            return Ok("Tudo certo!");
            
        }

        // PUT api/<EntregasController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Entrega model)
        {
            try
            {
                var result = await _entregaService.UpdateEntrega(id, model);

                if(result == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok("Tudo certo!");
                }
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        // DELETE api/<EntregasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
