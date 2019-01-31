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
    [DynamoDBTable("tipoMantenimiento")]
    public class TipoMantenimiento
    {
        [DynamoDBHashKey]
        public int idTipoMantenimiento { get; set; }
        [DynamoDBProperty]
        public String tipoMantenimiento { get; set; }
        [DynamoDBProperty]
        public String observaciones { get; set; }

    }
}