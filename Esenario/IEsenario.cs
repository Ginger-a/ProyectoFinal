using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Esenario.Esenario;

namespace Esenario
{
    public interface IEsenario
    {
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> carga();
    }
}
