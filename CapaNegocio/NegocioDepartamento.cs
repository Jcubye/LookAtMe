using CapaConexion;
using CapaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioDepartamento
    {
        private ConexionSQLSERVER conex;

        public ConexionSQLSERVER Conex { get => conex; set => conex = value; }

        public void configurarConexion()
        {
            this.Conex.NombreBaseDatos = "LookAtMe";
            this.Conex.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=LookAtMe;Integrated Security=True";
        }

        public void insertarDepartamento(Departamento departamento)
        {
            this.configurarConexion();
            this.Conex.CadenaSQL = "INSERT INTO dbo.departamento (id,nombre) VALUES ('"+ departamento.Id +"' , '" + departamento.Nombre + "');";
            this.Conex.EsSelect = false;
            this.Conex.conectar();
        }
    }
}
