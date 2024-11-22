using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{


    public class Cliente
    {
        public int Id { get; set; } // Identificador único del cliente.
        public string Nombre { get; set; } // Nombre del cliente.
        public string Correo { get; set; } // Correo electrónico del cliente.
        public string Tipo { get; set; } // Tipo de cliente (Cliente o Entrenador).
        public string Contraseña { get; set; } // Contraseña del cliente.

        // Constructor para inicializar un nuevo cliente.
        public Cliente(int id, string nombre, string correo, string tipo, string contraseña)
        {
            Id = id;
            Nombre = nombre;
            Correo = correo;
            Tipo = tipo;
            Contraseña = contraseña;
        }
    }
}