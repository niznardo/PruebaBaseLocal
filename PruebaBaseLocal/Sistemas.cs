using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBaseLocal
{
    public class Sistemas
    {
        public List<Cliente> Clientes { get; set; }
        public List<Producto> Productos { get; set; }

        public Sistemas() 
        {
            Clientes = new List<Cliente>();
            Productos = new List<Producto>();
        }
    }
}
