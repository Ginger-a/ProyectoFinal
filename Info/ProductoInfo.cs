using Modelo;
using Modelo.Empresa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Info
{
   public class ProductoInfo : IEntityInfo

    {
        public new static string Publicar (IDBEntity entidad)
        {
            var producto = (Producto)entidad;
            return String.Format(
                "{0} \n {1} \n {2}",
                producto.ProductoId,
                producto.Stock,
                producto.Modelo
                );
        }
        public static new string Publicar(IEnumerable<IDBEntity> lista)
        {
            string mensaje = "ProductoId \t Stock\n Modelo \n";
            var listaProductos = (List<Producto>)lista;
            foreach (var producto in listaProductos)
            {
                mensaje += String.Format(
                    "{0} \t {1} \n {2} \n",
                    producto.ProductoId,
                    producto.Stock,
                    producto.Modelo
                    );
            }
            return mensaje;
        }
    }
}
