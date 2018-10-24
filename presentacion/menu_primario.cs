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

namespace capanegocios
{
    public partial class menu_primario : Form
    {

        clases transporte = new clases();
        public menu_primario()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnmaxx_Click(object sender, EventArgs e)
        {
            
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Guardar Los cambios Al salir", "titulo,alerta!!!", MessageBoxButtons.YesNo) == DialogResult)
            { }
            MessageBox.Show("Cambios Guardados");
                Application.Exit();
            

        }
        int lx;
        int ly;
        private void btnmax_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
           // this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnrestaurar.Visible = true;
            btnmax.Visible = false;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
           // this.WindowState = FormWindowState.Normal;
            this.Location = new Point(lx, ly);
            this.Size = new Size(1215, 549);
            btnrestaurar.Visible = false;
            btnmax.Visible = true;

        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (pnlmenu_izqo.Width == 200)
            {
                pnlmenu_izqo.Width = 70;
            }
            else
            {
                pnlmenu_izqo.Width = 200;
            }
        }

        private void pnlbarra_sup_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


        }
        private void vista_form_panel(object formhijo)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);
            Form Fh = formhijo as Form;
            Fh.TopLevel = false;
            Fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(Fh);
            this.contenedor.Tag = Fh;
            Fh.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pnlmenu_izqo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //login Administrador = new login();
            //Administrador.Show();
            panel2.Dock = DockStyle.Left;
            panel2.Visible = true;
             menuStrip1.Visible=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            //vehiculos nuevo = new vehiculos();
            //nuevo.Visible = true;
            //this.Hide();
            vista_form_panel(new ());
            vista_form_panel(new productos());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            otrousuario usuario = new otrousuario();
            usuario.Visible = true;
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
       
        }

        private void menu_primario_Load(object sender, EventArgs e)
        {
            mostrarlogo();
        }
        private void mostrarlogo()
        {
          
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();
        }
    }

}

