using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBaseLocal
{
    public class Sistema
    {
        public List<Cliente> Clientes { get; set; }
        public List<Cancha> Canchas { get; set; }
        public List<Reserva> Reservas { get; set; }
        public Sistema()
        {
            Clientes = new List<Cliente>();
            Canchas = new List<Cancha>();
            Reservas = new List<Reserva>();
        }
    }
}
