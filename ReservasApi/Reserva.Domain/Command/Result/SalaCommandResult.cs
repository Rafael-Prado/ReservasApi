using Reserva.Domain.Enuns;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Domain.Command.Result
{
    public class SalaCommandResult
    {
        public int SalaId { get; set; }
        public string NomeSala { get; set; }
        public TipoSala TipoSala { get; set; }
        public int FilialId { get; set; }
    }
}
