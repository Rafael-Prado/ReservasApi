
namespace Reserva.Domain.Entities
{
    public class Usuario
    {
        public Usuario(int usuarioId, string nome, string email, string senha, string user, string accessKey)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            Email = email;
            Senha = senha;
            User = user;
            AccessKey = accessKey;
        }

        public int UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string User { get; private set; }
        public string AccessKey { get; private set; }
    }
}
