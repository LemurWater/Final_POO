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
    public partial class F04UsuarioNoRegistrado : Form
    {
        public F04UsuarioNoRegistrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F03VizualisarEmpleado f3VizualisarEmpleado = new F03VizualisarEmpleado();
            f3VizualisarEmpleado.ShowDialog();
        }
    }
}
