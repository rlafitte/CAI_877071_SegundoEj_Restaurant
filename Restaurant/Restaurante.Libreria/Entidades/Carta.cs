using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Libreria.Entidades
{
    public class Carta
    {


        private double d_precio;
        private string s_seccion;

        private Producto[] product;



        //double precio
        //string seccion

        public double Precio
        {
            get
            {
                return this.d_precio;
            }
            set
            {
                this.d_precio = value;
            }
        }

        public string Seccion
        {
            get
            {
                return this.s_seccion;
            }
            set
            {
                this.s_seccion = value;
            }
        }

        public Producto prod
        {
            get; set;

        }
    }
}
