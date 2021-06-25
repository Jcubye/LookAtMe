using CapaDTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicioDepartamento

{
    /// <summary>
    /// Summary description for ServicioDepartamento
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioDepartamento : System.Web.Services.WebService
    {

        [WebMethod]
        public void insertarDepartamentoService(Departamento departamento)
        {
            NegocioDepartamento auxNegocioDepartamento = new NegocioDepartamento();
            auxNegocioDepartamento.insertarDepartamento(departamento);
        }

        [WebMethod]
        public void actualizarDepartamentoService(Departamento departamento)
        {
            NegocioDepartamento auxNegocioDepartamento = new NegocioDepartamento();
            auxNegocioDepartamento.actualizarDepartamento(departamento);
        }

        [WebMethod]
        public void eliminarDepartamentoService(int id)
        {
            NegocioDepartamento auxNegocioDepartamento = new NegocioDepartamento();
            auxNegocioDepartamento.eliminarDepartamento(id);
        }
    }
}
