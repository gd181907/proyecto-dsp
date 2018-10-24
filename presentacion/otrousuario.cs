using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace capanegocios
{
    public partial class otrousuario : Form
    {
        usuario NUEVAempresa = new usuario();
        empresa empresacliente = new empresa();
        public otrousuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            if (txtnombre.Text == "Nombre")
            {
                txtnombre.Text = "";
                txtnombre.ForeColor = Color.Black;
            }

        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                txtnombre.Text = "Nombre";
                txtnombre.ForeColor = Color.Navy;

            }
        }

        private void txttel_Leave(object sender, EventArgs e)
        {
            if (txttel.Text == "")
            {
                txttel.Text = "Telefono";
                txttel.ForeColor = Color.Navy;

            }
        }

        private void txtempresa_Leave(object sender, EventArgs e)
        {
            if (txtempresa.Text == "")
            {
                txtempresa.Text = "Empresa";
                txtempresa.ForeColor = Color.Navy;

            }
        }

        private void txtempresa_Enter(object sender, EventArgs e)
        {
            if (txtempresa.Text == "Empresa")
            {
                txtempresa.Text = "";
                txtempresa.ForeColor = Color.Black;
            }
        }

        private void txttel_Enter(object sender, EventArgs e)
        {
            if (txttel.Text == "Telefono")
            {
                txttel.Text = "";
                txttel.ForeColor = Color.Black;
            }
        }

        private void txtrubro_Enter(object sender, EventArgs e)
        {
            if (txtrubro.Text == "Rubro")
            {
                txtrubro.Text = "";
                txtrubro.ForeColor = Color.Black;
            }
        }

        private void txtrubro_Leave(object sender, EventArgs e)
        {
            if (txtrubro.Text == "")
            {
                txtrubro.Text = "Rubro";
                txtrubro.ForeColor = Color.Navy;

            }
        }

        private void txtNIT_Enter(object sender, EventArgs e)
        {
            if (txtNIT.Text == "NIT")
            {
                txtNIT.Text = "";
                txtNIT.ForeColor = Color.Black;
            }
        }

        private void txtNIT_Leave(object sender, EventArgs e)
        {
            if (txtNIT.Text == "")
            {
                txtNIT.Text = "NIT";
                txtNIT.ForeColor = Color.Navy;

            }
        }

        private void txtdirecc_Enter(object sender, EventArgs e)
        {
            if (txtdirecc.Text == "Direccion")
            {
                txtdirecc.Text = "";
                txtdirecc.ForeColor = Color.Black;
            }
        }

        private void txtdirecc_Leave(object sender, EventArgs e)
        {
            if (txtdirecc.Text == "")
            {
                txtdirecc.Text = "Direccion";
                txtdirecc.ForeColor = Color.Navy;

            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "E-mail")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "E-mail";
                txtemail.ForeColor = Color.Navy;

            }
        }

        private void btnregist_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    empresacliente.Definirdatos(string ntitular, string tell, decimal Nnit, string user, string passsword, string mail1, string direccionE,string empresa, string rubroo){}
            //    //empresacliente.Definirdatos(txtnombre.Text, txttel.Text,txtNIT.Text ,txtusuario.Text, txtClave.Text,txtemail.Text ,txtdirecc.Text ,txtempresa.Text,txtrubro.Text );
            //    if (empresacliente.Definirdatos)
            //    {
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}


        }



        //NUEVAempresa.Razonsocial = txtempresa.Text;
        //NUEVAempresa.Representante = txtnombre.Text;
        //NUEVAempresa.Ntelefono = txttel .Text;
        //NUEVAempresa.Nit  = Convert.ToDecimal(txtNIT.Text);
        //NUEVAempresa.Email = txtemail.Text;
        //NUEVAempresa.Direccion  =txtdirecc.Text;
        //NUEVAempresa.Rubro = txtrubro.Text;
        //empresacliente.Nuser1 = txtusuario.Text;
        //empresacliente.Clave1 = txtClave.Text;




        //login inicio = new login();
        //inicio.Visible = true;
        //this.Hide();


        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void otrousuario_Load(object sender, EventArgs e)
        {

        }


    }
}

