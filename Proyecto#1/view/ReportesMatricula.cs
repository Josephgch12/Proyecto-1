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
using CsvHelper;
using System.IO;
using Proyecto_1.modelos;
using System.Globalization;
namespace Proyecto_1.view
{


    public partial class reportesMatricula : Form
    {
        private string rutaArchivo; // Campo para almacenar la ruta del archivo
        private DateTime fechaReferencia = new DateTime(2024, 11, 20); // Fecha de referencia

        // Constructor que acepta la ruta del archivo
        public reportesMatricula(string rutaArchivo)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            this.rutaArchivo = rutaArchivo; // Asigna la ruta del archivo a la variable de instancia
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (File.Exists(rutaArchivo))
                {
                    if (File.Exists(rutaArchivo))
                    {
                        txtResultados.Clear(); // Limpiar el TextBox de resultados
                        var lineas = File.ReadAllLines(rutaArchivo).Skip(1); // Saltar encabezados

                        int contadorMatriculas = 0; // Contador de matrículas válidas

                        foreach (var linea in lineas)
                        {
                            var datos = linea.Split(',');

                            if (datos.Length >= 6) // Asegurarse de que hay suficientes columnas
                            {
                                string fechaVencimientoStr = datos[5].Trim();
                                if (DateTime.TryParse(fechaVencimientoStr, out DateTime fechaVencimiento))
                                {
                                    // Contar matrículas con fecha de vencimiento posterior a la fecha de referencia
                                    if (fechaVencimiento > fechaReferencia)
                                    {
                                        contadorMatriculas++;
                                        txtResultados.AppendText($"ID: {datos[0]}, Nombre: {datos[1]}, Correo: {datos[2]}, Tipo: {datos[3]}, Fecha de Vencimiento: {fechaVencimiento.ToShortDateString()}\n");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"La fecha de vencimiento '{fechaVencimientoStr}' no es válida para el usuario '{datos[1]}'.");
                                }
                            }
                            else
                            {
                                MessageBox.Show($"La línea no tiene suficientes datos: '{linea}'");
                            }
                        }

                        // Mostrar el resultado final
                        if (contadorMatriculas > 0)
                        {
                            MessageBox.Show($"Se encontraron {contadorMatriculas} matrículas con fecha de vencimiento posterior al 20/11/2024, entonces la matricula a crecido");
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron matrículas con fecha de vencimiento posterior al 20/11/2024.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El archivo no existe en la ruta especificada.");
                    }
                }
            }
        }
    }




