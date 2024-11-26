using Proyecto_1.modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_1.controladores
{
    public class MatriculaCalculator
    {
        public string CalcularCambioMatrícula(string rutaArchivo)
        {
            var membresias = CargarMembresias(rutaArchivo);
            var fechaHoy = DateTime.Today;

            var miembrosActivos = membresias.Count(m => m.FechaDeVencimiento > fechaHoy);
            var miembrosInactivos = membresias.Count(m => m.FechaDeVencimiento <= fechaHoy);

            return $"Miembros activos: {miembrosActivos}\n" +
                   $"Miembros inactivos: {miembrosInactivos}\n" +
                   $"Cambio en la matrícula: {(miembrosActivos > miembrosInactivos ? "Crecimiento" : "Disminución")}";
        }

        private List<Membresia> CargarMembresias(string rutaArchivo)
        {
            using (var reader = new StreamReader(rutaArchivo))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<Membresia>().ToList();
            }
        }
    }
}
