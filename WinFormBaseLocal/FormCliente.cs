using BaseLocal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormBaseLocal;

namespace WinFormBaseLocal
{
    public partial class FormCliente : Form
    {
        Sistema sistema = new Sistema();
        Cliente cliente = new Cliente();
        public FormCliente(Sistema sistema)
        {
            InitializeComponent();
            this.sistema = sistema;
        }

        public FormCliente(Sistema sistema, Cliente cliente)
        {
            InitializeComponent();
            this.sistema = sistema;
            this.cliente = cliente;
            LlenarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dni = int.Parse(textBoxDNI.Text);
            var name = textBoxName.Text;
            var email = textBoxEmail.Text;
            var cliente = new Cliente(dni, name, email);
            sistema.Clientes.Add(cliente);
            Persistencia.Guardar(sistema);
            MessageBox.Show("Cliente agregado correctamente.", "Confirmacion", MessageBoxButtons.OK);

            this.Close();
        }

        private void LlenarCampos()
        {
            textBoxDNI.Text = cliente.DNI.ToString();
            textBoxName.Text = cliente.Name;
            textBoxEmail.Text = cliente.Email;
        }
    }
}
