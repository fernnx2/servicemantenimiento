using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServiceMantenimiento.Models;
using Amazon.Runtime;
using Amazon.Util;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DataModel;

namespace ServiceMantenimiento.Controllers
{
    public class SolicitudController : ApiController
    {
       
        // GET: api/Solicitud
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Solicitud/5
        public string Get(int id)
        {
            return "value";
           
        }

        // POST: api/Solicitud
        public void Post([FromBody]string value)
        {
            AmazonDynamoDBClient client = new AmazonDynamoDBClient();
            DynamoDBContext contex = new DynamoDBContext(client);
            var solicitud = contex.CreateBatchGet<Solicitud>();
          
        }

        // PUT: api/Solicitud/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Solicitud/5
        public void Delete(int id)
        {
        }
    }
}
