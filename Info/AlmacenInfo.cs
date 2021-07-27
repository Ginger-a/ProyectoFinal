using Modelo;
using Modelo.Empresa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Info
{
    public class AlmacenInfo : IEntityInfo
    {
 

        public static new string Publicar(IDBEntity entidad)
        {
            Almacen almacen = (Almacen)entidad;
            return String.Format(
                "{0} \n {1}",
                almacen.AlmacenId,
                almacen.Nombre
                );
        }

        public static new string Publicar(IEnumerable<IDBEntity> lista)
        {
            string mensaje = "AlmacenId\t Nombre\n";
            var listaAlmacen = (List<Almacen>) lista;
            foreach(var Almacen in listaAlmacen)
            {
                mensaje += String.Format(
                    "{0} \t {1}\n",
                    Almacen.AlmacenId,
                    Almacen.Nombre
                    );
            }
            return mensaje;


        }
    }
}
