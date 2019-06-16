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
    public class FilialService : IFilialService
    {
        private readonly IFilialRepository _repository;
        private readonly FilialHandler _handle;

        public FilialService(IFilialRepository repository, FilialHandler handle)
        {
            _repository = repository;
            _handle = handle;
        }

        public IEnumerable<FilialCommandResult> ListarFiliais()
        {
            var result = _repository.ListarFiliais();
            return result;
        }

        public FilialCommandResultRegister Salvar(FilialCommandRegister command)
        {
            var result = _handle.Handle(command);
            return result;
        }
    }
}
