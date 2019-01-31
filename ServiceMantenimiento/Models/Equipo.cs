using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime;
namespace ServiceMantenimiento.Models
{
    [DynamoDBTable("equipo")]
    public class Equipo
    {
        [DynamoDBHashKey]
        public int idEquipo { get; set; }
        [DynamoDBProperty]
        public String serie { get; set; }
        [DynamoDBProperty]
        public String unidad { get; set; }

    }
}