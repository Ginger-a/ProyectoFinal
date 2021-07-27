using Esenario;
using Info;
using Persistencia;
using System;
using System.Linq;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Escenario = new Esecenario01();
            //var EscenarioControl = new EsenarioControl();
            //EscenarioControl.Grabar(Escenario);
            Esecenario01 escenario = new Esecenario01();
            EsenarioControl control = new EsenarioControl();
            control.Grabar(escenario);
            using ( var db = new StockContext())
            {
                var Alcamen = db.Almacen.ToList();
                Console.WriteLine(AlmacenInfo.Publicar(Alcamen));
               // var almacen = db.Almacen.Where(a => a.Nombre == "Japon").Single();
                Console.WriteLine(AlmacenInfo.Publicar(Alcamen));
            }
        }
    }
}
