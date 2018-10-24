using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public class empresa : usuario
    {
        private string Nuser;
        private string Clave;
        private Boolean datosLLenos;

       public string Nuser1
        {
            get { return Nuser; }
            set { Nuser = value; }
        }
       public string Clave1
        {
            get { return Clave; }
            set { Clave = value; }
        }
        public Boolean  CAmposLLenos{
            get{ return datosLLenos;}
        }
     
      public empresa() 
      { datosLLenos= false;
      }
       public bool ingresarDatos(TextBox  nempresa, TextBox  tell, TextBox  direccionE, TextBox  Nnit, TextBox user1, TextBox  passsword, TextBox  mail1)
        {
            if (nempresa.Text == null)
            {
                MessageBox.Show("nombre Indispensable");
                nempresa.Focus();
                return false;   
            }
            if (tell.Text == null)
            {
                MessageBox.Show("nombre Indispensable");
                nempresa.Focus();
                return false;
            }
            if (Nnit.Text == null)
            {
                MessageBox.Show("nombre Indispensable");
                nempresa.Focus();
                return false;
            }
            if (user1 == null)
            {
                MessageBox.Show("nombre Indispensable");
                nempresa.Focus();
                return false;
            }
           if (passsword .Text == null)
            {
                MessageBox.Show("nombre Indispensable");
                nempresa.Focus();
                return false;   
            }
           return true;
        }
       public void Definirdatos(string ntitular, string tell, decimal Nnit, string user, string passsword, string mail1, string direccionE){
           datosLLenos=false;
           ntitular=ntitular.Trim();
           if(ntitular.Length==0){
               MessageBox.Show("asigne un nombre");
               return;
           }
           else{
               nombre=ntitular;
           }
           tell= tell.Trim();
           if(tell .Length ==00){
                MessageBox.Show("asigne un Telefono");
               return;
           }
           else {telefono=tell;}
           NIT=Nnit;
           if(Nnit==00){
                MessageBox.Show("asigne un NIT");
               return;
           }
           else {NIT=Nnit;}
           user=user.Trim();
           if(user .Length ==00){
                MessageBox.Show("asigne un usuario");
                return;
           }
           else {Nuser=user;}
           mail1 = mail1.Trim();
           if (mail1.Length == 00)
           {
               MessageBox.Show("asigne una direccion de correo electronico");
               return;
           }
           else { email=mail1; }
           direccionE = direccionE.Trim();
           if (direccionE. Length == 00)
           {
               MessageBox.Show("asigne una DIRECION");
               return;
           }
           else { direccion = direccionE; }
           passsword = passsword.Trim();
           if (passsword.Length == 00)
           {
               MessageBox.Show("asigne un contrasena");
               return;
           }
           else { Clave = passsword; }
           datosLLenos = true;
       }   

    }
}

