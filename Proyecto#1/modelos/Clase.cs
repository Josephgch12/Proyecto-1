using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
    
    
    public class Clase
    {
        public int Id { get; private set; } // Propiedad ID
        public string Nombre { get; set; }
        public DateTime Horario { get; set; }
        public int Cupo { get; set; }
        public Entrenador Entrenador { get; set; }
        public List<Cliente> Reservas { get; set; } = new List<Cliente>();

        // Constructor que acepta un ID
        public Clase(int id)
        {
            Id = id; // Asigna el ID proporcionado
        }

        public void Reservar(Cliente cliente)
        {
            if (Reservas.Count < Cupo)
            {
                Reservas.Add(cliente);
            }
            else
            {
                Console.WriteLine("No hay espacio disponible en esta clase.");
            }
        }
    }
}