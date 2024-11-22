using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto_1.modelos
{
    public class GestionClientes
    {
        private List<Cliente> clientes; // Lista que almacena los clientes.
        public const string RutaArchivo = "usuarios_gimnasio.csv"; // Ruta del archivo CSV.

        // Constructor que inicializa la lista de clientes y carga los datos desde el archivo CSV.
        public GestionClientes()
        {
            clientes = new List<Cliente>(); // Inicializa la lista de clientes.
            CargarClientesDesdeArchivo(); // Carga los clientes existentes desde el archivo CSV.
        }

        // Método para agregar un nuevo cliente a la lista.
        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente); // Agrega el cliente a la lista.
            GuardarClientesEnArchivo(); // Guarda los cambios en el archivo CSV.
        }

        // Método para guardar la lista de clientes en el archivo CSV.
        private void GuardarClientesEnArchivo()
        {
            StringBuilder sb = new StringBuilder(); // Crea un StringBuilder para construir el contenido del CSV.
            foreach (var cliente in clientes) // Itera sobre cada cliente en la lista.
            {
                // Agrega una línea al StringBuilder con los datos del cliente.
                sb.AppendLine($"{cliente.Id},{cliente.Nombre},{cliente.Correo},{cliente.Tipo},{cliente.Contraseña}");
            }

            // Escribe el contenido del StringBuilder en el archivo CSV, sobrescribiendo el archivo existente.
            File.WriteAllText(RutaArchivo, sb.ToString());
        }

        // Método para cargar clientes desde el archivo CSV al iniciar la aplicación.
        private void CargarClientesDesdeArchivo()
        {
            if (File.Exists(RutaArchivo)) // Verifica si el archivo CSV existe.
            {
                var lineas = File.ReadAllLines(RutaArchivo); // Lee todas las líneas del archivo.
                foreach (var linea in lineas) // Itera sobre cada línea leída.
                {
                    var datos = linea.Split(','); // Divide la línea en partes usando la coma como separador.
                    if (datos.Length == 5) // Verifica que haya 5 datos (Id, Nombre, Correo, Tipo, Contraseña).
                    {
                        // Convierte los datos a sus tipos correspondientes.
                        int id = int.Parse(datos[0]);
                        string nombre = datos[1];
                        string correo = datos[2];
                        string tipo = datos[3];
                        string contraseña = datos[4];

                        // Crea un nuevo cliente y lo agrega a la lista.
                        Cliente cliente = new Cliente(id, nombre, correo, tipo, contraseña);
                        clientes.Add(cliente);
                    }
                }
            }
        }

        // Método para obtener la lista de clientes.
        public List<Cliente> ObtenerClientes()
        {
            return clientes; // Devuelve la lista de clientes.
        }
    }
}
