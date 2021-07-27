using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Empresa
{
    public class Producto : IDBEntity
    {
        public int ProductoId { get; set; }
        public int Stock { get; set; }
        public string Modelo { get; set; }
        //Relacion con marca
        public Marca Marca { get; set; }
        public int MarcaId { get; set; }
        //relacion con provedores
        public Provedores Provedores { get; set; }
        public int ProvedoresId { get; set; }
        //relacion con moviiento  
        public List<Movimiento> Movimiento { get; set; }
        //pedidio 
        public List<Pedido> Pedidos { get; set; }
        public int PedidoId { get; set; }


    }
}
