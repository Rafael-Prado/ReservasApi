using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Domain.Command.Result
{
    public class FilialCommandResult
    {
        public int FilialId { get;  set; }
        public string Nome { get;  set; }
        public int QuantidadeSala { get;  set; }
        public virtual ICollection<SalaCommandResult> Salas { get; set; }

    }
}
