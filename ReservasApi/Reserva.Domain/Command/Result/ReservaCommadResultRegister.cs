using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Domain.Command.Result
{
    public class ReservaCommadResultRegister
    {
        public ReservaCommadResultRegister(int reservaId, DateTime dataInicio, DateTime dataFim)
        {
            ReservaId = reservaId;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public int ReservaId { get; set; }
        public DateTime DataInicio{ get; set; }
        public DateTime DataFim { get; set; }
    }
}
