using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
   
    // Clase base Usuario que representa a los usuarios del sistema (clientes y entrenadores).
    public abstract class Usuario
    {
        // Propiedad para almacenar el nombre del usuario.
        public string Nombre { get; set; }

        // Propiedad para almacenar el correo electrónico del usuario.
        public string Email { get; set; }

        // Método abstracto para mostrar notificaciones, que debe ser implementado por las clases derivadas.
        public abstract void MostrarNotificaciones();
    }
}