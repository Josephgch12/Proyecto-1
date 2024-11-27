using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.modelos
{
    
    public class Membresia
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Tipo { get; set; }
        public string Contrasena { get; set; }
        public DateTime FechaDeVencimiento { get; set; }

        // Constructor sin parámetros 
        public Membresia() { }

        // Método para calcular el tiempo restante
        public string TiempoRestante()
        {
            TimeSpan tiempoRestante = FechaDeVencimiento - DateTime.Today;

            if (tiempoRestante.TotalDays > 0)
            {
                return $"{tiempoRestante.Days} días restantes";
            }
            else if (tiempoRestante.TotalDays == 0)
            {
                return "La membresía vence hoy";
            }
            else
            {
                return "La membresía ha vencido";
            }
        }
    }
}
