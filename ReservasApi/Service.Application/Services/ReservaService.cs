using Reserva.Application.Services.Intefaces;
using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Handler;
using Reserva.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Application.Services
{
    public class ReservaService : IReservaService
    {
        private readonly IReservaRepository _repository;
        private readonly ReservaHandler _handle;

        public ReservaService(IReservaRepository repository, ReservaHandler handle)
        {
            _repository = repository;
            _handle = handle;
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
            var result = _handle.Handle(commad);
            return result;
        }
    }
}
