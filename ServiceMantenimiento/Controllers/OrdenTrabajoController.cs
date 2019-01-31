using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiceMantenimiento.Controllers
{
    public class OrdenTrabajoController : ApiController
    {
        // GET: api/OrdenTrabajo
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OrdenTrabajo/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OrdenTrabajo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/OrdenTrabajo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OrdenTrabajo/5
        public void Delete(int id)
        {
        }
    }
}
