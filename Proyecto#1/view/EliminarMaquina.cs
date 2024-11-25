using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_1.view
{
    public partial class EliminarMaquina : Form
    {
        private string rutaArchivo; // Variable para almacenar la ruta del archivo CSV

        // Constructor que recibe la ruta del archivo CSV
        public EliminarMaquina(string rutaArchivo)
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            this.rutaArchivo = rutaArchivo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim(); // Obtener el ID del TextBox.

            // Validar que el campo no esté vacío.
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                return;
            }

            // Eliminar la máquina del archivo CSV.
            if (EliminarMaquinaDelArchivo(id))
            {
                MessageBox.Show("Máquina eliminada exitosamente.");
            }
            else
            {
                MessageBox.Show("No se encontró una máquina con ese ID.");
            }

            this.Close(); // Cierra el formulario.
        }


        private bool EliminarMaquinaDelArchivo(string id)
        {
            // Leer todas las líneas del archivo CSV.
            var lineas = File.ReadAllLines(rutaArchivo).ToList();

            // Verificar si hay encabezados
            if (lineas.Count == 0)
            {
                return false; // El archivo está vacío
            }

            // Buscar la línea que contiene el ID de la máquina.
            var encabezados = lineas[0]; // Guardar encabezados
            var lineasSinEncabezados = lineas.Skip(1).ToList(); // Saltar encabezados
            var maquinaAEliminar = lineasSinEncabezados.FirstOrDefault(linea => linea.StartsWith(id + ","));

            if (maquinaAEliminar != null)
            {
                // Eliminar la línea correspondiente.
                lineas.Remove(maquinaAEliminar);
                // Escribir de nuevo el archivo CSV sin la máquina eliminada.
                File.WriteAllLines(rutaArchivo, new[] { encabezados }.Concat(lineas));
                return true; // Máquina eliminada con éxito.
            }

            return false; // No se encontró la máquina.


        }
    }
}
