using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
  
    // Clase Entrenador que hereda de Usuario y representa a un entrenador del gimnasio.
    public class Entrenador : Usuario
    {
        // Propiedad para almacenar la especialidad del entrenador.
        public string Especialidad { get; set; }

        // Lista de clases que imparte el entrenador.
        public List<Clase> Clases { get; set; } = new List<Clase>();

        // Implementación del método MostrarNotificaciones para los entrenadores.
        public override void MostrarNotificaciones()
        {
            // Lógica para mostrar notificaciones específicas para entrenadores.
            // Aquí puedes añadir notificaciones relevantes para el entrenador.
        }
    }
}
