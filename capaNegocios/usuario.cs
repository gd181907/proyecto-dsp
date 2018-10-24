using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;

namespace capanegocios
{
  public  class usuario
    {
      protected DataRow credenciales;
        protected string nombre;
        protected string telefono;
        protected string empresa;
        private string rubro;
        protected string direccion;
        protected Decimal NIT;
        protected string email;
        public usuario()
        {     
        }
        public string Representante
        {
            get { return (nombre); }
            set  {nombre =value;}      
        }
        public string Ntelefono
        {
            get { return (telefono); }
            set { telefono = value; }
        }
        public string Razonsocial
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public Decimal Nit
        {
            get { return NIT; }
            set { NIT = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
    
        }
        public string Rubro
        {
            get { return rubro; }
            set { rubro = value; }
        }
     }

    }

   


            