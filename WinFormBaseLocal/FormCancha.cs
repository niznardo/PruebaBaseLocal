using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLocal;

namespace WinFormBaseLocal
{
    public partial class FormCancha : Form
    {
        Sistema sistema = new Sistema();
        public FormCancha(Sistema sistema)
        {
            InitializeComponent();
            this.sistema = sistema;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text;
            var prcio = decimal.Parse(textBoxPrecio.Text);
            var cancha = new Cancha(1, name, prcio);
            sistema.Canchas.Add(cancha);
            Persistencia.Guardar(sistema);
            this.Close();
        }
    }
}
