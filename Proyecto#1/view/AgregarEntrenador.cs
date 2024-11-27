using Proyecto_1.modelos;
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
    public partial class AgregarEntrenador : Form
    {
        private string rutaArchivo;

        public AgregarEntrenador(string rutaArchivo)
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            this.rutaArchivo = rutaArchivo; // Guarda la ruta del archivo CSV.
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener datos del formulario.
            string id = txtId.Text; 
            string EntrenadorNombre = txtEntrenador.Text; // Obtener el nombre del TextBox.
            string puntosFuertes = txtPuntosFuertes.Text;
            string horarios = txtHorarios.Text;

            // Validaciones simples.
            if (string.IsNullOrWhiteSpace(id) || 
                string.IsNullOrWhiteSpace(EntrenadorNombre) ||
                string.IsNullOrWhiteSpace(puntosFuertes) ||
                string.IsNullOrWhiteSpace(horarios))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear un nuevo objeto Entrenador.
            Entrenador nuevoEntrenador = new Entrenador(EntrenadorNombre, puntosFuertes, horarios, id); 

            // Agregar el nuevo entrenador al archivo CSV.
            AgregarEntrenadorAlArchivo(nuevoEntrenador);

            // Mensaje de éxito y cerrar el formulario.
            MessageBox.Show("Entrenador agregado exitosamente.");
            this.Close(); // Cierra el formulario.
        }

        private void AgregarEntrenadorAlArchivo(Entrenador entrenador)
        {
            // Verificar si el archivo CSV existe.
            if (!File.Exists(rutaArchivo))
            {
                // Si no existe, crear el archivo y agregar los encabezados.
                using (StreamWriter sw = File.CreateText(rutaArchivo))
                {
                    sw.WriteLine("Entrenador,PuntosFuertes,Horarios,Id"); // Encabezados del CSV.
                }
            }

            // Agregar el nuevo entrenador al final del archivo CSV.
            using (StreamWriter sw = File.AppendText(rutaArchivo))
            {
                // Escribir todas las propiedades del entrenador en el archivo CSV.
                sw.WriteLine($"{entrenador.Nombre},{entrenador.PuntosFuertes},{entrenador.Horarios},{entrenador.Id}");
            }
        }
    }
}