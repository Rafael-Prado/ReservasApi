using System;
using System.Collections.Generic;
using System.Text;
using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Entities;
using Reserva.Domain.Repositories;

namespace Reserva.Domain.Handler
{
    public class SalaHandler
    {
        private readonly ISalaRepository _repository;

        public SalaHandler(ISalaRepository repository)
        {
            _repository = repository;
        }
        public SalaCommandRegisterResult Salvar(SalaCommandRegister commad)
        {
            if (_repository.ExiteSala(commad.FilialId, commad.NomeSala))
                return null;

            var sala = new Sala(
                commad.SalaId,
                commad.NomeSala,
                commad.TipoSala,
                commad.FilialId
                );

            var result = _repository.Salvar(sala);

            var commadResult = new SalaCommandRegisterResult(
                result,
                commad.NomeSala
                );

            return commadResult;



        }
    }
}
