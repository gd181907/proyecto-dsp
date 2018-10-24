using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    class clases
    {

    }
    public abstract class transporte
    {
        protected DataRow datos;
        protected string modelo;
        protected double costo;
        protected double capacidad;
        protected DateTime aniofab;
        private int anio;

        public transporte()
        {
            string fecha = anio.ToString();
            aniofab = Convert.ToDateTime(fecha);
        }
        public string modeloTransporte
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public int aniofabricacion
        {
            get { return anio; }
        }
        public double costoadquisicion
        {
            get { return costo; }
            set { value = costo; }
        }
        public double capacidadToneladas
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        public virtual DataTable ver_datos()
        {
            DataTable Datos = new DataTable();
            datos = Datos.NewRow();
            Datos.Columns.Add(new DataColumn("Modelo", System.Type.GetType("System.String")));
            Datos.Columns.Add(new DataColumn("Año de fabricacion", System.Type.GetType("System.String")));
            datos["modelo"] = "Modelo del Vehiculo";
            Datos.Rows.Add(datos);
            return Datos;
        }

    }
    class camion : transporte
    {//atributos
        private string placa;
        private string tipo;
        private string motor;

        //instaciamos  propiedades
        public string tipoPlaca
        {
            get { return placa; }
            set { placa = value; }
        }
        public string tipovehiculo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string tipoConsumo
        {
            get
            {
                return motor;
            }
        }

        public bool  AsigarDatos( ComboBox TipoMotor, TextBox modelo, NumericUpDown  capacidad, ComboBox tipoCamion, NumericUpDown costo, TextBox placa )
        {
            int t;
            if (modelo.Text == "")
            {
                MessageBox.Show("Modelo delVehiculo Indispensable");
                modelo.Focus();
               
            }
            else if (int.TryParse(modelo.Text, out t))
            {
                MessageBox.Show("Solo se Admiten Letras en este Campo");
                modelo.Clear();
                modelo.Focus();
                
            }
            else if (tipoCamion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Un Tipo de Camion");
                tipoCamion.Focus();
                
            }
            else if (costo.Value <= 0)
            {
                MessageBox.Show("Ingrese Un precio Valido");
                costo.Focus();
               
            }
            else if (capacidad.Value <= 0)
            {
                MessageBox.Show("Ingrese un Rango Correcto");
                capacidad.Focus();
                
            }
            else if (!Regex.IsMatch(placa.Text, @"^[pPcCmM]{1}[-]{1}[1-9]{2,6}$"))
            {
                MessageBox.Show("El valor de la placa no coincide con el establecido");
                placa.Clear();
                placa.Focus();
                
            }
            else if (placa.Text == "")//comprueba que la caja de texto no este vacio
            {
                MessageBox.Show("El valor de la placa no puede quedar vacio");
                placa.Focus();
                
            }
            //Validacion con expresion regular que permite que la placa sea correcta por el tipo de vehiculo
            else if ((tipoCamion.Text == "Seco") && (!Regex.IsMatch(placa.Text, @"^[mM]{1}[-]{1}[1-9]{2,6}$")))
            {
                MessageBox.Show("El valor de la placa no coincide con el tipo de vehiculo");
                placa.Clear();
                placa.Focus();
                
            }
            //Validacion con expresion regular que permite que la placa sea correcta por el tipo de vehiculo
            else if ((tipoCamion.Text == "Refrigerado") && (!Regex.IsMatch(placa.Text, @"^[cC]{1}[-]{1}[1-9]{2,6}$")))
            {
                MessageBox.Show("El valor de la placa no coincide con el tipo de vehiculo");
                placa.Clear();
                placa.Focus();
               
            }
            //Validacion con expresion regular que permite que la placa sea correcta por el tipo de vehiculo
            else if ((tipoCamion.Text == "Cama libre") && (!Regex.IsMatch(placa.Text, @"^[pP]{1}[-]{1}[1-9]{2,6}$")))
            {
                MessageBox.Show("El valor de la placa no coincide con el tipo de vehiculo");
                placa.Clear();
                placa.Focus();
               
            }
            if (TipoMotor.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar e Tipo de Motor");
                
            }
            return true;


        }
    }
}







    
