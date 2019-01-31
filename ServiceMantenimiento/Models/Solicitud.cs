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
    [DynamoDBTable("solicitud")]
    public class Solicitud
    {
        [DynamoDBHashKey]
        public int idSolicitud { get; set; }
        [DynamoDBProperty]
        public DateTime fecha { get; set; }
        [DynamoDBProperty]
        public String responsable { get; set; }
        [DynamoDBProperty]
        public String email { get; set; }
        [DynamoDBProperty]
        public String telefono { get; set; }
        [DynamoDBProperty]
        public String descripcion { get; set; }
        [DynamoDBProperty]
        public int equipoIdEquipo { get; set; }
        [DynamoDBProperty]
        public int tipoMantenimientoIdTipoMantenimiento { get; set; }
    }
}