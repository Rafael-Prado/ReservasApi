
using System.Collections.Generic;

namespace Reserva.Domain.Command.Input
{
    public class FilialCommandRegister
    {
        public int FilialId { get;  set; }
        public string Nome { get;  set; }
        public int QuantidadeSala { get;  set; }
        public IEnumerable<SalaCommandRegister> Salas { get;  set; }

    }
}
