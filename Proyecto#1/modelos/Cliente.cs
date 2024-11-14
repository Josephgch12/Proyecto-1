using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
   
    // Clase Cliente que hereda de Usuario y representa a un cliente del gimnasio.
    public class Cliente : Usuario
    {
        // Propiedad para almacenar la fecha de la membresía del cliente.
        public DateTime FechaMembresia { get; set; }

        // Implementación del método MostrarNotificaciones para los clientes.
        public override void MostrarNotificaciones()
        {
            // Verifica si la fecha de la membresía está a 5 días o menos de expirar.
            if ((FechaMembresia - DateTime.Now).TotalDays <= 5)
            {
                // Muestra un mensaje de notificación sobre el cobro de mensualidad.
                Console.WriteLine("Su mensualidad se encuentra al cobro.");
            }
        }
    }
}
