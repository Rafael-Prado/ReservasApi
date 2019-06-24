using Dapper;
using Reserva.Domain.Command.Input;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Entities;
using Reserva.Domain.Repositories;
using Reserva.Infra.Context;
using Reserva.Infra.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reserva.Infra.Repositories
{
    public class ReservaRepository : IReservaRepository
    {
        private readonly ReservaStoreContext _contextStore;
        private readonly ReservaContext _context;
        private readonly IUow _uow;

        public ReservaRepository(ReservaStoreContext contextStore, IUow uow, ReservaContext context)
        {
            _contextStore = contextStore;
            _context = context;
            _uow = uow;
        }

        public ReservaCommadResult GetReservaId(int id)
        {
            var sql = @"SELECT f.Nome as Filial,  u.Nome as NomeUsuario, s.NomeSala,  *from Reservas r
                        JOIN Usuarios u WITH(nolock) on u.UsuarioId = r.UsuarioId
                        JOIN Sala s WITH(nolock) on s.SalaId = r.SalaId
                        join Filia f WITH(nolock) on f.FilialId = s.FilialId 
                        where r.ReservaId = @ReservaId";
            return _contextStore.Connection.Query<ReservaCommadResult>(
                    sql, new {ReservaId = id}
                ).FirstOrDefault();
        }

        public IEnumerable<ReservaCommadResult> GetReservaSala(ReservaCommandRegister commad)
        {
            var sql = @"select * from Reservas " +
                    "where SalaId = @SalaId and HoraInicio >= @HoraInicio and HoraFim <= @HoraFim";
            return _contextStore.Connection.Query<ReservaCommadResult>(
                    sql, new { SalaId = commad.SalaId, HoraInicio = commad.HoraInicio, HoraFim = commad.HoraFim }
                );
        }

        public IEnumerable<ReservaCommadResult> GetReservaSalaId(int salaId)
        {
            var sql = "select * from Reservas where SalaId = @SalaId";
            return _contextStore.Connection.Query<ReservaCommadResult>(
                    sql, new { SalaId = salaId }
                );
        }

        public IEnumerable<ReservaCommadResult> Listar()
        {
            var sql = @"SELECT f.Nome as Filial,  u.Nome as NomeUsuario, s.NomeSala,  *from Reservas r
                        JOIN Usuarios u WITH(nolock) on u.UsuarioId = r.UsuarioId
                        JOIN Sala s WITH(nolock) on s.SalaId = r.SalaId
                        join Filia f WITH(nolock) on f.FilialId = s.FilialId";
            return _contextStore.Connection.Query<ReservaCommadResult>(
                    sql, new { }
                );
        }

        public void removeReserva(int id)
        {
            var sql = "Delete from Reservas where ReservaId = @ReservaId";
            _contextStore.Connection.Execute(
                    sql, new {ReservaId = id }
                );
        }

        public int Salvar(Reservas reserva)
        {
            _context.Reservas.Add(reserva);
            _uow.commit();
            return reserva.ReservaId;
        }
    }
}
