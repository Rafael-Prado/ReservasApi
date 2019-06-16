using Reserva.Domain.Command.Result;
using Reserva.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Domain.Repositories
{
    public interface IFilialRepository
    {
        IEnumerable<FilialCommandResult> ListarFiliais();
        bool ExisteFilial(string nome);
        int Salvar(Filial filial);
    }
}
