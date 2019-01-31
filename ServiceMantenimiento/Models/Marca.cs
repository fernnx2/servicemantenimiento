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
    [DynamoDBTable("marca")]
    public class Marca
    {
        [DynamoDBHashKey]
        public int idMarca { get; set; }
        [DynamoDBProperty]
        public String nombre { get; set; }
        [DynamoDBProperty]
        public String descripcion { get; set; }     
    }
}