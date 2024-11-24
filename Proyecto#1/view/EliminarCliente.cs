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
    public partial class EliminarCliente : Form
    {
        private string rutaArchivo;

        public EliminarCliente(string rutaArchivo)
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
            this.rutaArchivo = rutaArchivo; // Guarda la ruta del archivo CSV.
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtid.Text; // Obtener el ID del TextBox.

            // Validar que el campo no esté vacío.
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                return;
            }

            // Eliminar el cliente del archivo CSV.
            if (EliminarClienteDelArchivo(id))
            {
                MessageBox.Show("Cliente eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("No se encontró un cliente con ese ID.");
            }

            this.Close(); // Cierra el formulario.
        }

        private bool EliminarClienteDelArchivo(string id)
        {
            // Leer todas las líneas del archivo CSV.
            var lineas = File.ReadAllLines(rutaArchivo).ToList();

            // Verificar si hay encabezados
            if (lineas.Count == 0)
            {
                return false; // El archivo está vacío
            }

            // Buscar la línea que contiene el ID del cliente.
            var encabezados = lineas[0]; // Guardar encabezados
            var lineasSinEncabezados = lineas.Skip(1).ToList(); // Saltar encabezados
            var clienteAEliminar = lineasSinEncabezados.FirstOrDefault(linea => linea.StartsWith(id + ","));

            if (clienteAEliminar != null)
            {
                // Eliminar la línea correspondiente.
                lineas.Remove(clienteAEliminar);
                // Escribir de nuevo el archivo CSV sin el cliente eliminado.
                File.WriteAllLines(rutaArchivo, new[] { encabezados }.Concat(lineas));
                return true; // Cliente eliminado con éxito.
            }

            return false; // No se encontró el cliente.
        }
}
}