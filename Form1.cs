using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L9_JRRA_1087121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string marca, disponible;
            int precio, cambio, descuento, modelo;

            if (!int.TryParse(text_modelo.Text, out int num))
            {
                MessageBox.Show("Debe ingresar un modelo de carro con números");
            }
            else
            {
                if (!int.TryParse(text_precio.Text, out int num2))
                {
                    MessageBox.Show("Debe ingresar un precio con números");
                }
                else
                {
                    if (!int.TryParse(text_dolar.Text, out int num3))
                    {
                        MessageBox.Show("Debe ingresar un número de cambio a dolar");
                    }
                    else
                    {
                        if (!int.TryParse(text_descuento.Text, out int num4))
                        {
                            MessageBox.Show("Debe ingresar un descuento con números");
                        }
                        else
                        {
                            modelo = Convert.ToInt32(text_modelo.Text);
                            precio = Convert.ToInt32(text_precio.Text);
                            cambio = Convert.ToInt32(text_dolar.Text);
                            descuento = Convert.ToInt32(text_descuento.Text);

                            if (!int.TryParse(text_marca.Text, out int num5))
                            {
                                MessageBox.Show("Debe ingresar una marca de carro en letras");
                            }
                            else
                            {
                                if (!int.TryParse(text_disponible.Text, out int num6))
                                {
                                    MessageBox.Show("Debe ingresar la disponibilidad en letras");
                                }
                                else
                                {
                                    marca = Convert.ToString(text_marca.Text);
                                    disponible = Convert.ToString(text_disponible.Text);

                                    lbl_datos.Text = modelo.ToString();
                                    lbl_datos.Text = precio.ToString();
                                    lbl_datos.Text = marca.ToString();
                                    lbl_datos.Text = disponible.ToString();
                                    lbl_datos.Text = cambio.ToString();
                                    lbl_datos.Text = descuento.ToString();
                                }
                            }
                        }
                     }
                }
            }
        }

        private void lmp_limpiar_Click(object sender, EventArgs e)
        {
            text_modelo.Clear();
            text_marca.Clear();
            text_precio.Clear();
            text_dolar.Clear();
            text_disponible.Clear();
            text_descuento.Clear();
            lbl_datos.Text = "";
        }
    }
}
