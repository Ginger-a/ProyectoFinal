using Modelo;
using Modelo.Empresa;
using System;
using System.Collections.Generic;

namespace Esenario
{
    public class Esecenario01 : Esenario, IEsenario
    {
        public Dictionary<ListaTipo, IEnumerable<IDBEntity>> carga()
        {
            Producto SamgungA20 = new()
            {
                Modelo = "Galaxy A20",
                Stock = 34
                
            };
            Producto SamgungA10 = new() { Modelo = "Galaxy a10", Stock = 35 };
            List<Producto> listaProductos = new() { SamgungA10, SamgungA20 };
            datos.Add(ListaTipo.Producto, listaProductos);
            Pedido per2020_PAO2 = new()
            {

                FechaPedida = new DateTime(2020, 9, 1),
                FechaFin = new DateTime(2021, 3, 1)
            };
            Pedido per2021_PAO1 = new() { FechaPedida = new DateTime(2021, 4, 1), FechaFin = new DateTime(2021, 9, 1) };
            Pedido per2021_PAO2 = new() { FechaPedida = new DateTime(2021, 9, 1), FechaFin = new DateTime(2022, 3, 1) };
            List<Pedido> listaPedidos = new() { per2020_PAO2, per2021_PAO1, per2021_PAO2 };
            datos.Add(ListaTipo.Pedido, listaPedidos);

            // .- Configuración de los datos de almacen
            Configuracion configuracion = new(){
                NombreEmpresa = "Empresa Japon",
                valorminimo = 24,
                PesoCantidad = 7.00f,
                PesoStock = 0.35f,
                Stockminimo = 0.35f
            };
            List<Configuracion> listaConfiguracion = new() { configuracion };
            datos.Add(ListaTipo.Configuracion, listaConfiguracion);

            // .- Registro de Almacen
            Almacen estJapon = new() { Nombre = "Empresa Japon" };
            Almacen estComandato = new() { Nombre = "Empresa Comandato" };
            Almacen estLaGanga = new() { Nombre = "Empresa La Ganga" };
            List<Almacen> lstAlmacen = new() { estJapon, estComandato, estLaGanga };
            datos.Add(ListaTipo.Almacen, lstAlmacen);
            //.- Registro de Pendiente
            Movimiento Pendiente = new Movimiento()
            {
                TipoMovimiento = "Egreso",
                Estado = "Pendiente",
                FechaInicio = new DateTime(2021, 7, 25),
                FechaFin = new DateTime(2021, 7, 28),
                Cantidad = 6,
                Producto = SamgungA20
            };
            Movimiento Ingreso = new Movimiento()
            {
                TipoMovimiento = "Ingreso",
                Estado = "Espera",
                FechaInicio = new DateTime(2021, 7, 28),
                FechaFin = new DateTime(2021, 8, 1),
                Cantidad = 6,
                Producto = SamgungA10

            };

            List<Movimiento> lstMovimiento = new()
            {
                Ingreso,
                Pendiente
            };
            datos.Add(ListaTipo.Movimiento, lstMovimiento);

            Marca Samgung = new Marca()
            {
                Nombre = "Samgung"
               
            };
            List<Marca> listamarca = new()
            {
                Samgung
            };
            datos.Add(ListaTipo.Marca, listamarca);

            Provedores GingerMuñoz = new Provedores()
            {
                Nombre = "Ginger Muñoz Mora",
                Cantidadminima = 34,
                Plazodeentrega = new DateTime (2021,7,26)

                    
            };
            List<Provedores> listaProvedores = new() { GingerMuñoz };
            datos.Add(ListaTipo.Provedores, listaProvedores);
            
            return datos;
        }
    }
}
