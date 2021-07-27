using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Empresa
{
  public  class Marca:IDBEntity
    {
        public int MarcaId { get; set; }
       
        public string Nombre { get; set; }
        //relacion con productos
        public List<Producto> Productos { get; set; }
    }
}
