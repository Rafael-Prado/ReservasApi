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
    public class FilialRepository : IFilialRepository
    {
        private readonly ReservaStoreContext _contextStore;
        private readonly ReservaContext _context;
        private readonly IUow _uow;

        public FilialRepository(ReservaStoreContext contextStore, IUow uow, ReservaContext context)
        {
            _contextStore = contextStore;
            _context = context;
            _uow = uow;
        }

        public bool ExisteFilial(string nome)
        {
            var sql = "select top 1 *from Filia where Nome = @Nome";
            return _contextStore.Connection.Query<bool>(
                    sql, new { Nome = nome }
                ).FirstOrDefault();
        }

        public IEnumerable<FilialCommandResult> ListarFiliais()
        {
            var sql = "select * from Filia ";
            return _contextStore.Connection.Query<FilialCommandResult>(
                    sql, new { }
                );
        }

        public int Salvar(Filial filial)
        {            
            _context.Filia.Add(filial);
            _uow.commit();
            return filial.FilialId;
        }
    }
}
