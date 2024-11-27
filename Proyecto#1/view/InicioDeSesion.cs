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

        
        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string id = textBoxID.Text;
            string password = textBoxPassword.Text;

            // Validar las credenciales
            string tipoUsuario = ValidarCredenciales(id, password);
            if (tipoUsuario != null)
            {
                MessageBox.Show("Inicio de sesión exitoso como " + tipoUsuario + ".");

                // Crear una instancia del formulario principal y pasar el tipo de usuario
                PaginaPrincipal mainForm = new PaginaPrincipal(tipoUsuario);

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

        private string ValidarCredenciales(string id, string password)
        {
            // Rutas de los archivos CSV
            string rutaArchivoUsuarios = "usuarios_gimnasio.csv";
            string rutaArchivoEntrenadores = "addEntrenadores.csv";

            // Verificar si los archivos existen
            if (!File.Exists(rutaArchivoUsuarios) || !File.Exists(rutaArchivoEntrenadores))
            {
                MessageBox.Show("Uno o más archivos de usuarios no se encuentran.");
                return null;
            }

            // Definir la fecha de inicio
            DateTime fechaInicio = new DateTime(2024, 11, 20);

            // Leer el archivo de usuarios y validar las credenciales
            var lineasUsuarios = File.ReadAllLines(rutaArchivoUsuarios);
            foreach (var linea in lineasUsuarios.Skip(1)) // Saltar la cabecera
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
                            return "Cliente"; // Credenciales válidas para cliente
                        }
                    }
                }
            }

            // Leer el archivo de entrenadores y validar las credenciales
            var lineasEntrenadores = File.ReadAllLines(rutaArchivoEntrenadores);
            foreach (var linea in lineasEntrenadores.Skip(1)) // Saltar la cabecera
            {
                var partes = linea.Split(',');
                if (partes.Length == 5) // Asegúrate de que el número de columnas sea correcto
                {
                    string idArchivo = partes[0].Trim(); // ID está en la primera columna
                    string passwordArchivo = partes[4].Trim(); // Contraseña está en la última columna

                    if (idArchivo == id && passwordArchivo == password)
                    {
                        return "Entrenador"; // Credenciales válidas para entrenador
                    }
                }
            }

            return null; // Credenciales no válidas
        }
    }
}
