using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineraTIC.Clases
{
    class Clientito
    {
        public Clientito(string nombre, string identificacion, string direccion)
        {
            Nombres = nombre;
            Identificacion = identificacion;
            Direccion = direccion;
        }

        private String nombres;

        public String Nombres
        {
            get {
               
                return nombres; }
            set { nombres = value; }
        }


        public String identificacion;
        public String Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }   
        }

        private String direccion;

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }




    }
}
