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
    public partial class F15AEINVacaciones : Form
    {
        public F15AEINVacaciones()
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

        private void buttonPrima_Click(object sender, EventArgs e)
        {
            this.Hide();
            F13AEINPrima f13AEINPrima = new F13AEINPrima();
            f13AEINPrima.ShowDialog();
        }

        private void buttonCesantias_Click(object sender, EventArgs e)
        {
            this.Hide();
            F14AEINCesantias f14AEINCesantias = new F14AEINCesantias();
            f14AEINCesantias.ShowDialog();
        }
    }
}
