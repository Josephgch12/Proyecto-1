using Proyecto_1.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Proyecto_1.controladores
{
    
    public class MembresiaController
    {
      
    
    private List<Membresia> membresias;

        public MembresiaController(string rutaArchivo)
        {
            // Cargar las membresías desde el archivo CSV
            membresias = CargarMembresiasDesdeCsv(rutaArchivo);
        }

        public Membresia ObtenerMembresiaPorId(int id)
        {
            // Buscar la membresía por ID
            return membresias.FirstOrDefault(m => m.ID == id);
        }

        private List<Membresia> CargarMembresiasDesdeCsv(string path)
        {
            var listaMembresias = new List<Membresia>();

            try
            {
                // Leer todas las líneas del archivo CSV
                var lineas = File.ReadAllLines(path);

                foreach (var linea in lineas.Skip(1)) // Saltar la cabecera
                {
                    var datos = linea.Split(',');

                    // Verificar que la línea tenga el número correcto de columnas
                    if (datos.Length != 6)
                    {
                        Console.WriteLine($"La línea no tiene el número correcto de columnas: {linea}");
                        continue; // O lanzar una excepción, según tu lógica
                    }

                    // Verificar y parsear la fecha de vencimiento
                    if (!DateTime.TryParseExact(datos[5], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaDeVencimiento))
                    {
                        Console.WriteLine($"La fecha '{datos[5]}' no tiene el formato correcto.");
                        continue; // O lanzar una excepción
                    }

                    // Crear una nueva instancia de Membresia
                    var membresia = new Membresia
                    {
                        ID = int.Parse(datos[0]), // ID
                        Nombre = datos[1],        // Nombre
                        Correo = datos[2],       // Correo
                        Tipo = datos[3],         // Tipo
                        Contrasena = datos[4],   // Contraseña
                        FechaDeVencimiento = fechaDeVencimiento // Fecha de Vencimiento
                    };

                    // Agregar la membresía a la lista
                    listaMembresias.Add(membresia);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar el archivo: {ex.Message}");
            }

            return listaMembresias;
        }
    }
}