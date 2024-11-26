using Proyecto_1.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1.view
{
    public partial class GenerarFactura : Form
    {
        private ServicioFacturacion servicioFacturacion;

        public GenerarFactura()
        {
            InitializeComponent();
            servicioFacturacion = new ServicioFacturacion();
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            string clienteId = txtClienteId.Text; // TextBox para el ID del cliente
            if (decimal.TryParse(txtMonto.Text, out decimal monto) && !string.IsNullOrWhiteSpace(clienteId))
            {
                string descripcion = txtDescripcion.Text; // TextBox para la descripción
                servicioFacturacion.GenerarFactura(clienteId, monto, descripcion);
                MessageBox.Show("Factura generada exitosamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido y un ID de cliente.");
            }
        }

        private void btnConsultarFacturas_Click(object sender, EventArgs e)
        {
            List<Factura> facturas = servicioFacturacion.CargarFacturas();
            dgvFacturas.DataSource = facturas; // DataGridView para mostrar las facturas
        }
        private void LimpiarCampos()
        {
            txtClienteId.Clear();
            txtMonto.Clear();
            txtDescripcion.Clear();
        }
}
}