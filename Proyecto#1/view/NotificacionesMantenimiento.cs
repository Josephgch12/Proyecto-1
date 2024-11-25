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
    public partial class NotificacionesMantenimiento : Form
    {
        private string rutaArchivo; // Ruta del archivo CSV

        public NotificacionesMantenimiento(string rutaArchivo)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            this.rutaArchivo = rutaArchivo; // Guarda la ruta del archivo CSV
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            comboBoxMaquinas.Items.Clear(); // Limpiar el ComboBox

            if (File.Exists(rutaArchivo))
            {
                var lineas = File.ReadAllLines(rutaArchivo).Skip(1); // Saltar encabezados

                foreach (var linea in lineas)
                {
                    // Omitir la línea de encabezado si aparece de nuevo
                    if (linea.Trim() == "ID de Maquina,Nombre de Maquina,Tipo de Maquina,Fecha de Adquisicion,Vida util,Estado")
                    {
                        continue; // Omitir esta línea
                    }

                    var datos = linea.Split(',');

                    if (datos.Length >= 6)
                    {
                        string idMaquina = datos[0].Trim();
                        string nombreMaquina = datos[1].Trim();
                        string tipoMaquina = datos[2].Trim();
                        string estado = datos[5].Trim();

                        string vidaUtilStr = datos[4].Trim();
                        MessageBox.Show($"Intentando convertir la vida útil: '{vidaUtilStr}'");

                        // Intentar convertir la vida útil
                        if (int.TryParse(vidaUtilStr, out int vidaUtil))
                        {
                            // Aquí puedes definir la lógica que necesites para filtrar
                            if (vidaUtil <= 3) // Cambia esta condición según tus necesidades
                            {
                                comboBoxMaquinas.Items.Add($"{idMaquina} - {nombreMaquina} (Tipo: {tipoMaquina}, Estado: {estado})");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"La vida útil de la máquina '{nombreMaquina}' no es un número válido: '{vidaUtilStr}'");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"La línea no tiene suficientes datos: '{linea}'");
                    }
                }

                if (comboBoxMaquinas.Items.Count == 0)
                {
                    MessageBox.Show("No hay máquinas a 3 meses o menos de cumplir su vida útil.");
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }
        }
    }
}