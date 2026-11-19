using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLocal;

namespace WinFormBaseLocal
{
    public partial class FormReserva : Form
    {
        Sistema sistema = new Sistema();
        public FormReserva(Sistema sistema)
        {
            InitializeComponent();
            this.sistema = sistema;

            comboBoxCancha.DataSource = sistema.Canchas;
            comboBoxCancha.DisplayMember = "Nombre";
            comboBoxCancha.SelectedIndex = 0;

            comboBoxCliente.DataSource = sistema.Clientes;
            comboBoxCliente.DisplayMember = "Name";
            comboBoxCliente.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)comboBoxCliente.SelectedItem;
            var cancha = (Cancha)comboBoxCancha.SelectedItem;

            var fecha = DateTime.Now;
            var reserva = new Reserva(cliente, cancha, 60, fecha);
            sistema.Reservas.Add(reserva);
            Persistencia.Guardar(sistema);
        }
    }
}
