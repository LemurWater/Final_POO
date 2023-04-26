using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FinalPOO.Clases;

namespace FinalPOO.Forms
{
    public partial class F03VizualisarEmpleado : Form
    {
        bool gate = false;

        public F03VizualisarEmpleado()
        {
            InitializeComponent();

            label1.Text = Program.empleado.Nombre + " " + Program.empleado.Apellidos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tmpNombre = Program.empleado.Nombre.ToUpper() + " " + Program.empleado.Apellidos.ToUpper();
                if (tmpNombre == textBox1.Text.ToUpper())
                {
                    gate = true;
                }
                /*
                if (Program.l_empleados.Count == 0)
                {
                    label1.Text = Program.empleado.Nombre;
                    string tmpNombre = Program.empleado.Nombre.ToUpper() + " " + Program.empleado.Nombre.ToUpper();
                    if (tmpNombre == textBox1.Text.ToUpper())
                    {
                        gate = true;
                    }
                }
                else
                {
                    foreach (Empleado empleado in Program.l_empleados)
                    {
                        string tmpNombre = empleado.Nombre.ToUpper() + " " + empleado.Apellidos.ToUpper();
                        label1.Text = tmpNombre;
                        if (tmpNombre == textBox1.Text.ToUpper())
                        {
                            gate = true;
                        }
                    }
                }*/
               
                if (!gate)
                {
                    F04UsuarioNoRegistrado f4UsuarioNoRegistrado = new F04UsuarioNoRegistrado();
                    f4UsuarioNoRegistrado.ShowDialog();
                    this.Hide();
                }
                else
                {
                    F16VEInformacionNominal f16VEInformacionNominal = new F16VEInformacionNominal();
                    f16VEInformacionNominal.ShowDialog();
                    this.Hide();
                }
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            F02Loging2 f02Loging2 = new F02Loging2();
            f02Loging2.ShowDialog();
        }
    }
}
