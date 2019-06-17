using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Domain.Command.Result
{
    public class ReservaCommadResult
    {
        public int ReservaId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime HoraFim { get; set; }
        public bool Café { get; set; }
        public int QuantidadePessoa { get; set; }
        public int SalaId { get; set; }
    }
}
