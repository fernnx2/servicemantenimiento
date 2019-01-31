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

    public class MarcaController : ApiController
    {

        List<Marca> lstMarcas = new List<Marca>();
        public MarcaController()
        {
            

            AmazonDynamoDBClient client = new AmazonDynamoDBClient();
            DynamoDBContext contex = new DynamoDBContext(client);

            var marcas = contex.CreateBatchGet<Marca>();
            marcas.AddKey(1);
            marcas.AddKey(2);
            marcas.Execute();
            this.lstMarcas.Add(marcas.Results[0]);
            this.lstMarcas.Add(marcas.Results[1]);
            


        }
           

        //GET api/<controller>
        public List<Marca> GetMarcas()
        {
            return this.lstMarcas;
        }
        //GET api/<controller>/9
        public Marca GetMarca(int id)
        {
            Marca m = this.lstMarcas.Find(z => z.idMarca == id);
            return m;
        }

    }





}
