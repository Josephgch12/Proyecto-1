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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string idBuscado = textBoxId.Text.Trim();
            if (string.IsNullOrEmpty(idBuscado))
            {
                MessageBox.Show("Por favor, ingresa un ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            comboBoxClases.Items.Clear(); // Limpiar el ComboBox antes de buscar
            bool encontrado = false;

            if (File.Exists(rutaArchivoReservas))
            {
                var lineas = File.ReadAllLines(rutaArchivoReservas);
                foreach (var linea in lineas)
                {
                    var partes = linea.Split(',');
                    if (partes.Length >= 4 && partes[3].Trim() == idBuscado) 
                    {
                        comboBoxClases.Items.Add(linea); // Agregar la reserva al ComboBox
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ninguna reserva con ese ID.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
}
}
