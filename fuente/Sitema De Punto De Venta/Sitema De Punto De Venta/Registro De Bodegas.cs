using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sitema_De_Punto_De_Venta
{
    public partial class Registro_De_Bodegas : Form
    {
        public Registro_De_Bodegas()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Fecha_Hora1_Tick(object sender, EventArgs e)
        {
            Lbl_Fecha_Hora.Text = DateTime.Now.ToShortDateString();
            Lbl_Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void Registro_De_Bodegas_Load(object sender, EventArgs e)
        {

        }

        private void But_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void But_Minimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
