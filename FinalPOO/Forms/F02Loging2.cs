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
    public partial class F02Loging2 : Form
    {
        public F02Loging2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F03VizualisarEmpleado f3VizualisarEmpleado = new F03VizualisarEmpleado();
            f3VizualisarEmpleado.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F05AgregarEmpleado f5AgregarEmpleado = new F05AgregarEmpleado();
            f5AgregarEmpleado.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
