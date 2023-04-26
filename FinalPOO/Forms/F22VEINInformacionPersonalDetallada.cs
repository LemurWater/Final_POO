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
    public partial class F22VEINInformacionPersonalDetallada : Form
    {
        public F22VEINInformacionPersonalDetallada()
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

        private void buttonInformacionBasica_Click(object sender, EventArgs e)
        {
            this.Hide();
            F23VEINIPDInformacionBasica f23VEINIPDInformacionBasica = new F23VEINIPDInformacionBasica();
            f23VEINIPDInformacionBasica.ShowDialog();
        }

        private void buttonInformacionAcademica_Click(object sender, EventArgs e)
        {
            this.Hide();
            F24VEINIPDInformacionAcademica f24VEINIPDInformacionAcademica = new F24VEINIPDInformacionAcademica();
            f24VEINIPDInformacionAcademica.ShowDialog();
        }

        private void buttonResidencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            F25VEINIPDResidencia f25VEINIPDResidencia = new F25VEINIPDResidencia();
            f25VEINIPDResidencia.ShowDialog();
        }

        private void buttonPatrimonio_Click(object sender, EventArgs e)
        {
            this.Hide();
            F26VEINIPDPatrimonio f26VEINIPDPatrimonio = new F26VEINIPDPatrimonio();
            f26VEINIPDPatrimonio.ShowDialog();
        }
    }
}
