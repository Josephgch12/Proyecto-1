using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{

    
        public abstract class Usuario
        {
            public int Id { get; protected set; } // ID del usuario
            public string Nombre { get; set; }
            public string Gmail { get; set; }
            public string TipoUsuario { get; set; } // "Cliente" o "Entrenador"

            // Constructor base
            protected Usuario(int id, string nombre, string gmail, string tipoUsuario)
            {
                Id = id;
                Nombre = nombre;
                Gmail = gmail;
                TipoUsuario = tipoUsuario;
            }

            public abstract void MostrarNotificaciones();
        }
}
