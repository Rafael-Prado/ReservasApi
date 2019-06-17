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
    public class SalaController : ControllerBase
    {
        private readonly ISalaService _service;

        public SalaController(ISalaService service)
        {
            _service = service;
        }
        // GET: api/Sala
        [HttpGet]
        public IEnumerable<SalaCommandResult> Get()
        {
            var result = _service.ListarSalas();
            return result;
        }

        // POST: api/Sala
        [HttpPost]
        public object Post(SalaCommandRegister commad)
        {
            if (!string.IsNullOrEmpty(commad.NomeSala))
            {
                var result = _service.SalvarSala(commad);
                if (result != null)
                {
                    return result;
                }
            }

            return new
            {
                NotFound = true,
                message = "Falha ao salvar Sala"
            };
        }

        // PUT: api/Sala/5
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
