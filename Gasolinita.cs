using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasolineraTIC.Clases
{
    class Gasolinita
    {

        public Gasolinita(string tipo, int galones)
        {
            Tipo = tipo;
            Galones = galones;
        }


        private String tipo;
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        private int galones;
        public int Galones
        {
            get { return galones; }
            set { galones = value; }
        }

        private float subTotal;
        public float Subtotal
        {
            get {

                if (Tipo == "Extra")
                {
                    subTotal = Galones * 1.50f;
                }
                if (Tipo == "Super")
                {
                    subTotal = Galones * 2.00f;
                }
                return subTotal; }
        }

        private float iva;
        
        public float Iva
        {
            get
            {
                iva = subTotal * 0.12f;

                return iva;
            }
        }

        private float total;
        public float Total
        {
            get {
                total = subTotal + iva; 
                return total; }
        }


    }
}
