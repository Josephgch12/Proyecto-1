using Proyecto_1.controladores;
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
    public partial class ConsultarMembresia : Form
    {
        private MembresiaController membresiaController;

        // Constructor que acepta la ruta del archivo
        public ConsultarMembresia(string rutaArchivo)
        {
            InitializeComponent();
            membresiaController = new MembresiaController(rutaArchivo); // Pasar la ruta al controlador
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            {
                // Validar que el texto ingresado sea un número
                if (int.TryParse(textBoxID.Text, out int id))
                {
                    // Obtener la membresía por ID
                    var membresia = membresiaController.ObtenerMembresiaPorId(id);
                    if (membresia != null)
                    {
                        // Mostrar el tiempo restante
                        var tiempoRestante = membresia.TiempoRestante();
                        labelResultado.Text = $"Tiempo restante para {membresia.Nombre}: {tiempoRestante}";
                    }
                    else
                    {
                        labelResultado.Text = "Membresía no encontrada.";
                    }
                }
                else
                {
                    labelResultado.Text = "Por favor, ingresa un ID válido.";
                }
            }
        }
    }
}