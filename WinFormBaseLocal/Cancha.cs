using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBaseLocal
{
    public class Cancha
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        /// <summary>
        ///  Precio por hora de la cancha
        /// </summary>
        public decimal Precio { get; set; }
        public Cancha(int id, string name, decimal precio)
        {
            Id = id;
            Nombre = name;
            Precio = precio;
        }   
    }
}
