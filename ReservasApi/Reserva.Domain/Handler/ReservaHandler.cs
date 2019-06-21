using System;
using System.Collections.Generic;
using System.Text;
using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Entities;
using Reserva.Domain.Repositories;

namespace Reserva.Domain.Handler
{
    public class ReservaHandler
    {
        private readonly IReservaRepository _repository;

        public ReservaHandler(IReservaRepository repository)
        {
            _repository = repository;
        }

        public ReservaCommadResultRegister Handle(ReservaCommandRegister commad)
        {
            var reserva = new Reservas(
                commad.ReservaId,
                commad.DataInicio,                
                commad.HoraInicio,
                commad.DataFim,
                commad.HoraFim,
                commad.Café,
                commad.QuantidadePessoa,
                commad.UsuarioId,
                commad.SalaId
                );

            var result = _repository.Salvar(reserva);

            var commadResult = new ReservaCommadResultRegister(
                result,
                commad.DataInicio,
                commad.DataFim
                );

            return commadResult;

        }
    }
}
