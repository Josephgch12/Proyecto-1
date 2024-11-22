using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1.view
{
    public partial class AgregarCliente : Form
    {


        private string rutaArchivo;

        public AgregarCliente(string rutaArchivo)
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            this.rutaArchivo = rutaArchivo; // Guarda la ruta del archivo CSV.
        }

      

        private string GenerarFechaVencimiento()
        {
            Random random = new Random();
            DateTime fechaInicio = new DateTime(2024, 11, 20); // Fecha de inicio: 20 de noviembre de 2024.
            DateTime fechaFin = fechaInicio.AddMonths(2); // Fecha de fin: 20 de enero de 2025.

            // Generar un día aleatorio entre la fecha de inicio y la fecha de fin.
            int rangoDias = (fechaFin - fechaInicio).Days; // Calcular el rango de días.
            DateTime fechaAleatoria = fechaInicio.AddDays(random.Next(0, rangoDias + 1)); // Generar la fecha aleatoria.

            return fechaAleatoria.ToString("yyyy-MM-dd"); // Formato YYYY-MM-DD.
        }

        private void AgregarClienteAlArchivo(string id, string nombre, string correo, string contraseña, string tipoCliente, string fechaVencimiento)
        {
            // Verificar si el archivo CSV existe.
            if (!File.Exists(rutaArchivo))
            {
                // Si no existe, crear el archivo y agregar los encabezados.
                using (StreamWriter sw = File.CreateText(rutaArchivo))
                {
                    sw.WriteLine("ID,Nombre,Correo,Contraseña,TipoCliente,FechaVencimiento"); // Encabezados del CSV.
                }
            }

            // Agregar el nuevo cliente al final del archivo CSV.
            using (StreamWriter sw = File.AppendText(rutaArchivo))
            {
                sw.WriteLine($"{id},{nombre},{correo},{contraseña},{tipoCliente},{fechaVencimiento}"); // Escribe los datos en el archivo.
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario.
            string id = txtId.Text; // Obtener el ID del TextBox.
            string nombre = txtNombre.Text; // Obtener el nombre del TextBox.
            string correo = txtCorreo.Text; // Obtener el correo del TextBox.
            string contraseña = txtContraseña.Text; // Obtener la contraseña del TextBox.

            // Indicar que es un cliente.
            string tipoCliente = "Cliente"; // Puedes usar un Label o TextBox si lo deseas.

            // Generar una fecha de vencimiento aleatoria.
            string fechaVencimiento = GenerarFechaVencimiento();

            // Validaciones simples.
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Agregar el nuevo cliente al archivo CSV.
            AgregarClienteAlArchivo(id, nombre, correo, contraseña, tipoCliente, fechaVencimiento);

            // Mensaje de éxito y cerrar el formulario.
            MessageBox.Show("Cliente agregado exitosamente.");
            this.Close(); // Cierra el formulario.
        }
    }
}