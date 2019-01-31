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
    public class ModeloController : ApiController
    {
        List<Modelo> lstModelos= new List<Modelo>();
        public ModeloController()
        {


            AmazonDynamoDBClient client = new AmazonDynamoDBClient();
            DynamoDBContext contex = new DynamoDBContext(client);

            var modelos = contex.CreateBatchGet<Modelo>();
            modelos.AddKey(1);
            modelos.AddKey(2);
            modelos.Execute();
            this.lstModelos.Add(modelos.Results[0]);
            this.lstModelos.Add(modelos.Results[1]);



        }


        //GET api/<controller>
        public List<Modelo> GetModelo()
        {
            return this.lstModelos;
        }
        //GET api/<controller>/9
        public Modelo GetModelo(int id)
        {
            Modelo m = this.lstModelos.Find(z => z.idModelo == id);
            return m;
        }
    }
}
