using System;
using System.Collections.Generic;
using System.Text;
using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;

namespace Reserva.Application.Services.Intefaces
{
    public interface ISalaService
    {
        IEnumerable<SalaCommandResult> ListarSalas();
        SalaCommandRegisterResult SalvarSala(SalaCommandRegister commad);
    }
}
