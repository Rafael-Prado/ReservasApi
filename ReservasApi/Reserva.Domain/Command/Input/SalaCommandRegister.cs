using Reserva.Domain.Enuns;

namespace Reserva.Domain.Command.Input
{
    public class SalaCommandRegister
    {
        public int SalaId { get;  set; }
        public string NomeSala { get;  set; }
        public TipoSala TipoSala { get;  set; }
        public int FilialId { get; set; }
    }
}
