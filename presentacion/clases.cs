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

    class CopyOfclases
    {

    }
    public abstract class transporte
    {
        protected DataRow datos;
        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        protected double  costo;
        protected double capacidad;
        protected DateTime aniofab;
        private int anio;
        public virtual DataTable ver_datos()
        {
            DataTable Datos = new DataTable();
            datos = Datos.NewRow();
            Datos.Columns.Add(new DataColumn("Modelo", System.Type.GetType("System.String")));
            datos["modelo"] = "Modelo";
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
        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Motor
        {
            get
            {
                return motor;
            }
            set { motor = value; }
        }
      

        public double Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        public bool AsigarDatos(TextBox txtmodelo, TextBox txtplaca, ComboBox cmbcapacidad, NumericUpDown nudcosto, ComboBox cmbmotor, ComboBox cmbtipovehiculo)
        {
            int t;
            if (txtmodelo.Text == "")
            {
                MessageBox.Show("Modelo delVehiculo Indispensable");
                txtmodelo.Focus();
                return false;

            }
            else if (int.TryParse(txtmodelo.Text, out t))
            {
                MessageBox.Show("Solo se Admiten Letras en este Campo");
                txtmodelo.Clear();
                txtmodelo.Focus();
                return false;
            }
            else if (cmbtipovehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Un Tipo de Camion");
                cmbtipovehiculo.Focus();
                return false;
            }
            else if (nudcosto.Value <= 0)
            {
                MessageBox.Show("Ingrese Un precio Valido");
                nudcosto.Focus();
                return false;
            }
            else if (cmbcapacidad.SelectedIndex==-1)
            {
                MessageBox.Show("Ingrese un Rango Correcto");
                cmbcapacidad.Focus();
                return false;
            }
            else if (!Regex.IsMatch(txtplaca.Text, @"^[REcCmM]{1}[-]{1}[1-9]{2,6}$"))
            {
                MessageBox.Show("El valor de la placa no coincide con el establecido");
               txtplaca.Clear();
                txtplaca.Focus();
                return false;
            }
            else if (txtplaca.Text == "")//comprueba que la caja de texto no este vacio
            {
                MessageBox.Show("El valor de la placa no puede quedar vacio");
                txtplaca.Focus();
                return false;
            }
            //Validacion con expresion regular que permite que la placa sea correcta por el tipo de vehiculo
            else if ((cmbtipovehiculo.Text == "camion") && (!Regex.IsMatch(txtplaca.Text, @"^[mM]{1}[-]{1}[1-9]{2,6}$")))
            {
                MessageBox.Show("El valor de la placa no coincide con el tipo de vehiculo");
                txtplaca.Clear();
                txtplaca.Focus();
                return false;
            }
            //Validacion con expresion regular que permite que la placa sea correcta por el tipo de vehiculo
            else if ((cmbtipovehiculo.Text == "Cabezal") && (!Regex.IsMatch(txtplaca.Text, @"^[cC]{1}[-]{1}[1-9]{2,6}$")))
            {
                MessageBox.Show("El valor de la placa no coincide con el tipo de vehiculo");
                txtplaca.Clear();
                txtplaca.Focus();
                return false;
            }
            //Validacion con expresion regular que permite que la placa sea correcta por el tipo de vehiculo
            else if ((cmbtipovehiculo.Text == "Pick-up") && (!Regex.IsMatch(txtplaca.Text, @"^[pP]{1}[-]{1}[1-9]{2,6}$")))
            {
                MessageBox.Show("El valor de la placa no coincide con el tipo de vehiculo");
                txtplaca.Clear();
                txtplaca.Focus();
                return false;
            }
            if (cmbtipovehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar e Tipo de Motor");
                return false;
            }
            return true;
        }
        public void datosMotor(ComboBox tipo, ComboBox Motor)
        {
            int t;//servira para verificar si se pueden convertir a numeros las variables
            if (tipo.Text == null)//condicion que valida que el combo box no este vacio xd
            {
                MessageBox.Show("El Tipo de Motor no puede quedar vacio");
                tipo.Focus();

            }
            else if (tipo.Text == null) //Validamos que la descripcion no sea vacia
            {
                MessageBox.Show("La descripcion del motor no puede quedar vacia");
                Motor.Focus();
                return;
            }
            else if (int.TryParse(Motor.Text, out t))// valida que la descripcion no sean numeros
            {
                MessageBox.Show("La descripcion del motor no puede ser un valor numerico");

                Motor.Focus();
                return;
            }
            motor = tipo.Text + ": " + Motor.Text;
        }
        public override DataTable ver_datos()
        {
            DataTable data = new DataTable();
            datos = data.NewRow();//se agrega una fila la cual ya fue definida
            data.Columns.Add(new DataColumn("Modelo", System.Type.GetType("System.String")));//se crean las columnas
            data.Columns.Add(new DataColumn("Placa", System.Type.GetType("System.String")));
            data.Columns.Add(new DataColumn("Tipo", System.Type.GetType("System.String")));
            data.Columns.Add(new DataColumn("Motor", System.Type.GetType("System.String")));
            data.Columns.Add(new DataColumn("Costo", System.Type.GetType("System.String")));
            data.Columns.Add(new DataColumn("Capacidad", System.Type.GetType("System.String")));
            datos["Modelo"] = Modelo;//se agregan los dtos a las columnas
            datos["Placa"] = placa;
            datos["Tipo"] = tipo;
            datos["Motor"] = motor;
            datos["Costo"] = "$ " + costo;
            datos["Capacidad"] = capacidad + " Tms";
            data.Rows.Add(datos);// se agrega la fila que ya fue creada a la tabla
            return data;
        }
    }
    }








    
