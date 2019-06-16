using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Entities;
using Reserva.Domain.Repositories;
using Reserva.Shared.Commands;
using System;
using System.Text;

namespace Reserva.Domain.Handler
{
    public class FilialHandler
    {
        private readonly IFilialRepository _repository;

        public FilialHandler(IFilialRepository repository)
        {
            _repository = repository;
        }

        public FilialCommandResultRegister Handle(FilialCommandRegister commad)
        {
            if (_repository.ExisteFilial(commad.Nome))
                return null;

            var filial = new Filial(
                commad.FilialId,
                commad.Nome,
                commad.QuantidadeSala
                );

            var result = _repository.Salvar(filial);

            var commandoResult = new FilialCommandResultRegister(
                result,
                commad.Nome
                );

            return commandoResult;

        }
    }
}
