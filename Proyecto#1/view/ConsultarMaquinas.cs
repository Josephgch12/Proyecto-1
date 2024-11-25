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
    public partial class ConsultarMaquinas : Form
    {
        // Especificar la ruta del archivo CSV de máquinas
        private const string rutaArchivoMaquinas = "inventario_gimnasio.csv";

        public ConsultarMaquinas()
        {
            InitializeComponent();
            CargarMaquinas(); // Cargar las máquinas al inicializar el formulario
        }

        private void CargarMaquinas()
        {
            listBoxMaquinas.Items.Clear(); // Limpiar el ListBox antes de cargar
            if (File.Exists(rutaArchivoMaquinas))
            {
                // Leer todas las líneas del archivo CSV
                var lineas = File.ReadAllLines(rutaArchivoMaquinas);
                foreach (var linea in lineas)
                {
                    // Agregar cada máquina al ListBox
                    listBoxMaquinas.Items.Add(linea);
                }
            }
            else
            {
                // Mostrar un mensaje de error si el archivo no se encuentra
                MessageBox.Show("El archivo de máquinas no se encuentra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            // Llamar al método para cargar las máquinas nuevamente
            CargarMaquinas();
        }

        private void ConsultarMaquinas_Load(object sender, EventArgs e)
        {

        }
    }
}