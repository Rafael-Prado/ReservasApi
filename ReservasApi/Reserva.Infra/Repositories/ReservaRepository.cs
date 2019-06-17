using Dapper;
using Reserva.Domain.Command.Result;
using Reserva.Domain.Entities;
using Reserva.Domain.Repositories;
using Reserva.Infra.Context;
using Reserva.Infra.Transactions;
using System;
using System.Collections.Generic;
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

        public IEnumerable<ReservaCommadResult> Listar()
        {
            var sql = "select * from Reservas ";
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
