using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Reserva.Api.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    [Authorize("Bearer")]
    public class ReservasController : ControllerBase
    {
        // GET: api/Reservas
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/Reservas
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Reservas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
