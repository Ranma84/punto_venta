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
using Cache;

namespace Sitema_De_Punto_De_Venta
{
    public partial class Sistema_Principal : Form
    {
        public Sistema_Principal()
        {
            InitializeComponent();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void BotonDeslizando_Click(object sender, EventArgs e)
        {
            if (Menu_vertical.Width == 269)
            {
                Menu_vertical.Width = 80;
                Panel_Contenedor.BackgroundImage = Properties.Resources.Fondo_Del_Contenedor2;
            }
            else
            {
                Menu_vertical.Width = 269;
                Panel_Contenedor.BackgroundImage = Properties.Resources.Fondo_Del_Contenedor1;               
            }
        }
        private void Icono_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int LX, LY;
        private void Icono_Restaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1303, 777);
            this.Location = new Point(LX, LY);
            //this.WindowState = FormWindowState.Normal;
            But_Maxi.Visible = true ;
            Icono_Restaurar.Visible = false;
        }

        private void Icono_Minimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel_Contenedor_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.Panel_Contenedor.Controls.Count > 0)
                this.Panel_Contenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            fh.StartPosition = FormStartPosition.CenterParent;
            this.Panel_Contenedor.Controls.Add(fh);
            this.Panel_Contenedor.Tag = fh;
            fh.Show();
        }

        private void But_Productos_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new Registro_Usuarios());
            Form frm = new Registro_Productos();
            frm.TopLevel = false;
            frm.Parent = Panel_Contenedor;
            frm.Location = new Point((Panel_Contenedor.Width - frm.Width) / 2, (Panel_Contenedor.Height - frm.Height) / 2);
            frm.Show();
        }

        private void Menu_vertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void But_ventas_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new Ventas());
            Form frm = new Ventas();
            frm.TopLevel = false;
            frm.Parent = Panel_Contenedor;
            frm.Location = new Point((Panel_Contenedor.Width - frm.Width) / 2, (Panel_Contenedor.Height - frm.Height) / 2);
            frm.Show();
        }

        private void Sistema_Principal_Load(object sender, EventArgs e)
        {
            Lbl_Usuario.Text = UserLoginCache.Nombre;
            Lbl_Perfil.Text = UserLoginCache.Perfil;

        }

        private void But_Maxi_Click(object snder, EventArgs e)
        {
            LX = Location.X;
            LY = Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.WindowState = FormWindowState.Maximized;
            But_Maxi.Visible = false;
            Icono_Restaurar.Visible = true;
        }

        private void But_Empleados_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new Registro_Usuarios());
            Form frm = new Registro_Usuarios();
            frm.TopLevel = false;
            frm.Parent = Panel_Contenedor;
            frm.Location = new Point((Panel_Contenedor.Width - frm.Width) / 2, (Panel_Contenedor.Height - frm.Height) / 2);
            frm.Show();
        }

        private void Hora_Fecha_Tick(object sender, EventArgs e)
        {
            Lbl_Hora.Text = DateTime.Now.ToLongTimeString();
            Lbl_Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void But_Cerrar_Seción_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerra seción?", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Registro_De_Bodegas();
            frm.TopLevel = false;
            frm.Parent = Panel_Contenedor;
            frm.Location = new Point((Panel_Contenedor.Width - frm.Width) / 2, (Panel_Contenedor.Height - frm.Height) / 2);
            frm.Show();
        }
    }
}
