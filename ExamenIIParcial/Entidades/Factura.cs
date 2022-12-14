using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public int Id { get; set; }
        public string IdentidadCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoUsuario { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
    }
}
