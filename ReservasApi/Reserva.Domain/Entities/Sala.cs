using Reserva.Domain.Enuns;
namespace Reserva.Domain.Entities
{
    public class Sala
    {
        public Sala(int salaId, string nomeSala, TipoSala tipoSala, int filialId)
        {
            SalaId = salaId;
            NomeSala = nomeSala;
            TipoSala = tipoSala;
            FilialId = filialId;
        }

        public int SalaId { get; private set; }
        public string NomeSala { get; private set; }
        public TipoSala TipoSala { get; private set; }

        public int FilialId { get; set; }
        public virtual Filial Filial { get; set; }
    }
}
