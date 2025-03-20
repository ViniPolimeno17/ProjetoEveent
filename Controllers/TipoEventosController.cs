using Eveent_.Domains;
using Eveent_.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Eveent_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TipoEventosController : ControllerBase
    {
        private readonly ITiposEventosRepository _tiposEventosRepository;

        public TipoEventosController (ITiposEventosRepository tiposEventosRepository)
        {
            _tiposEventosRepository = tiposEventosRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<TiposEventos> listaTipoEventos = _tiposEventosRepository.Listar();

                return Ok(listaTipoEventos);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint para Cadastrar um novo TiposEventos
        /// </summary>
        /// <param name="novoFilme">Cadastrar um novo TiposEventos</param>
        /// <returns>Cadastrar um novoFilme</returns>
        //[Authorize]
        [HttpPost]
        public IActionResult Post(TiposEventos novoTiposEventos)
        {
            try
            {
                _tiposEventosRepository.Cadastrar(novoTiposEventos);

                return Created();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint para buscar um Filme pelo Id
        /// </summary>
        /// <param name="id">Id do Filme buscado</param>
        /// <returns>Filme Buscado</returns>
        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                TiposEventos tiposEventosBuscado = _tiposEventosRepository.BuscarPorId(id);

                return Ok(tiposEventosBuscado);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint para Atualizar um Filme
        /// </summary>
        /// <param name="id">Atualizar um Filme</param>
        /// <param name="filme">Atualizar um Filme</param>
        /// <returns>Atualizar um filme</returns>
        //[Authorize]
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, TiposEventos tipoEventos)
        {
            try
            {
                _tiposEventosRepository.Atualizar(id, tipoEventos);

                return NoContent();
            }

            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Endpoint para cadastrar um novo Filme
        /// </summary>
        /// <param name="id">Cadastrar um novo Filme</param>
        /// <returns>Deletar um filme</returns>
        //[Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _tiposEventosRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
