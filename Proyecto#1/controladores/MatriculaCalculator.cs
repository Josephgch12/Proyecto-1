using Proyecto_1.modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_1.controladores
{
    public class MatriculaCalculator
    {
        public string CalcularCambioMatrícula(string rutaArchivo, DateTime fechaInicial)
        {
            var membresias = CargarMembresias(rutaArchivo);
            var fechaHoy = DateTime.Today;

            // Contar miembros activos e inactivos
            var miembrosActivos = membresias.Count(m => m.FechaDeVencimiento > fechaHoy);
            var miembrosInactivos = membresias.Count(m => m.FechaDeVencimiento <= fechaHoy);

            // Contar miembros en la fecha inicial
            var miembrosIniciales = membresias.Count(m => m.FechaDeVencimiento > fechaInicial);

            string resultado = $"Miembros activos: {miembrosActivos}\n" +
                               $"Miembros inactivos: {miembrosInactivos}\n" +
                               $"Miembros en la fecha inicial: {miembrosIniciales}\n" +
                               $"Cambio en la matrícula: {(miembrosActivos > miembrosIniciales ? "Crecimiento" : "Disminución")}";

            return resultado;
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