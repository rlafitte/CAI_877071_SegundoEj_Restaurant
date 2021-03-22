using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Libreria.Entidades
{
    public class Pedido
    {
        private int i_nroPedido;
        private int i_cantidad;
        private Mesa[] mesa;
        private Producto[] prod;

        public int Cantidad
        {
            get
            {
                return this.i_cantidad;
            }
            set
            {
                this.i_cantidad = value;
            }

        }
    }
}
