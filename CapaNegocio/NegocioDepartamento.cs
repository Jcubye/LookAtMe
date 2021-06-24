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
        
        private ConexionSQLSERVER conec = new ConexionSQLSERVER();

        public ConexionSQLSERVER Conec { get => conec; set => conec = value; }


        public void configurarConexion()
        {
            this.Conec = new ConexionSQLSERVER();
            this.Conec.NombreBaseDatos = "LookAtMe";
            this.Conec.CadenaConexion = "Data Source=LAPTOP-G7NSK0PF;Initial Catalog=LookAtMe;Integrated Security=True";
        }//fin configurarConexion


        
        public void insertarDepartamento(Departamento departamento)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "INSERT INTO dbo.departamento (nombre) VALUES ('" + departamento.Nombre + "');";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }//Fin insertar

        public void actualizarDepartamento(Departamento departamento)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "UPDATE lookatme.dbo.departamento SET nombre = '"
                + departamento.Nombre + "' WHERE id = '" + departamento.Id + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }//Fin actualizar

        public void eliminarDepartamento(int rut)
        {
            this.configurarConexion();
            this.Conec.CadenaSQL = "DELETE FROM lookatme.dbo.departamento WHERE rut= '"+ rut + "';";
            this.Conec.EsSelect = false;
            this.Conec.conectar();
        }//Fin eliminar

        public void listarDepartamento()
        {

        }//fin listar

        
    }
}
