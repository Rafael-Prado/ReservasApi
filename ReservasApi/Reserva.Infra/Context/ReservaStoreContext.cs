using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Reserva.Infra.Context
{
    public class ReservaStoreContext
    {

        private IConfiguration _configuration;
        public SqlConnection Connection { get; set; }

        public ReservaStoreContext(IConfiguration configuration)
        {
            _configuration = configuration;

            Connection = new SqlConnection(_configuration.GetConnectionString("CnnStr"));
            Connection.Open();
        }

    }
}
