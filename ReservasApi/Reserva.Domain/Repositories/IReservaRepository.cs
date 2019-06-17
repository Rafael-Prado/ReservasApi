using System;
using System.Collections.Generic;
using System.Text;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Entities;

namespace Reserva.Domain.Repositories
{
    public interface IReservaRepository
    {
        IEnumerable<ReservaCommadResult> Listar();
        void removeReserva(int id);
        int Salvar(Reservas reserva);
    }
}
