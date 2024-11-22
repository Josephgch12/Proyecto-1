﻿using Proyecto_1.modelos;
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
            /// Cambia "entrenadores.csv" por la ruta correcta de tu archivo CSV
            EliminarEntrenador eliminarEntrenadorForm = new EliminarEntrenador("entrenadores.csv");

            // Muestra el formulario
            eliminarEntrenadorForm.ShowDialog(); // Esto abre el formulario como un cuadro de diálogo modal
        }

        private void matricularClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Especificar la ruta del archivo CSV de entrenadores
            string rutaArchivoEntrenadores = "entrenadores.csv"; 

            // Crear una instancia del formulario MatricularClase y pasar la ruta del archivo
            MatricularClase matricularClaseForm = new MatricularClase(rutaArchivoEntrenadores);

            // Mostrar el formulario
            matricularClaseForm.ShowDialog(); 
        }
    }
}
