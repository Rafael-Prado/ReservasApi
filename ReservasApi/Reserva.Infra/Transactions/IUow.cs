using System;
using System.Collections.Generic;
using System.Text;

namespace Reserva.Infra.Transactions
{
    public interface IUow
    {
        void commit();
        void RollBack();
    }
}
