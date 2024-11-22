using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{


    public class Entrenador
    {
        public string EntrenadorNombre { get; set; } // Nombre del entrenador
        public string PuntosFuertes { get; set; } // Puntos fuertes del entrenador
        public string Horarios { get; set; } // Horarios del entrenador

        // Constructor
        public Entrenador(string nombre, string puntosFuertes, string horarios)
        {
            EntrenadorNombre = nombre;
            PuntosFuertes = puntosFuertes;
            Horarios = horarios;
        }

        // Método para convertir el objeto a una línea CSV
        public override string ToString()
        {
            return $"{EntrenadorNombre},{PuntosFuertes},{Horarios}";
        }

      
        }
    }
