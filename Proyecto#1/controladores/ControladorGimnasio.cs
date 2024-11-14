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
        // Método para agregar un nuevo entrenador a la lista de entrenadores
        public void AgregarEntrenador(Entrenador entrenador)
        {
            entrenadores.Add(entrenador);
            Console.WriteLine("Entrenador agregado: " + entrenador.Nombre);
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

        // Método para iniciar sesión
        public Usuario IniciarSesion(string gmail)
        {
            // Busca en la lista de clientes
            foreach (var cliente in clientes)
            {
                if (cliente.Gmail.Equals(gmail, StringComparison.OrdinalIgnoreCase))
                {
                    return cliente; // Retorna el cliente si se encuentra
                }
            }

            // Busca en la lista de entrenadores
            foreach (var entrenador in entrenadores)
            {
                if (entrenador.Gmail.Equals(gmail, StringComparison.OrdinalIgnoreCase))
                {
                    return entrenador; // Retorna el entrenador si se encuentra
                }
            }

            return null; // Retorna null si no se encuentra el usuario
        }
    }
}