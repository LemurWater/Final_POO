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
    public partial class F18VEINSalarioNeto : Form
    {
        public F18VEINSalarioNeto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F17VEINInformacionNominal f17VEINInformacionNominal = new F17VEINInformacionNominal();
            f17VEINInformacionNominal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
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
