using Reserva.Domain.Command.Result;
using Reserva.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        int SalvarUsuario(Usuario usuario);
        UsuarioCommadResult GetUsuario(string usuario, string senha);
    }
}
