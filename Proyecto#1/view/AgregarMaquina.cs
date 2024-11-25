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
        // Especificar la ruta del archivo CSV de máquinas
        private const string rutaArchivoMaquinas = "inventario_gimnasio.csv";

        public AgregarMaquina()
        {
            InitializeComponent();
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

            // Crear la nueva línea para el archivo CSV
            string nuevaMaquina = $"{id},{nombre},{tipo},{fechaAdquisicion},{vidaUtil},{estado}";

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
