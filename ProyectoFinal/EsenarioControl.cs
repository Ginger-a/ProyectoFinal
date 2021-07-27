using Esenario;
using Modelo.Empresa;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using static Esenario.Esenario;

namespace ProyectoFinal
{
    class EsenarioControl
    {
        public void Grabar(IEsenario escenario)
        {
            var datos = escenario.carga();
            using (var db = new StockContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
                db.Movimiento.AddRange((List<Movimiento>)datos[ListaTipo.Movimiento]);
                db.Producto.AddRange((List<Producto>)datos[ListaTipo.Producto]);
                db.Configuracion.AddRange((List<Configuracion>)datos[ListaTipo.Configuracion]);
                db.Almacen.AddRange((List<Almacen>)datos[ListaTipo.Almacen]);
                db.Marca.AddRange((List<Marca>)datos[ListaTipo.Marca]);
                db.Pedido.AddRange((List<Pedido>)datos[ListaTipo.Pedido]);
                db.Provedores.AddRange((List<Provedores>)datos[ListaTipo.Provedores]);
                db.SaveChanges();
            }

        }
           

    }
}
