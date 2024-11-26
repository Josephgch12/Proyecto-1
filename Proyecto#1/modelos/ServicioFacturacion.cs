using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
    public class ServicioFacturacion
    {
        private const string ArchivoFacturas = "facturas.csv";

        public void GenerarFactura(string clienteId, decimal monto, string descripcion)
        {
            int nuevaId = ObtenerNuevoId();
            Factura nuevaFactura = new Factura(nuevaId, clienteId, monto, DateTime.Now, descripcion);
            GuardarFactura(nuevaFactura);
        }

        public List<Factura> CargarFacturas()
        {
            List<Factura> facturas = new List<Factura>();

            if (File.Exists(ArchivoFacturas))
            {
                string[] lineas = File.ReadAllLines(ArchivoFacturas);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');

                    // Validar que la línea tenga la cantidad correcta de datos
                    if (datos.Length == 5 &&
                        int.TryParse(datos[0], out int id) &&
                        decimal.TryParse(datos[2], out decimal monto) &&
                        DateTime.TryParse(datos[3], out DateTime fechaEmision))
                    {
                        Factura factura = new Factura
                        {
                            Id = id,
                            ClienteId = datos[1],
                            Monto = monto,
                            FechaEmision = fechaEmision,
                            Descripcion = datos[4]
                        };
                        facturas.Add(factura);
                    }
                }
            }

            return facturas;
        }

        private int ObtenerNuevoId()
        {
            if (!File.Exists(ArchivoFacturas))
                return 1;

            string[] lineas = File.ReadAllLines(ArchivoFacturas);
            if (lineas.Length == 0)
                return 1;

            string ultimaLinea = lineas[lineas.Length - 1];
            string[] datos = ultimaLinea.Split(',');
            return int.Parse(datos[0]) + 1; // Incrementa el ID más alto
        }

        private void GuardarFactura(Factura factura)
        {
            using (StreamWriter writer = new StreamWriter(ArchivoFacturas, true))
            {
                writer.WriteLine(factura.ToString());
            }
        }
    }
}
