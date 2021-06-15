using CapaDTO;
using System;
using CapaNegocio;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Departamento auxDepartamento = new Departamento();
                auxDepartamento.Id = 0;
                auxDepartamento.Nombre = txtNombre.Text;

                NegocioDepartamento auxNegocioDepartamento = new NegocioDepartamento();
                auxNegocioDepartamento.agregarDepartamento(auxDepartamento);
                MessageBox.Show("Datos guardados correctamente");
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("System" + ex.Message, "Datos  no guardados");
            }
            
        }
    }
}
