using Reserva.Application.Services.Interfaces;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public UsuarioCommadResult GetUsuarioCommad(string senha, string usuario)
        {
            var result = _repository.GetUsuario(usuario, senha);
            return result;
        }
    }
}
