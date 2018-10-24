using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace capanegocios
{
    public partial class login : Form
    {
        usuario nuevo = new usuario();
        public login()
        {
            InitializeComponent();
        }

        private void txtsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtingresar_Click(object sender, EventArgs e)
        {
            menu_primario menuppal = new menu_primario();
            menuppal.Visible = true;
            this.Hide();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Navy;

            }
        }

        private void txtclave_Leave(object sender, EventArgs e)
        {
            if (txtclave.Text == "")
            {
                txtclave.Text = "Contraseña";
                txtclave.ForeColor = Color.Black;
            }
        }

        private void txtclave_Enter(object sender, EventArgs e)
        {
            if (txtclave.Text == "Contraseña")
            {
                txtclave.Text = "";
                txtclave.ForeColor = Color.Black;
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            otrousuario usuario = new otrousuario();
            usuario.Visible = true;
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            otrousuario usuario = new otrousuario();
            usuario.Visible = true;
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btninicioadm_Click(object sender, EventArgs e)
        {

        }
    }

    public partial class CopyOflogin : Form
    {
        usuario nuevo = new usuario();
        public CopyOflogin()
        {
            InitializeComponent();
        }

        private void txtsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtingresar_Click(object sender, EventArgs e)
        {
            menu_primario menuppal = new menu_primario();
            menuppal.Visible = true;
            this.Hide();
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Navy;

            }
        }

        private void txtclave_Leave(object sender, EventArgs e)
        {
            if (txtclave.Text == "")
            {
                txtclave.Text = "Contraseña";
                txtclave.ForeColor = Color.Black;
            }
        }

        private void txtclave_Enter(object sender, EventArgs e)
        {
            if (txtclave.Text == "Contraseña")
            {
                txtclave.Text = "";
                txtclave.ForeColor = Color.Black;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            otrousuario usuario = new otrousuario();
            usuario.Visible = true;
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            otrousuario usuario = new otrousuario();
            usuario.Visible = true;
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btninicioadm_Click(object sender, EventArgs e)
        {

        }
    }
}
