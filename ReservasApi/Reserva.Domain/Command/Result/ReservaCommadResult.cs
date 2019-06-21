using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Domain.Command.Result
{
    public class ReservaCommadResult
    {
        public string Filial { get; set; }
        public string NomeUsuario { get; set; }
        public string NomeSala { get; set; }
        public int ReservaId { get; set; }
        public DateTime DataInicio { get; set; }
        public string HoraInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string HoraFim { get; set; }
        public bool Café { get; set; }
        public int QuantidadePessoa { get; set; }
        public int SalaId { get; set; }
    }
}
