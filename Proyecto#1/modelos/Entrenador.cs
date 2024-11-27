using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{


    public class Entrenador
    {
        public string Nombre { get; set; } // Propiedad Nombre
        public string PuntosFuertes { get; set; } // Propiedad PuntosFuertes
        public string Horarios { get; set; } // Propiedad Horarios
        public string Id { get; set; } // Propiedad ID

        public Entrenador(string nombre, string puntosFuertes, string horarios, string id)
        {
            Nombre = nombre;
            PuntosFuertes = puntosFuertes;
            Horarios = horarios;
            Id = id; // Inicializar el campo ID
        }

        public string DisplayInfo
        {
            get
            {
                return $"{Nombre} - {PuntosFuertes} - {Horarios} - {Id}"; // Combina la información
            }
        }


        public override string ToString()
        {
            return DisplayInfo; 
        }


    }
    }
