using Dapper;
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
    public class SalaRepository : ISalaRepository
    {
        private readonly ReservaStoreContext _contextStore;
        private readonly ReservaContext _context;
        private readonly IUow _uow;

        public SalaRepository(ReservaStoreContext contextStore, IUow uow, ReservaContext context)
        {
            _contextStore = contextStore;
            _context = context;
            _uow = uow;
        }

        public bool ExiteSala(int filialId, string nomeSala)
        {
            var sql = "select top 1 *from Sala where NomeSala = @Nome and FilialId = @FilialId";
            return _contextStore.Connection.Query<bool>(
                    sql, new { Nome = nomeSala, FilialId = filialId }
                ).FirstOrDefault();
        }

        public IEnumerable<SalaCommandResult> ListarSalas()
        {
            var sql = "select * from Sala ";
            return _contextStore.Connection.Query<SalaCommandResult>(
                    sql, new { }
                );
        }

        public int Salvar(Sala sala)
        {
            _context.Sala.Add(sala);
            _uow.commit();
            return sala.SalaId;
        }
    }
}
