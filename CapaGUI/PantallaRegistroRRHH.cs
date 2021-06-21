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
    public partial class PantallaRegistroRRHH : Form
    {
        public PantallaRegistroRRHH()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            PantallaListadoPersonal pListadoPersonal = new PantallaListadoPersonal();
            pListadoPersonal.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
