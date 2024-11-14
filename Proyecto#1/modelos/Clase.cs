using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
    
    // Clase Clase que representa una clase que se imparte en el gimnasio.
    public class Clase
    {
        // Propiedad para almacenar el nombre de la clase.
        public string Nombre { get; set; }

        // Propiedad para almacenar el horario de la clase.
        public DateTime Horario { get; set; }

        // Propiedad para almacenar el cupo máximo de participantes en la clase.
        public int Cupo { get; set; }

        // Propiedad que referencia al entrenador que imparte la clase.
        public Entrenador Entrenador { get; set; }

        // Lista de clientes que se han reservado para la clase.
        public List<Cliente> Reservas { get; set; } = new List<Cliente>();

        // Método para reservar un lugar en la clase para un cliente.
        public void Reservar(Cliente cliente)
        {
            // Verifica si hay espacio disponible en la clase.
            if (Reservas.Count < Cupo)
            {
                // Agrega al cliente a la lista de reservas.
                Reservas.Add(cliente);
            }
            else
            {
                // Muestra un mensaje si no hay espacio disponible.
                Console.WriteLine("No hay espacio disponible en esta clase.");
            }
        }
    }
}