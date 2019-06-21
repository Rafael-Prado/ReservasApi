using System;
using System.Collections.Generic;
using System.Text;
using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;

namespace Reserva.Application.Services.Intefaces
{
    public interface IReservaService
    {
        IEnumerable<ReservaCommadResult> Listar();
        ReservaCommadResultRegister Salvar(ReservaCommandRegister commad);
        void removeReserva(int id);
        ReservaCommadResult GetReservaId(int id);
    }
}
