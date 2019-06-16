using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reserva.Application.Services.Intefaces;
using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;

namespace Reserva.Api.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class FilialController : ControllerBase
    {
        private readonly IFilialService _service;

        public FilialController(IFilialService service)
        {
            _service = service;
        }
        // GET: api/Filial
        [HttpGet]
        public IEnumerable<FilialCommandResult> Listar()
        {
            var result = _service.ListarFiliais();
            return result;
        }

        // POST: api/Filial
        [HttpPost]
        public object Post(FilialCommandRegister commad)
        {
            if (!string.IsNullOrEmpty(commad.Nome))
            {
                var result = _service.Salvar(commad);
                if (result != null)
                {
                    return result;
                }                
            }
            return new
            {
                NotFound = true,
                message = "Falha ao salvar Filial"
            };
        }

        // PUT: api/Filial/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
