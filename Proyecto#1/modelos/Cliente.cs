using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
   
   
    public class Cliente : Usuario
    {
        public DateTime FechaMembresia { get; set; }

        // Constructor que acepta ID, nombre, Gmail y tipo de usuario
        public Cliente(int id, string nombre, string gmail)
            : base(id, nombre, gmail, "Cliente") // Llama al constructor base
        {
        }

        public override void MostrarNotificaciones()
        {
            if ((FechaMembresia - DateTime.Now).TotalDays <= 5)
            {
                Console.WriteLine("Su mensualidad se encuentra al cobro.");
            }
        }
    }
}