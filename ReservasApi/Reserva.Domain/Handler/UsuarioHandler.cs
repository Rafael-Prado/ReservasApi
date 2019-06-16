
using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Entities;
using Reserva.Domain.Repositories;

namespace Reserva.Domain.Handler
{
    public class UsuarioHandler
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }       

        public UsuarioCommandResultRegister Handler(UsuarioCommandRegister command)
        {
            var usuario = new Usuario(
                command.UsuarioId,
                command.Nome,
                command.Email,
                command.Senha,
                command.User,
                command.AccessKey
                );

           var id =  _usuarioRepository.SalvarUsuario(usuario);

            var result = new UsuarioCommandResultRegister(
                id,
                command.Nome
                );

            return result;
        }
    }
}
