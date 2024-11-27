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
    public partial class AgregarMaquina : Form
    {
        
        private const string rutaArchivoMaquinas = "inventario_gimnasio.csv";
        private Random random;
        public AgregarMaquina()
        {
            InitializeComponent();
            random = new Random();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            string id = txtID.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string tipo = txtTipo.Text.Trim();
            string fechaAdquisicion = dtpFechaAdquisicion.Value.ToString("yyyy-MM-dd");
            string vidaUtil = txtVidaUtil.Text.Trim();
            string estado = txtEstado.Text.Trim();

            // Validar que todos los campos estén llenos
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(tipo) ||
                string.IsNullOrEmpty(vidaUtil) || string.IsNullOrEmpty(estado))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Generar valores aleatorios para las nuevas columnas
            decimal cantidadIngresos = random.Next(5000, 20001); // Valor aleatorio entre 5000 y 20000
            decimal cantidadEgresos = random.Next(3000, 15001); // Valor aleatorio entre 3000 y 15000

            // Crear la nueva línea para el archivo CSV
            string nuevaMaquina = $"{id},{nombre},{tipo},{fechaAdquisicion},{vidaUtil},{estado},{cantidadIngresos},{cantidadEgresos}";

            // Agregar la nueva máquina al archivo CSV
            File.AppendAllText(rutaArchivoMaquinas, nuevaMaquina + Environment.NewLine);
            MessageBox.Show("Máquina agregada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos después de agregar
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtTipo.Clear();
            txtVidaUtil.Clear();
            txtEstado.Clear();
            dtpFechaAdquisicion.Value = DateTime.Now; // Restablecer a la fecha actual
        }
    }
}
