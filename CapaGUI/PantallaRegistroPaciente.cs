﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class PantallaRegistroPaciente : Form
    {
        public PantallaRegistroPaciente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            PantallaListadoPaciente pListadoPaciente = new PantallaListadoPaciente();
            pListadoPaciente.ShowDialog();
        }
    }
}
