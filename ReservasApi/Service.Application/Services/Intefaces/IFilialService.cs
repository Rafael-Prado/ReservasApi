using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;
using System.Collections.Generic;

namespace Reserva.Application.Services.Intefaces
{
    public interface IFilialService
    {
        FilialCommandResultRegister Salvar(FilialCommandRegister commnd);
        IEnumerable<FilialCommandResult> ListarFiliais();
    }
}
