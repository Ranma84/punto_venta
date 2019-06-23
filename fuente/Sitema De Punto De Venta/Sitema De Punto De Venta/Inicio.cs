using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sitema_De_Punto_De_Venta
{
    public partial class Inicio : Form
    {
        public int contador;

        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador <= 100)
            {
                progressBar1.Value = contador;
                contador = contador + 1;
                progressBar1.BackColor = Color.BlueViolet;
                if (contador == 10)
                {
                    Lbl_Leyendas.Text = "..Cargando Fuentes Del Sistema";
                }
                if (contador == 30)
                {
                    Lbl_Leyendas.Text = "..Cargando Formularios";
                }
                if (contador == 50)
                {
                    Lbl_Leyendas.Text = "..Cargando Formularios";
                }
                if (contador == 70)
                {
                    Lbl_Leyendas.Text = "..Cargando La Base De Datos";
                }
                if (contador == 100)
                {
                    Lbl_Leyendas.Text = "..¡Bienvenido Al Sistema!...";
                }
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                Sistema_Principal frm = new Sistema_Principal();
                frm.Show();

            }
        }
    }
}
