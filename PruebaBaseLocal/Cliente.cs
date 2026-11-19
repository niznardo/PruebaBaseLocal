using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaBaseLocal
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Cliente(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public string MostrarInformacion()
        {
            return $"ID: {Id}, Nombre: {Name}, Email: {Email}";
        }
    }
}
