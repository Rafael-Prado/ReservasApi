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
    public class SalaService : ISalaService
    {
        private readonly ISalaRepository _repository;
        private readonly SalaHandler _handle;

        public SalaService(ISalaRepository repository, SalaHandler handle)
        {
            _handle = handle;
            _repository = repository;
        }

        public IEnumerable<SalaCommandResult> ListarSalas()
        {
            return _repository.ListarSalas();
        }

        public SalaCommandRegisterResult SalvarSala(SalaCommandRegister commad)
        {
            var result = _handle.Salvar(commad);
            return result;
        }
    }
}
