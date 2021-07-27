using Modelo.Empresa;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;

namespace Procesos
{
    public class MovimientoPro
    {
        public StockContext _context;

        public MovimientoPro(StockContext context)
        {
            _context = context;
        }

        static public bool ConsultaMovimiento (string stringProducto)
        {
            Movimiento movimiento;
             using ( var db = new StockContext())
            {
                movimiento = db.Movimiento
                    .Include(prop => prop.Producto)
            }
        }
    }
}
