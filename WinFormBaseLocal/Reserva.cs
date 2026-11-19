using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormBaseLocal
{
    public class Reserva
    {
        public Cliente Cliente { get; set; }
        public Cancha Cancha { get; set; }
        /// <summary>
        /// Duración en minutos
        /// </summary>
        public int Duracion { get; set; } 
        /// <summary>
        /// Fecha y Hora de reserva
        /// </summary>
        public DateTime Fecha { get; set; }

        public Reserva(Cliente cliente, Cancha cancha, int duracion, DateTime fecha)
        {
            Cliente = cliente;
            Cancha = cancha;
            Duracion = duracion;
            Fecha = fecha;
        }

    }
}
