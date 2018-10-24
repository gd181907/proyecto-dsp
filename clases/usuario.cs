using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presentacion
{
    class usuario
    {
        protected string nombre;
        protected string telefono;
        protected string empresa;
        protected string rubro;
        protected string direccion;
        protected string NIT;
        protected string email;

        public usuario()
        {
            nombre = "";
            telefono = "";
            empresa = "";
            rubro = "";
            direccion = "";
            NIT = "";
            email = "";
        }
        public string nombreRepresentante
        {
            get { return (nombre); }
            set  {nombre =value;}      
        }
        public string ntelefono
        {
            get { return (telefono); }
            set { telefono = value; }
        }
        public string nombreEmpresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        public string direcciondeempresa
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string numeroIdenticicacionEmpresa
        {
            get { return NIT; }
            set { NIT = value; }
        }
        public string direccionemailContacto
        {
            get { return email; }
            set { email = value; }
    
        }
     }

    }

   


            