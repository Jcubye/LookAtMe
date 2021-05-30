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
    public partial class PantallaHome : Form
    {
        public PantallaHome()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaLoginPersonal pLoginPersonal = new PantallaLoginPersonal();
            pLoginPersonal.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PantallaRegistroRRHH pRegistroRRHH = new PantallaRegistroRRHH();
            pRegistroRRHH.ShowDialog();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            PantallaLoginTutor pLoginTutor = new PantallaLoginTutor();
            pLoginTutor.ShowDialog();
        }
    }
}
