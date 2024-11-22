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
using Proyecto_1.modelos;

namespace Proyecto_1.view
{
    public partial class MatricularClase : Form
    {
        private List<Entrenador> entrenadores; // Lista de entrenadores
        private string rutaArchivo; // Ruta del archivo CSV

        public MatricularClase(string rutaArchivo)
        {
            InitializeComponent();
            this.rutaArchivo = rutaArchivo; // Guardar la ruta del archivo
            entrenadores = new List<Entrenador>(); // Inicializar la lista
            CargarEntrenadores(); // Cargar entrenadores desde el archivo
        }

        private void CargarEntrenadores()
        {
            if (File.Exists(rutaArchivo))
            {
                var lineas = File.ReadAllLines(rutaArchivo);
                foreach (var linea in lineas.Skip(1)) // Saltar la cabecera
                {
                    var partes = linea.Split(',');
                    if (partes.Length >= 3)
                    {
                        var entrenador = new Entrenador(partes[0].Trim(), partes[1].Trim(), partes[2].Trim());
                        entrenadores.Add(entrenador); // Agregar el objeto Entrenador a la lista
                    }
                }
                comboBoxEntrenadores.DataSource = entrenadores; // Asignar la lista al ComboBox
            }
            else
            {
                MessageBox.Show("El archivo de entrenadores no se encuentra.");
            }
        }




        private void btnMatricular_Click(object sender, EventArgs e)
        {
            {
                string entrenadorSeleccionado = comboBoxEntrenadores.SelectedItem.ToString();
                string fechaMatricula = DateTime.Now.ToString("yyyy-MM-dd"); // Fecha actual

                // Guardar en reservas.csv
                using (StreamWriter sw = new StreamWriter("reservas.csv", true)) // true para agregar al archivo
                {
                    sw.WriteLine($"{entrenadorSeleccionado},{fechaMatricula}"); // Guardar el entrenador y la fecha
                }

                MessageBox.Show("Matrícula guardada exitosamente.");
            }
        }
    }
}