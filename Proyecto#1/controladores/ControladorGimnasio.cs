using Proyecto_1.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1.controladores
{
    public class ControladorGimnasio
    {
        // Lista privada para almacenar los clientes del gimnasio
        private List<Cliente> clientes = new List<Cliente>();

        private List<Entrenador> entrenadores = new List<Entrenador>();

        private List<Clase> clases = new List<Clase>();

        // Método para agregar un nuevo cliente a la lista de clientes
        public void AgregarCliente(Cliente cliente)
        {
            // Se añade el cliente a la lista
            clientes.Add(cliente);
            // Se muestra un mensaje de confirmación en la consola
            Console.WriteLine("Cliente agregado: " + cliente.Nombre);
        }       
        
        // Método para agregar una nueva clase a la lista de clases
        public void AgregarClase(Clase clase)
        {
            clases.Add(clase);
            Console.WriteLine("Clase agregada: " + clase.Nombre);
        }

        // Método para reservar una clase para un cliente específico
        public void ReservarClase(Cliente cliente, Clase clase)
        {
            clase.Reservar(cliente);
            Console.WriteLine("Reserva realizada para " + cliente.Nombre + " en la clase " + clase.Nombre);
        }

        public List<Clase> ObtenerClases()
        {
            return clases;
        }

        
    }
}