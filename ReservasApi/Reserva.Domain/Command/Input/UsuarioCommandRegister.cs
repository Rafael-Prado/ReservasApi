namespace Reserva.Domain.Command.Input
{
    public class UsuarioCommandRegister
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string User { get; set; }
        public string AccessKey { get; set; }
    }
}
