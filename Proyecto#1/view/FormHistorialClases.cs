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
    public partial class FormHistorialClases : Form
    {
        public FormHistorialClases()
        {
            InitializeComponent();
            CargarHistorialClases();
        }

        private void CargarHistorialClases()
        {
            string rutaArchivo = "reservas.csv"; 

            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo de reservas no existe.");
                return;
            }

            var entrenadores = new Dictionary<string, int>();
            var historial = new List<string>();

            using (var reader = new StreamReader(rutaArchivo))
            {
                // Leer la cabecera
                string cabecera = reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var linea = reader.ReadLine();
                    var columnas = linea.Split(',');

                    if (columnas.Length > 0)
                    {
                        string nombreEntrenador = columnas[0].Trim(); 

                        if (!string.IsNullOrWhiteSpace(nombreEntrenador))
                        {
                            if (entrenadores.ContainsKey(nombreEntrenador))
                            {
                                entrenadores[nombreEntrenador]++;
                            }
                            else
                            {
                                entrenadores[nombreEntrenador] = 1;
                            }

                            // Agregar al historial
                            historial.Add(linea);
                        }
                    }
                }
            }

            if (entrenadores.Count == 0)
            {
                MessageBox.Show("Todavía no se han matriculado clases.");
                return;
            }

            var entrenadorFavorito = entrenadores.OrderByDescending(e => e.Value).First();
            txtEntrenadorFavorito.Text = entrenadorFavorito.Key; // Asigna el nombre del entrenador favorito
            txtCantidadClases.Text = entrenadorFavorito.Value.ToString(); // Asigna la cantidad de clases

            // Mostrar el historial en el ListBox
            listBoxHistorial.Items.Clear(); // Limpiar el ListBox antes de agregar nuevos elementos
            foreach (var item in historial)
            {
                listBoxHistorial.Items.Add(item); // Agregar cada línea del historial al ListBox
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }
    }
}