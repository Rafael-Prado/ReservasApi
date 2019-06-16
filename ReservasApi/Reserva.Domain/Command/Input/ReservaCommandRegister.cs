using System;

namespace Reserva.Domain.Command.Input
{
    public class ReservaCommandRegister
    {
        public int ReservaId { get;  set; }
        public DateTime DataInicio { get;  set; }
        public DateTime HoraInicio { get;  set; }
        public DateTime DataFim { get;  set; }
        public DateTime HoraFim { get;  set; }
        public bool Café { get;  set; }
        public int QuantidadePessoa { get;  set; }

        public UsuarioCommandRegister Responsavel { get;  set; }
    }
}
