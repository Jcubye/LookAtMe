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

        public void limpiar()
        {
            this.txtNombre.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Departamento auxDepartamento = new Departamento();
            auxDepartamento.Id = 0;
            auxDepartamento.Nombre = txtNombre.Text;

            NegocioDepartamento auxNegocioDepartamento = new NegocioDepartamento();
            auxNegocioDepartamento.insertarDepartamento(auxDepartamento);
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ServiceDepartamento.ServicioDepartamentoSoapClient auxServiceDepartamento = new ServiceDepartamento.ServicioDepartamentoSoapClient();
                ServiceDepartamento.Departamento auxDepartamento = new ServiceDepartamento.Departamento();

                auxDepartamento.Nombre = this.txtNombre.Text;

                auxServiceDepartamento.insertarDepartamento(auxDepartamento);
                MessageBox.Show("¡Datos Guardados!","System");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ingresar departamento", "System"  + ex.Message);
            }
        }
    }
}
