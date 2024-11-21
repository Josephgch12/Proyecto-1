using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;


namespace Proyecto_1.view
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string id = textBoxID.Text;
            string password = textBoxPassword.Text;

            // Validar las credenciales
            if (ValidarCredenciales(id, password))
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                // Crear una instancia del formulario principal
                PaginaPrincipal mainForm = new PaginaPrincipal();

                // Mostrar el formulario principal
                mainForm.Show();

                // Ocultar el formulario de inicio de sesión
                this.Hide();


            }
            else
            {
                MessageBox.Show("ID o contraseña incorrectos. Inténtalo de nuevo.");
            }
        }

        private bool ValidarCredenciales(string id, string password)
        {
            // Ruta del archivo CSV
            string rutaArchivo = "usuarios_gimnasio.csv";

            // Verificar si el archivo existe
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo de usuarios no se encuentra.");
                return false;
            }

            // Definir la fecha de inicio
            DateTime fechaInicio = new DateTime(2024, 11, 20);

            // Leer el archivo CSV y validar las credenciales
            var lineas = File.ReadAllLines(rutaArchivo);
            foreach (var linea in lineas.Skip(1)) // Saltar la cabecera
            {
                var partes = linea.Split(',');
                if (partes.Length == 6) // Asegúrate de que el número de columnas sea correcto
                {
                    string idArchivo = partes[0].Trim(); // ID está en la primera columna
                    string passwordArchivo = partes[4].Trim(); // Contraseña está en la última columna
                    DateTime fechaVencimiento;

                    // Intentar parsear la fecha de vencimiento
                    if (DateTime.TryParse(partes[5].Trim(), out fechaVencimiento))
                    {
                        if (idArchivo == id && passwordArchivo == password)
                        {
                            // Verificar si la fecha de vencimiento está a 5 días o menos desde la fecha de inicio
                            if ((fechaVencimiento - fechaInicio).TotalDays <= 5)
                            {
                                MessageBox.Show("Su mensualidad se encuentra al cobro. Fecha de vencimiento: " + fechaVencimiento.ToShortDateString());
                            }
                            return true; // Credenciales válidas
                        }
                    }
                }
            }

            return false; // Credenciales no válidas
        }

    }
}

