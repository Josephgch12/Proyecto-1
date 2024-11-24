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
    public partial class EliminarClase : Form
    {
        private string rutaArchivoReservas;

        public EliminarClase(string ruta)
        {
            InitializeComponent();
            rutaArchivoReservas = ruta;
            CargarReservas();
        }

        private void CargarReservas()
        {
            if (File.Exists(rutaArchivoReservas))
            {
                var lineas = File.ReadAllLines(rutaArchivoReservas);
                comboBoxClases.Items.Clear(); // Limpiar elementos existentes

                foreach (var linea in lineas)
                {
                    // Agregar cada reserva al ComboBox
                    comboBoxClases.Items.Add(linea);
                }
            }
            else
            {
                MessageBox.Show("El archivo de reservas no se encuentra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       
        private void comboBoxClases_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxClases.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una reserva para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reservaSeleccionada = comboBoxClases.SelectedItem.ToString();
            var lineas = File.ReadAllLines(rutaArchivoReservas).ToList();

            // Eliminar la reserva seleccionada
            lineas.Remove(reservaSeleccionada);
            File.WriteAllLines(rutaArchivoReservas, lineas);

            MessageBox.Show("Reserva eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarReservas(); // Recargar las reservas en el ComboBox
        }
    }
}
