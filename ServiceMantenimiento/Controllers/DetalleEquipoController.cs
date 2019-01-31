using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceMantenimiento.Controllers
{
    public class DetalleEquipoController : ApiController
    {
        // GET: api/DetalleEquipo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DetalleEquipo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DetalleEquipo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DetalleEquipo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DetalleEquipo/5
        public void Delete(int id)
        {
        }
    }
}
