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
    public partial class F17VEINInformacionNominal : Form
    {
        public F17VEINInformacionNominal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F16VEInformacionNominal f16VEInformacionNominal = new F16VEInformacionNominal();
            f16VEInformacionNominal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalarioNeto_Click(object sender, EventArgs e)
        {
            this.Hide();
            F18VEINSalarioNeto f18VEINSalarioNeto = new F18VEINSalarioNeto();
            f18VEINSalarioNeto.ShowDialog();
        }

        private void buttonPrima_Click(object sender, EventArgs e)
        {
            this.Hide();
            F19VEINPrima f19VEINPrima = new F19VEINPrima();
            f19VEINPrima.ShowDialog();
        }

        private void buttonCesantias_Click(object sender, EventArgs e)
        {
            this.Hide();
            F20VEINCesantias f20VEINCesantias = new F20VEINCesantias();
            f20VEINCesantias.ShowDialog();
        }

        private void buttonVacaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            F21VEINVacaciones f21VEINVacaciones = new F21VEINVacaciones();
            f21VEINVacaciones.ShowDialog();
        }
    }
}
