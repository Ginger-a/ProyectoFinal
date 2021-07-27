using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
   public class StockConfig
    {
        public enum DestinoTipo { SQLServerEscuela, PostgresEscuela, MemoryEscuela };
        const string KeyPersistenciaDestino = "PersistenciaDestino";
        static DestinoTipo PersistenciaDestino;
        static string StringConnection;

        static StockConfig()
        {
            if (String.IsNullOrEmpty(StringConnection))
            {
                // Lectura de los parámetros del sistema
                PersistenciaDestino = (DestinoTipo)Enum.Parse(typeof(DestinoTipo), ConfigurationManager.AppSettings[KeyPersistenciaDestino].ToString());
                StringConnection = ConfigurationManager.ConnectionStrings[PersistenciaDestino.ToString()].ToString();
                // Debug
                Console.WriteLine(PersistenciaDestino + " --> " + StringConnection);
            }
        }

        static public void ContextOptions(DbContextOptionsBuilder optionsBuilder)
        {
            switch (PersistenciaDestino)
            {
                case DestinoTipo.SQLServerEscuela:
                    optionsBuilder.UseSqlServer(StringConnection);
                    break;
                case DestinoTipo.PostgresEscuela:
                    optionsBuilder.UseNpgsql(StringConnection);
                    break;
                case DestinoTipo.MemoryEscuela:
                    optionsBuilder.UseInMemoryDatabase(StringConnection);
                    break;
                default:
                    break;
            }
        }
    }
}
