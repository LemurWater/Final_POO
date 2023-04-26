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
    public partial class F05AgregarEmpleado : Form
    {
        public F05AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F06AEInformacionNominal f06AEInformacionNominal = new F06AEInformacionNominal();
            f06AEInformacionNominal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            F07AEInformacionPesonalDetallada f07AEInformacionPesonalDetallada = new F07AEInformacionPesonalDetallada();
            f07AEInformacionPesonalDetallada.ShowDialog();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            F02Loging2 f02Loging2 = new F02Loging2();
            f02Loging2.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
