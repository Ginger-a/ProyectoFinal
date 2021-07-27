using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Empresa
{
   public class Provedores : IDBEntity
    {
        public int ProvedoresId { get; set; }
        public string Nombre { get; set; }
        

        public DateTime Plazodeentrega { get; set; }
        public double Cantidadminima { get; set; }
     
        //public List<Producto> Productos { get; set; }
    }
}
