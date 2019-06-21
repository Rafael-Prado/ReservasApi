using System;
using System.Collections.Generic;
using System.Text;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Entities;

namespace Reserva.Domain.Repositories
{
    public interface ISalaRepository
    {
        IEnumerable<SalaCommandResult> ListarSalas();
        bool ExiteSala(int filialId, string nomeSala);
        int Salvar(Sala sala);
        SalaCommandResult GetSalaId(int salaId);
    }
}
