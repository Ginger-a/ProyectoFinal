using Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Info
{
   public abstract class IEntityInfo
    {
        public static string Publicar(IDBEntity entidad)
        {
            return "";
        }
        public static string Publicar(IEnumerable<IDBEntity> lista)
        {
            return  "";
        }
    }
}
