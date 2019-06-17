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
    public class ReservasController : ControllerBase
    {
        private readonly IReservaService _service;

        public ReservasController(IReservaService service)
        {
            _service = service;
        }

        // GET: api/Reservas
        [HttpGet]
        public IEnumerable<ReservaCommadResult> Get()
        {
            var result = _service.Listar();
            return result;
        }

        // POST: api/Reservas
        [HttpPost]
        public object Post(ReservaCommandRegister commad)
        {
            if (commad.HoraInicio != null)
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
                message = "Reserva não pode ser feita."
            };
        }

        // PUT: api/Reservas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public object Delete(int id)
        {
            if (id != 0)
            {
                _service.removeReserva(id);

                return new
                {
                    ok = true,
                    message = "Reserva cancelada con sucesso!"
                };

            }

            return new
            {
                NotFound = true,
                message = "Sua Reserva não foi cancela consulte o Adm"
            };
        }
    }
}
