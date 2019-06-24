using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Reserva.Application.Services;
using Reserva.Application.Services.Intefaces;
using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;

namespace Reserva.Api.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    [AllowAnonymous]
    public class ReservasController : ControllerBase
    {
        private readonly IReservaService _service;
        private readonly AuthenticatedUser _user;

        public ReservasController(IReservaService service, AuthenticatedUser user)
        {
            _service = service;
            _user = user;
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
                var horainicio = command.DataInicio.ToString("dd-MM-yyyy") +" "+ command.HoraInicio.TimeOfDay;
                var horaFim = command.DataFim.ToString("dd-MM-yyyy") + " " + command.HoraFim.TimeOfDay;
                command.HoraInicio = Convert.ToDateTime(horainicio);
                command.HoraFim = Convert.ToDateTime(horaFim);

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
        [HttpGet("{id}")]
        public object ReservaByID(int id)
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
