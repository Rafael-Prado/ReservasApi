using Reserva.Application.Services.Intefaces;
using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Handler;
using Reserva.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reserva.Application.Services
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _repository;
        private readonly ISalaRepository _salaRepository;
        private readonly ReservaHandler _handle;

        public ReservaService(IReservaRepository repository, ReservaHandler handle, ISalaRepository _salaRepository)
        {
            _repository = repository;
            _handle = handle;
        }

        public ReservaCommadResult GetReservaId(int id)
        {
            return _repository.GetReservaId(id);
        }

        public IEnumerable<ReservaCommadResult> Listar()
        {
            return _repository.Listar();
        }

        public void removeReserva(int id)
        {
            _repository.removeReserva(id);
        }

        public ReservaCommadResultRegister Salvar(ReservaCommandRegister commad)
        {
            var reserva = _repository.GetReservaSala(commad);
            if (reserva.Count() == 0)
            {
                var result = _handle.Handle(commad);
                return result;
            }
            return null;
            
        }
    }
}
