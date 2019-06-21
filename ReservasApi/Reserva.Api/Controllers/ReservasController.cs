using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Reserva.Application.Services.Intefaces;
using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;

namespace Reserva.Api.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    //[Authorize("Bearer")]
    [AllowAnonymous]
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
        public object Post(object obj)
        {
            ReservaCommandRegister command = JsonConvert.DeserializeObject<ReservaCommandRegister>(obj.ToString());
            if (command.HoraInicio != null)
            {
                var result = _service.Salvar(command);
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


        // POST: api/Reservas
        [HttpGet("details/{id}")]
        public object Details(int id)
        {
            if (id != 0)
            {
                var result = _service.GetReservaId(id);
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
        [HttpPut("Editar/{id}")]
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
