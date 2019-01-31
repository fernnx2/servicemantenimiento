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
    public class EquipoController : ApiController
    {
        List<Equipo> lstEquipo = new List<Equipo>();
        public EquipoController()
        {


        }


        //GET api/<controller>
        public List<Equipo> GetEquipo()
        {
            return this.lstEquipo;
        }
        //GET api/<controller>/9
        public Equipo GetEquipo(int id)
        {
           Equipo m = this.lstEquipo.Find(z => z.idEquipo == id);
           return m;
        }

       

    }
}
