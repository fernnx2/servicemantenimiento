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
    [DynamoDBTable("ordenTrabajo")]
    public class OrdenTrabajo
    {
        [DynamoDBHashKey]
        public int idOrdenTrabajo { get; set; }
        [DynamoDBProperty]
        public DateTime fechaInicio { get; set; }
        [DynamoDBProperty]
        public String prioridad { get; set; }
        [DynamoDBProperty]
        public int solicitudIdSolicitud { get; set; }
        [DynamoDBProperty]
        public int detalleMantenimientoIdDetalleMantenimiento { get; set; }
        
    }
}