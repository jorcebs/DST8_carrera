using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

            Corredor c1 = new Corredor();
            Corredor c2 = new Corredor();

            txtResult.Text += "c1 = " + c1.distancia.ToString() + "\t c2 = " + c2.distancia.ToString() + Environment.NewLine;

            while (c1.distancia < 100 && c2.distancia < 100)
            {
                c1.Correr();
                c2.Correr();
                txtResult.Text += "c1 = " + c1.distancia.ToString() + "\t c2 = " + c2.distancia.ToString() + Environment.NewLine;
            }       

            if (c1.distancia >= 100 && c2.distancia >= 100)
                txtResult.Text += "¡¡¡ES UN EMPATE!!!";
            else if (c1.distancia >= 100)
                txtResult.Text += "¡¡¡GANA c1!!!";
            else
                txtResult.Text += "¡¡¡GANA c2!!!";
        }
    }
}