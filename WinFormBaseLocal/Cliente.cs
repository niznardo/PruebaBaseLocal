using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBaseLocal
{
    public class Cliente
    {
        public int DNI { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Cliente(int dni, string name, string email)
        {
            DNI = dni;
            Name = name;
            Email = email;
        }

        public Cliente()
        {
        }
    }
}
