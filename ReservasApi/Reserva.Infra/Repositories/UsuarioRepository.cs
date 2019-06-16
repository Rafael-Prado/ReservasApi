using Dapper;
using Microsoft.Extensions.Configuration;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Entities;
using Reserva.Domain.Repositories;
using Reserva.Infra.Context;
using System;
using System.Data.SqlClient;

namespace Reserva.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private ReservaContext _context;
        private IConfiguration _configuration;

        public UsuarioRepository(ReservaContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public UsuarioCommadResult GetUsuario(string usuario, string senha)
        {

            var sql = @"SELECT UsuarioId, AccessKey " +
                    "FROM dbo.Usuarios " +
                    "WHERE Senha = @Senha";
            using (SqlConnection connection = new SqlConnection(
                _configuration.GetConnectionString("CnnStr")))
            {
                return connection.QueryFirstOrDefault<UsuarioCommadResult>(
                    sql, new { Senha = senha });
                   
            }
        }

        public int SalvarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
