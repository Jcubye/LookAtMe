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
    public partial class PantallaLoginPersonal : Form
    {
        public PantallaLoginPersonal()
        {
            InitializeComponent();
        }

        private void txtIngresar_Click(object sender, EventArgs e)
        {
            PantallaHomeAdministrador pHomeAdministrador = new PantallaHomeAdministrador();
            pHomeAdministrador.ShowDialog();
        }

        private void txtCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }
    }
}
