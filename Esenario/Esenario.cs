using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esenario
{
   public class Esenario
    {
        public enum ListaTipo
        {
            Almacen,
            Configuracion,
            Marca,
            Movimiento,
            Pedido,
            Producto,
            Provedores,
           
        }
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> datos;

        public Esenario()
        {
             datos = new();
        }
    }
}
