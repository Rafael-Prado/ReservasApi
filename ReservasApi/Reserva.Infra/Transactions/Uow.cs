using Reserva.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Infra.Transactions
{
    public class Uow : IUow
    {
        private readonly ReservaContext _context;

        public Uow(ReservaContext context)
        {
            _context = context;
        }

        public void commit()
        {
            _context.SaveChanges();
        }

        public void RollBack()
        {
            throw new NotImplementedException();
        }
    }
}
