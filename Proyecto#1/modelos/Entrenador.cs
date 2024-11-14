using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
  
    
    public class Entrenador : Usuario
    {
        public string Especialidad { get; set; }
        public List<Clase> Clases { get; set; } = new List<Clase>();

        // Constructor que acepta ID, nombre, Gmail y tipo de usuario
        public Entrenador(int id, string nombre, string gmail)
            : base(id, nombre, gmail, "Entrenador") // Llama al constructor base
        {
        }

        public override void MostrarNotificaciones()
        {
            // Implementar lógica para notificaciones de entrenadores
        }
    }
}