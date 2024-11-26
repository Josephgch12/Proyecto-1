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
    
    public partial class informeContable : Form
    {
        private string rutaArchivo; // Campo para almacenar la ruta del archivo

        // Constructor que acepta la ruta del archivo
        public informeContable(string rutaArchivo)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            this.rutaArchivo = rutaArchivo; // Asigna la ruta del archivo a la variable de instancia
        }

        private void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            {
                if (File.Exists(rutaArchivo))
                {
                    txtResultados.Clear(); // Limpiar el TextBox de resultados

                    // Obtener las fechas de los TextBox
                    if (DateTime.TryParse(txtFechaInicio.Text.Trim(), out DateTime fechaInicio) &&
                        DateTime.TryParse(txtFechaFin.Text.Trim(), out DateTime fechaFin))
                    {
                        var lineas = File.ReadAllLines(rutaArchivo).Skip(1); // Saltar encabezados

                        // Inicializar contadores para los totales
                        decimal totalIngresos = 0;
                        decimal totalEgresos = 0;

                        foreach (var linea in lineas)
                        {
                            var datos = linea.Split(',');

                            if (datos.Length >= 8) // Asegurarse de que hay suficientes columnas
                            {
                                string fechaAdquisicionStr = datos[3].Trim(); // Obtenemos la fecha de adquisición
                                if (DateTime.TryParse(fechaAdquisicionStr, out DateTime fechaAdquisicion))
                                {
                                    // Verificar si la fecha de adquisición está dentro del rango
                                    if (fechaAdquisicion >= fechaInicio && fechaAdquisicion <= fechaFin)
                                    {
                                        // Sumar ingresos y egresos
                                        totalIngresos += decimal.Parse(datos[6].Trim());
                                        totalEgresos += decimal.Parse(datos[7].Trim());
                                    }
                                }
                            }
                        }

                        // Mostrar resultados
                        txtResultados.AppendText($"Total Ingresos: {totalIngresos}\n");
                        txtResultados.AppendText($"Total Egresos: {totalEgresos}\n");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese fechas válidas.");
                    }
                }
                else
                {
                    MessageBox.Show("El archivo no existe.");
                }
            }
    }
    }
}
