using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Libreria.Entidades
{
    public class Producto
    {
        private string s_nombre;
        private string s_marca;
        private string s_tipo;

        public string Nombre
        {
            get
            {
                return this.s_nombre;
            }
            set
            {
                this.s_nombre = value;
            }
        }       
            public string Marca
        {
            get
            {
                return this.s_marca;
            }
            set
            {
                this.s_marca = value;
            }
        }        
        
        public string Tipo
        {
            get
            {
                return this.s_tipo;
            }
            set
            {
                this.s_tipo = value;
            }
        }
        
    }
}
