using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class vehiculos : Form
    {
        List<camion> camion = new List<camion>();
        camion nuevoVehiculo;
        public vehiculos()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vehiculos_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            nuevoVehiculo = new camion();
            foreach (camion items in camion)
            {
                if (items.Modelo == txtmodelo.Text)
                {
                    MessageBox.Show("debe asignar un modelo");
                    return;
                }
            }
            if (nuevoVehiculo.AsigarDatos(txtmodelo, txtplaca, cmbcapacidad, nudcosto, cmbmotor, cmbtipovehiculo))
            {
                camion.Add(nuevoVehiculo);
                txtmodelo.Clear();
                nudcosto.Value = 0;
                cmbcapacidad.SelectedValue = 0;
                txtplaca.Clear();

            }

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            if (camion == null)
            {
                MessageBox.Show(" Aun no hay elementos que amostar");
                return;

            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = camion;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (camion == null)
            {
                MessageBox.Show("lista aun no generada");
                return;
            }
            if (txtplaca.Text == string.Empty)
            {
                MessageBox.Show("asigne una placa al vehiculo");
                return;
            }
            foreach (camion items in camion)
            {
                if (items.Placa == txtplaca.Text)
                {
                    items.Modelo = txtmodelo.Text;
                    items.Costo = (double)nudcosto.Value;
                    items.Motor = cmbmotor.Text;
                    items.Tipo = cmbtipovehiculo.Text;
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = camion;
                    txtmodelo.Clear();
                    txtplaca.Clear();
                    txtdescmotor.Clear();
                    MessageBox.Show("Vehiculo modificado exitosamente");
                    return;
                }
            }
            MessageBox.Show("No se encontro el elemento a modificar");
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (camion == null)
            {
                MessageBox.Show("Aun no se genera una lista");
            }
            if (txtplaca.Text == string.Empty)
            {
                MessageBox.Show("asigne una placa al vehiculo");
                return;
            }
            foreach (camion items in camion)
            {
                camion.Remove(items);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = camion;
                txtmodelo.Clear();
                cmbcapacidad.SelectedValue = 0;
                cmbtipovehiculo.SelectedValue = 0;
                cmbmotor.SelectedValue = 0;
                txtplaca.Clear();
                txtdescmotor.Clear();
                nudcosto.Value = 0;
                MessageBox.Show("Eliminado con exito");
                return;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (camion == null)
            {
                MessageBox.Show("Aun no se genera una lista");
            }
            if(txtplaca.Text == string .Empty )
            {
                   MessageBox.Show("asigne una placa al vehiculo");
                return;
        }
             foreach(camion items in camion )
             {
                 if(items.Placa==txtplaca.Text){
                     
                     DataRow datos;
                     DataTable ndatos= new DataTable();
                     datos = ndatos.NewRow();
                     ndatos .Columns.Add(new DataColumn("Modelo", System .Type .GetType ("System.String")));
                      ndatos .Columns.Add(new DataColumn("Placa", System .Type .GetType ("System.String")));
                      ndatos .Columns.Add(new DataColumn("Tipo", System .Type .GetType ("System.String")));
                      ndatos .Columns.Add(new DataColumn("Motor", System .Type .GetType ("System.String")));
                      ndatos .Columns.Add(new DataColumn("Costo", System .Type .GetType ("System.String")));
                      ndatos .Columns.Add(new DataColumn("Capacidad", System .Type .GetType ("System.String")));
                     datos["Modelo"] = items.Modelo;
                    datos["Placa"] = items.Placa;
                    datos["Tipo"] = items.Tipo;
                    datos["Motor"] = items.Tipo ;
                    datos["Costo"] = "$ " + items.Costo;
                    datos["Capacidad"] = items.Capacidad + " tms";
                    ndatos.Rows.Add(datos);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ndatos;
                     return;
                 }
             }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

