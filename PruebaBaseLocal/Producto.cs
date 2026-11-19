using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBaseLocal
{
    public class Producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Producto(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public string MostrarInformacion()
        {
            return $"ID: {Id}, Nombre: {Name}, Precio: {Price}";
        }
    }
}
