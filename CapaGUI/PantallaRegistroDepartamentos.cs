using CapaDTO;
using CapaNegocio;
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
    public partial class PantallaRegistroDepartamentos : Form
    {
        public PantallaRegistroDepartamentos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Departamento auxDepartamento = new Departamento();
            auxDepartamento.Id = 0;
            auxDepartamento.Nombre = txtNombre.Text;

            NegocioDepartamento auxNegocioDepartamento = new NegocioDepartamento();
            auxNegocioDepartamento.insertarDepartamento(auxDepartamento);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }
    }
}
