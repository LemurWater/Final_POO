using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPOO.Forms
{
    public partial class F13AEINPrima : Form
    {
        public F13AEINPrima()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F06AEInformacionNominal f06AEInformacionNominal = new F06AEInformacionNominal();
            f06AEInformacionNominal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalarioNeto_Click(object sender, EventArgs e)
        {
            this.Hide();
            F12AEINSalarioNeto f12AEINSalarioNeto = new F12AEINSalarioNeto();
            f12AEINSalarioNeto.ShowDialog();
        }

        private void buttonCesantias_Click(object sender, EventArgs e)
        {
            this.Hide();
            F14AEINCesantias f14AEINCesantias = new F14AEINCesantias();
            f14AEINCesantias.ShowDialog();
        }

        private void buttonVacaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            F15AEINVacaciones f15AEINVacaciones = new F15AEINVacaciones();
            f15AEINVacaciones.ShowDialog();
        }
    }
}
