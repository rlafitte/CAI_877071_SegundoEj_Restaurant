using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Libreria.Entidades
{
    public class Mesa
    {
        private int i_numero;
        private int i_cantSillas;
        
        public int Numero
        {
            get
            {
                return this.i_numero;
            }
            set
            {
                this.i_numero = value;
            }
        }

        public int CantSillas
        {
            get
            {
                return this.i_cantSillas;
            }
            set
            {
                this.i_cantSillas = value;
            }
        }

    }
}
