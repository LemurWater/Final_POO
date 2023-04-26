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
    public partial class F06AEInformacionNominal : Form
    {
        public F06AEInformacionNominal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F05AgregarEmpleado f05AgregarEmpleado = new F05AgregarEmpleado();
            f05AgregarEmpleado.ShowDialog();
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

        private void buttonVacaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            F15AEINVacaciones f15AEINVacaciones = new F15AEINVacaciones();
            f15AEINVacaciones.ShowDialog();
        }
    }
}
