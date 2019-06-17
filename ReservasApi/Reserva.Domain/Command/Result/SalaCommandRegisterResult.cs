using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Domain.Command.Result
{
    public class SalaCommandRegisterResult
    {
        public SalaCommandRegisterResult(int salaId, string nome)
        {
            SalaId = salaId;
            Nome = nome;
        }

        public int SalaId { get; set; }
        public string Nome { get; set; }
    }
}
