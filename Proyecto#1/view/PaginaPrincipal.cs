using Proyecto_1.modelos;
using Proyecto_1.view;
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

namespace Proyecto_1
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }
     

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario AgregarCliente y pasar la ruta del archivo CSV.
            AgregarCliente agregarClienteForm = new AgregarCliente("usuarios_gimnasio.csv");

            // Mostrar el formulario como un diálogo modal.
            agregarClienteForm.ShowDialog();

        }

        private void inicioDeSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario EliminarCliente y pasar la ruta del archivo CSV.
            EliminarCliente eliminarClienteForm = new EliminarCliente("usuarios_gimnasio.csv");

            // Mostrar el formulario como un diálogo modal.
            eliminarClienteForm.ShowDialog();
        }

        private void agregarEntrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario AgregarEntrenador y pasar la ruta del archivo CSV.
            AgregarEntrenador agregarEntrenadorForm = new AgregarEntrenador("entrenadores.csv");

            // Mostrar el formulario como un diálogo modal.
            agregarEntrenadorForm.ShowDialog();
        }

        private void eliminarEntrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            EliminarEntrenador eliminarEntrenadorForm = new EliminarEntrenador("entrenadores.csv");

            // Muestra el formulario
            eliminarEntrenadorForm.ShowDialog(); // Esto abre el formulario como un cuadro de diálogo modal
        }

        private void matricularClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Especificar la ruta del archivo CSV
            string rutaArchivoEntrenadores = "entrenadores.csv"; 

            // Crear una instancia del formulario MatricularClase y pasar la ruta del archivo
            MatricularClase matricularClaseForm = new MatricularClase(rutaArchivoEntrenadores);

            // Mostrar el formulario
            matricularClaseForm.ShowDialog(); 
        }

        private void eliminarSuClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /// Especificar la ruta del archivo CSV de reservas
            string rutaArchivoReservas = "reservas.csv";

            // Verificar si el archivo existe
            if (!File.Exists(rutaArchivoReservas))
            {
                MessageBox.Show("El archivo de reservas no se encuentra. Por favor, verifica la ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear una instancia del formulario EliminarClase y pasar la ruta del archivo
            EliminarClase eliminarClaseForm = new EliminarClase(rutaArchivoReservas);
            eliminarClaseForm.ShowDialog(); // Mostrar el formulario como un diálogo modal

        }

        private void consultarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Especificar la ruta del archivo CSV 
            string rutaArchivoMaquinas = "inventario_gimnasio.csv";

            // Crear una instancia del formulario ConsultarMaquinas
            ConsultarMaquinas consultarForm = new ConsultarMaquinas();

            // Mostrar el formulario
            consultarForm.ShowDialog();
        }

        private void agregarMaquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string rutaArchivoMaquinas = "inventario_gimnasio.csv";

            // Crear una instancia del formulario AgregarMaquina
            AgregarMaquina agregarForm = new AgregarMaquina();

            // Mostrar el formulario
            agregarForm.ShowDialog();
        }

        private void elimarMaquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string rutaArchivoMaquinas = "inventario_gimnasio.csv";

            // Crear una instancia del formulario EliminarMaquina y pasar la ruta del archivo
            EliminarMaquina eliminarForm = new EliminarMaquina(rutaArchivoMaquinas);

            // Mostrar el formulario
            eliminarForm.ShowDialog();
        }

        private void notificacionesDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "inventario_gimnasio.csv";
            NotificacionesMantenimiento notificacionesForm = new NotificacionesMantenimiento(rutaArchivo);
            notificacionesForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }

        private void consultarMembresiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "usuarios_gimnasio.csv"; // Ruta del archivo CSV
            ConsultarMembresia consultarMembresiaForm = new ConsultarMembresia(rutaArchivo);
            consultarMembresiaForm.Show(); // Muestra el formulario
        }

        private void reportesDeMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ruta del archivo CSV
            string rutaArchivo = "usuarios_gimnasio.csv";

            // Crear una instancia del formulario reportesMatricula y pasar la ruta del archivo
            reportesMatricula reportesMatriculaForm = new reportesMatricula(rutaArchivo);

            // Mostrar el formulario
            reportesMatriculaForm.Show();
        }

        private void informeContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ruta del archivo CSV
            string rutaArchivo = "inventario_gimnasio.csv"; 

            // Crear una instancia del formulario informeContable y pasar la ruta del archivo
            informeContable informeContableForm = new informeContable(rutaArchivo);

            // Mostrar el formulario
            informeContableForm.Show(); // Usar Show para mostrar el formulario
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "Facturas";
            GenerarFactura generarFacturaForm = new GenerarFactura();
            // Mostrar el formulario
            generarFacturaForm.ShowDialog();
        }

        private void historiaDeLasClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "reservasClases .csv"; 

            // Crear una instancia del formulario FormHistorialClases
            FormHistorialClases historialClasesForm = new FormHistorialClases();

            // Mostrar el formulario
            historialClasesForm.ShowDialog();
        }
    }
    }

