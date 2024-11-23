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
    public partial class EliminarClase : Form
    {
        private string rutaArchivo; // Ruta del archivo CSV
        private string usuarioActual; // Email o ID del usuario que inicia sesión

        public EliminarClase(string rutaArchivo, string usuarioActual)
        {
            InitializeComponent();
            this.rutaArchivo = rutaArchivo;
            this.usuarioActual = usuarioActual;
            CargarClases(); // Cargar clases del usuario
        }

        private void CargarClases()
        {
            if (File.Exists(rutaArchivo))
            {
                var lineas = File.ReadAllLines(rutaArchivo);
                var clasesUsuario = lineas
                    .Where(linea => linea.StartsWith(usuarioActual + ",")) // Filtrar por nombre de usuario
                    .Select(linea =>
                    {
                        var partes = linea.Split(',');
                        return $"{partes[1]} - {partes[2].Trim('"')}"; // Obtener solo el nombre de la clase y el horario
                    })
                    .Distinct() // Asegurarse de que no haya duplicados
                    .ToList();

                comboBoxReservas.DataSource = clasesUsuario; // Asignar al ComboBox
            }
            else
            {
                MessageBox.Show("El archivo de reservas no se encuentra.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string claseSeleccionada = comboBoxReservas.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(claseSeleccionada))
            {
                MessageBox.Show("Por favor, seleccione una clase válida.");
                return;
            }

            if (EliminarClaseDelArchivo(claseSeleccionada))
            {
                MessageBox.Show("Clase eliminada exitosamente.");
                CargarClases(); // Recargar clases después de la eliminación
            }
            else
            {
                MessageBox.Show("No se encontró la clase seleccionada.");
            }

            this.Close(); // Cierra el formulario.
        }
        private bool EliminarClaseDelArchivo(string clase)
        {
            var lineas = File.ReadAllLines(rutaArchivo).ToList();

            // Filtrar las líneas que no corresponden al usuario y a la clase seleccionada
            var lineasActualizadas = lineas
                .Where(linea => !(linea.StartsWith(usuarioActual + ",") && linea.Contains(clase.Split('-')[0].Trim())))
                .ToList();

            // Solo escribimos el archivo si hay cambios
            if (lineas.Count != lineasActualizadas.Count)
            {
                File.WriteAllLines(rutaArchivo, lineasActualizadas);
                return true; // Clase eliminada con éxito.
            }

            return false; // No se encontró la clase.
        }
    }

}
