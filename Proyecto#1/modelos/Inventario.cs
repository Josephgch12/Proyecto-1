using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
  
    // Clase Inventario que representa un equipo del gimnasio.
    public class Inventario
    {
        // Propiedad para almacenar el nombre del equipo.
        public string NombreEquipo { get; set; }

       
        public DateTime FechaCompra { get; set; }

        
        public int VidaUtil { get; set; } // En meses
    }
}