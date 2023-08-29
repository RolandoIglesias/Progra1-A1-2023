using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1
{
    public partial class Form1 : Form
    {
        String[][] TiposConversores = new string[][] {
       new string[] {"Pie cuadrado", "Vara cuadrada", "Yarda cuadrada", "Metro cuadrado", "Tareas", "Manzanas", "Hectarias" },
      };


        public Form1()
        {
            InitializeComponent();
        }



        private void CboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            Cbo_Lo_Que_Quiere_Convertir.Items.Clear();
            Cbo_Lo_Que_Quiere_Convertir.Items.AddRange(TiposConversores[Cbo_Tipo_Conversor.SelectedIndex]);

            Cbo_A_Convertir.Items.Clear();
            Cbo_A_Convertir.Items.AddRange(TiposConversores[Cbo_Tipo_Conversor.SelectedIndex]);

        }

        private void Btn_ConvertirConversores_Click(object sender, EventArgs e)
        {

            int de = 0, a = 0;
            double cantidad = 0, respuesta = 0;
            de = Cbo_Lo_Que_Quiere_Convertir.SelectedIndex;
            a = Cbo_A_Convertir.SelectedIndex;

            cantidad = double.Parse(txt_Cantidad.Text);

            double[][] monedas = {
            new double []{0.09290304, 0.698896, 0.836127, 1, 437.5, 7000, 10.000, },
           };
            respuesta = monedas[Cbo_Tipo_Conversor.SelectedIndex][de] / monedas[Cbo_Tipo_Conversor.SelectedIndex][a] * cantidad;

            Lbl_Respuesta.Text = "Respuesta: " + Math.Round(respuesta, 4);
        }
    }
    
}
