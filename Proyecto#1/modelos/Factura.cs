using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
    public class Factura
    {
        
    public int Id { get; set; }          // ID de la factura
        public string ClienteId { get; set; } 
        public decimal Monto { get; set; }   
        public DateTime FechaEmision { get; set; } 
        public string Descripcion { get; set; } // Descripción de la factura

        // Constructor por defecto
        public Factura() { }

        // Constructor con parámetros
        public Factura(int id, string clienteId, decimal monto, DateTime fechaEmision, string descripcion)
        {
            Id = id;
            ClienteId = clienteId;
            Monto = monto;
            FechaEmision = fechaEmision;
            Descripcion = descripcion;
        }

        // Método para representar la factura como una cadena (para CSV)
        public override string ToString()
        {
            return $"{Id},{ClienteId},{Monto.ToString(CultureInfo.InvariantCulture)},{FechaEmision:yyyy-MM-dd},{Descripcion}";
        }
    }
}
