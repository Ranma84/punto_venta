using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica_Negocio;
using Clases;
using Cache;

namespace Sitema_De_Punto_De_Venta
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void Txt_Usuarios_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Usuarios_Enter(object sender, EventArgs e)
        {
            if (Txt_Usuarios.Text == "Usuario")
            {
                Txt_Usuarios.Text = "";
                Txt_Usuarios.ForeColor= Color.LightGray;
            }
        }

        private void Txt_Contraseña_Enter(object sender, EventArgs e)
        {
            if (Txt_Contraseña .Text == "Contraseña")
            {
                Txt_Contraseña.Text = "";
                Txt_Contraseña.ForeColor = Color.LightGray;
                Txt_Contraseña.UseSystemPasswordChar = true ;
            }
        }

        private void Txt_Usuarios_MouseLeave(object sender, EventArgs e)
        {
            if (Txt_Usuarios.Text == "")
            {
                Txt_Usuarios.Text = "Usuario";
                Txt_Usuarios.ForeColor = Color.White ;
            }
        }

        private void Txt_Contraseña_MouseLeave(object sender, EventArgs e)
        {
            if (Txt_Contraseña.Text == "")
            {
                Txt_Contraseña.Text = "Contraseña";
                Txt_Contraseña.ForeColor = Color.White;
                Txt_Contraseña.UseSystemPasswordChar = false;
            }
        }

        private void Loguin_Load(object sender, EventArgs e)
        {
            //ac conexion = new ConexionBD();
            //conexion.abrir();
        }

        private void But_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void But_Minimiza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void But_Login_Click(object sender, EventArgs e)
            {
                if (Txt_Usuarios.Text != "usuario" && Txt_Usuarios.TextLength > 2)
                {
                    if (Txt_Contraseña.Text != "contrasnia")
                    {
                        UserModel user = new UserModel();
                        var validLogin = user.LoginUser(Txt_Usuarios.Text, Txt_Contraseña.Text);
                        if (validLogin == true)
                        {
                            Sistema_Principal mainMenu = new Sistema_Principal();
                            MessageBox.Show("Bienvenido " + UserLoginCache.Nombre);
                            mainMenu.Show();
                            mainMenu.FormClosed += Logout;
                            this.Hide();
                        }
                        else {
                            msgError("Está Incorrecto El Usuario o La Contraseña Insertada.\n PorFavor Vuelva a Intentarlo.");
                            Txt_Contraseña.Text = "Contraseña";
                            Txt_Contraseña.UseSystemPasswordChar = false;
                            Txt_Usuarios.Focus();
                        }
                    }
                    else msgError("Por favor ingrese su contraseña.");
                }
                else msgError("Por favor ingrese su nombre de usuario.");
            }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "  " + msg;
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            Txt_Contraseña.Text = "Contraseña";
            Txt_Contraseña.UseSystemPasswordChar = false;
            Txt_Usuarios.Text = "Usuario";
            lblErrorMessage.Visible = false;
            this.Show();
        }

    }
}
