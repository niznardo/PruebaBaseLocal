namespace WinFormBaseLocal
{
    public partial class Form1 : Form
    {
        public Sistema sistema;
        public Form1(Sistema sistema)
        {
            InitializeComponent();

            this.sistema = sistema;
            comboBoxClientes.DataSource = sistema.Clientes;
            comboBoxClientes.DisplayMember = "Name";
            comboBoxClientes.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formCliente = new FormCliente(sistema);
            formCliente.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formCancha = new FormCancha(sistema);
            formCancha.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formReserva = new FormReserva(sistema);
            formReserva.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)comboBoxClientes.SelectedItem;
            if (cliente == null)
            {
                MessageBox.Show("Seleccione un cliente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var formCliente = new FormCliente(sistema, cliente);
                formCliente.Show();
            }
        }
    }
}
