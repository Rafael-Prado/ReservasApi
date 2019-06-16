
using System.Collections.Generic;

namespace Reserva.Domain.Entities
{
    public class Filial
    {
        public Filial(int filialId, string nome, int quantidadeSala)
        {
            FilialId = filialId;
            Nome = nome;
            QuantidadeSala = quantidadeSala;
            Salas = new HashSet<Sala>();
        }

        public int FilialId { get; private set; }
        public string Nome { get; private set; }
        public int QuantidadeSala { get; private set; }
        public virtual ICollection<Sala> Salas { get; private set; }
    }
}
