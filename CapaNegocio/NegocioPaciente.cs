using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaDTO;

namespace CapaNegocio
{
    public class NegocioPaciente
    {
        private ConexionSQLSERVER conex;

        public ConexionSQLSERVER Conex { get => conex; set => conex = value; }

        public void configurarConexion()
        {
            this.Conex.NombreBaseDatos = "LookAtMe";
            this.Conex.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=LookAtMe;Integrated Security=True";
        }//fin config conexion

        public void insertarDepartamento (Departamento departamento)
        {
            this.configurarConexion();
            //concatenar con + | los nombres van entre "" | los parametros van entre '' | la query termina en ; 
            //ID Imcremento automatico
            this.Conex.CadenaSQL = "INSERT INTO  dbo.departamento (nombre) VALUES ('"+ departamento.Nombre +"' );";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }
    }//fin public
}//fin namespace
