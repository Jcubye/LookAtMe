using System;
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
    public partial class PantallaHomeAdministrador : Form
    {
        public PantallaHomeAdministrador()
        {
            InitializeComponent();
        }

        private void registroPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void registroPersonalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PantallaRegistroRRHH pRegistroRRHH = new PantallaRegistroRRHH();
            pRegistroRRHH.ShowDialog();
        }

        private void registroPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroPaciente pRegistroPaciente = new PantallaRegistroPaciente();
            pRegistroPaciente.ShowDialog();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroTutor pRegistroTutor = new PantallaRegistroTutor();
            pRegistroTutor.ShowDialog();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PantallaRegistroDepartamentos pRegistroDepartamentos = new PantallaRegistroDepartamentos();
            pRegistroDepartamentos.ShowDialog();
        }

        private void registroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PantallaRegistroCargos pRegistroCargos = new PantallaRegistroCargos();
            pRegistroCargos.ShowDialog();
        }

        private void crearEquipoMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaRegistroEquipoMedico pRegistroEquipoMedico = new PantallaRegistroEquipoMedico();
            pRegistroEquipoMedico.ShowDialog();
        }

        private void resumenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
