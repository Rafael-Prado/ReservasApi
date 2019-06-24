
namespace Reserva.Domain.Command.Result
{
    public class FilialCommandResultRegister
    {
        public FilialCommandResultRegister(int filialId, string nome)
        {
            FilialId = filialId;
            Nome = nome;
        }

        public int FilialId { get; set; }
        public string Nome { get; set; }
    }
}
