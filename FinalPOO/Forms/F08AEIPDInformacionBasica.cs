﻿using System;
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
    public partial class F08AEIPDInformacionBasica : Form
    {
        public F08AEIPDInformacionBasica()
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
            F07AEInformacionPesonalDetallada f07AEInformacionPesonalDetallada = new F07AEInformacionPesonalDetallada();
            f07AEInformacionPesonalDetallada.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonInformacionAcademica_Click(object sender, EventArgs e)
        {
            this.Hide();
            F09AEIPDInformacionAcademica f09AEIPDInformacionAcademica = new F09AEIPDInformacionAcademica();
            f09AEIPDInformacionAcademica.ShowDialog();
        }

        private void buttonResidencia_Click(object sender, EventArgs e)
        {
            this.Hide();
            F10AEIPDInformacionResidencia f10AEIPDInformacionResidencia = new F10AEIPDInformacionResidencia();
            f10AEIPDInformacionResidencia.ShowDialog();
        }

        private void buttonPatrimonio_Click(object sender, EventArgs e)
        {
            this.Hide();
            F11AEIPDInformacionPatrimonio f11AEIPDInformacionPatrimonio = new F11AEIPDInformacionPatrimonio();
            f11AEIPDInformacionPatrimonio.ShowDialog();
        }
    }
}
