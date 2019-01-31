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
    [DynamoDBTable("detalleEquipo")]
    public class DetalleEquipo
    {
        [DynamoDBHashKey]
        public int idDetalleEquipo { get; set; }
        [DynamoDBProperty]
        public String dispositivo { get; set; }
        [DynamoDBProperty]
        public String descripcion { get; set; }

        [DynamoDBProperty]
        public int equipoIdEquipo { get; set; }
        [DynamoDBProperty]
        public int marcaIdMarca { get; set; }

        [DynamoDBProperty]
        public int modeloIdModelo { get; set; }
    }
}