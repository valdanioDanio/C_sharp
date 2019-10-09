using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceValdanio
{
    /// <summary>
    /// Summary description for ServicoWeb
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicoWeb : System.Web.Services.WebService
    {
        List<Productos> productos = new List<Productos>();

        public ServicoWeb()
        {
            productos.Add(new Productos(1,"Valdanio Alberto"));
            productos.Add(new Productos(2,"Mariano Calelua"));
            productos.Add(new Productos(2,"Lukau Manuel João Garcia"));
            productos.Add(new Productos(3,"Victorino Pedro"));
            productos.Add(new Productos(4,"Paulino Morais Esperança"));
            productos.Add(new Productos(5,"Kissema Eduara Rafael"));
            productos.Add(new Productos(5,"Nzunzi Solange Kiafuca"));
            productos.Add(new Productos(6,"Nsimba Paulina Kiafuca"));
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public List<Productos> getProductos()
        {
            return productos.ToList();
        }
        [WebMethod]
        public Productos getProducto(int id)
        {
            return productos.Where(p=> p.id == id).FirstOrDefault();
        }

        [WebMethod]
        public Productos addProductos(int id, string nome)
        {
            productos.Add(new Productos(id,nome));
            return productos.Where(p=> p.id == id).FirstOrDefault();
        }        
    }
}
