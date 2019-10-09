using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceValdanio
{
    public class Productos
    {

        public int Id;
        public string Nome;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public Productos(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Productos() { }


    }
}