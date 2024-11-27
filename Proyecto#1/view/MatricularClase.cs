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
        private string rutaArchivoEntrenadores; // Ruta del archivo CSV
        private string rutaArchivoReservas; // Ruta del archivo CSV de reservas
        private string rutaArchivoReservasClases;

        public MatricularClase(string rutaArchivoEntrenadores, string rutaArchivoReservas, string rutaArchivoReservasClases)
        {
            InitializeComponent();
            this.rutaArchivoEntrenadores = rutaArchivoEntrenadores; // Guardar la ruta del archivo
            this.rutaArchivoReservas = rutaArchivoReservas; // Guardar la ruta del archivo de reservas
            this.rutaArchivoReservasClases = rutaArchivoReservasClases; 
            entrenadores = new List<Entrenador>(); // Inicializar la lista
            CargarEntrenadores(); // Cargar entrenadores desde el archivo
        }

        private void CargarEntrenadores()
        {
            if (File.Exists(rutaArchivoEntrenadores))
            {
                var lineas = File.ReadAllLines(rutaArchivoEntrenadores);
                foreach (var linea in lineas.Skip(1)) // Saltar la cabecera
                {
                    var partes = linea.Split(',');
                    if (partes.Length >= 4) 
                    {
                        var entrenador = new Entrenador(partes[0].Trim(), partes[1].Trim(), partes[2].Trim(), partes[3].Trim()); // ID al final
                        entrenadores.Add(entrenador); // Agregar el objeto Entrenador a la lista
                    }
                }
                comboBoxEntrenadores.DataSource = entrenadores; // Asignar la lista al ComboBox
                comboBoxEntrenadores.DisplayMember = "DisplayInfo"; // Mostrar la información combinada
                comboBoxEntrenadores.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("El archivo de entrenadores no se encuentra.");
            }
        }




        private void btnMatricular_Click(object sender, EventArgs e)
        {
            {
                var entrenadorSeleccionado = (Entrenador)comboBoxEntrenadores.SelectedItem; // Obtener el objeto Entrenador
                if (entrenadorSeleccionado != null) // Verificar que se haya seleccionado un entrenador
                {
                    // Guardar en reservas.csv
                    using (StreamWriter sw = new StreamWriter("reservas.csv", true)) // true para agregar al archivo
                    {
                        sw.WriteLine($"{entrenadorSeleccionado.Nombre},{entrenadorSeleccionado.PuntosFuertes},{entrenadorSeleccionado.Horarios},{entrenadorSeleccionado.Id}"); // Acceder a las propiedades del objeto Entrenador
                    }

                    // Guardar en reservasClases.csv
                    using (StreamWriter sw = new StreamWriter("reservasClases.csv", true)) // true para agregar al archivo
                    {
                        sw.WriteLine($"{entrenadorSeleccionado.Nombre},{entrenadorSeleccionado.PuntosFuertes},{entrenadorSeleccionado.Horarios},{entrenadorSeleccionado.Id}"); // Acceder a las propiedades del objeto Entrenador
                    }

                    MessageBox.Show("Matrícula guardada exitosamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un entrenador.");
                }
        }
    }

        private void MatricularClase_Load(object sender, EventArgs e)
        {

        }
    }
}