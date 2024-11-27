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
    public partial class AddEntrenador : Form
    {
        private string rutaArchivo;

        public AddEntrenador(string rutaArchivo)
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            this.rutaArchivo = rutaArchivo; // Guarda la ruta del archivo CSV.
        }
        private void AgregarEntrenadorAlArchivo(string id, string nombre, string correo, string tipo, string contraseña)
        {
            // Verificar si el archivo CSV existe.
            if (!File.Exists(rutaArchivo))
            {
                // Si no existe, crear el archivo y agregar los encabezados.
                using (StreamWriter sw = File.CreateText(rutaArchivo))
                {
                    sw.WriteLine("ID,Nombre,Correo,Tipo,Contraseña"); // Encabezados del CSV.
                }
            }

            // Agregar el nuevo entrenador al final del archivo CSV.
            using (StreamWriter sw = File.AppendText(rutaArchivo))
            {
                sw.WriteLine($"{id},{nombre},{correo},{tipo},{contraseña}"); // Escribe los datos en el archivo.
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario.
            string id = txtId.Text; // Obtener el ID del TextBox.
            string nombre = txtNombre.Text; 
            string correo = txtCorreo.Text;
            string tipo = "Entrenador"; 
            string contraseña = txtContraseña.Text;

            // Validaciones simples.
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Agregar el nuevo entrenador al archivo CSV.
            AgregarEntrenadorAlArchivo(id, nombre, correo, tipo, contraseña);

            // Mensaje de éxito y cerrar el formulario.
            MessageBox.Show("Entrenador agregado exitosamente.");
            this.Close(); // Cierra el formulario.
        }
    }
}