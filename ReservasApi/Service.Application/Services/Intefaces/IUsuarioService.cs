using Reserva.Domain.Command.Result;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Application.Services.Interfaces
{
    public interface IUsuarioService
    {
        UsuarioCommadResult GetUsuarioCommad(string senha, string usuario);
    }
}
