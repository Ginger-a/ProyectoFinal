using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Empresa
{
   public class Configuracion : IDBEntity
    {
        public int ConfiguracionId { get; set; }
        public string NombreEmpresa { get; set; }
        public int valorminimo { get; set; }

        //Stock minimo 
        public float PesoCantidad { get; set; }
        public float PesoStock { get; set; }

        //Total 
        public float Stockminimo { get; set; }
    }
}
