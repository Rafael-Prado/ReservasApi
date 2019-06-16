using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Domain.Command.Result
{
    public class UsuarioCommandResultRegister
    {
        public UsuarioCommandResultRegister(int usuarioId, string nome)
        {
            UsuarioId = usuarioId;
            Nome = nome;
        }

        public int UsuarioId { get; set; }
        public string Nome { get; set; }
    }
}
