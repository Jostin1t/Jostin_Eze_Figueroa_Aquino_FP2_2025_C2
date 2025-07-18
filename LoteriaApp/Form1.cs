using System;
using System.Windows.Forms;

namespace LoteriaApp
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            int numeroUsuario;
            decimal montoApostado;

            if (!int.TryParse(txtNumero.Text, out numeroUsuario) || numeroUsuario < 0 || numeroUsuario > 100)
            {
                MessageBox.Show("Ingresa un número entre 0 y 100.");
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out montoApostado) || montoApostado <= 0)
            {
                MessageBox.Show("Ingresa un monto válido.");
                return;
            }

            int n1 = random.Next(0, 101);
            int n2 = random.Next(0, 101);
            int n3 = random.Next(0, 101);

            txtNum1.Text = n1.ToString();
            txtNum2.Text = n2.ToString();
            txtNum3.Text = n3.ToString();

            decimal ganancia = 0;
            if (numeroUsuario == n1) ganancia += montoApostado * 1000;
            if (numeroUsuario == n2) ganancia += montoApostado * 100;
            if (numeroUsuario == n3) ganancia += montoApostado * 10;

            txtGanado.Text = "$" + ganancia.ToString("N2");
        }
    }
}