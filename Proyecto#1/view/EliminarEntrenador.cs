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
    public partial class EliminarEntrenador : Form
    {
        private string rutaArchivo;

        // Constructor que acepta la ruta del archivo CSV
        public EliminarEntrenador(string rutaArchivo)
        {
            InitializeComponent();
            this.rutaArchivo = rutaArchivo; // Asigna la ruta del archivo a la variable de instancia
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "entrenadores.csv"; // Ruta del archivo CSV
            string nombreEntrenadorAEliminar = txtNombreEntrenador.Text.Trim(); // Obtener el nombre del entrenador

            if (string.IsNullOrEmpty(nombreEntrenadorAEliminar))
            {
                MessageBox.Show("Por favor, ingresa el nombre del entrenador a eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si el archivo existe
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Leer todas las líneas del archivo
            var lineas = File.ReadAllLines(rutaArchivo).ToList();

            // Filtrar las líneas para excluir el entrenador a eliminar
            var lineasFiltradas = lineas.Where(linea => !linea.StartsWith(nombreEntrenadorAEliminar + ",")).ToList();

            // Verificar si se eliminó alguna línea
            if (lineas.Count == lineasFiltradas.Count)
            {
                MessageBox.Show("El entrenador no fue encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Escribir de nuevo las líneas filtradas en el archivo
            using (StreamWriter sw = new StreamWriter(rutaArchivo, false)) // El segundo parámetro es 'false' para sobrescribir el archivo
            {
                foreach (var linea in lineasFiltradas)
                {
                    sw.WriteLine(linea);
                }
            }

            MessageBox.Show("Entrenador eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar el TextBox
            txtNombreEntrenador.Clear();

            // Volver al menú principal
            this.DialogResult = DialogResult.OK; // Establecer el resultado del diálogo
            this.Close(); // Cerrar el formulario
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
        }
    }
}