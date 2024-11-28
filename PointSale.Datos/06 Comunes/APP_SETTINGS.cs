using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace PointSale.Datos._00_Sistema
{
    public class APP_SETTINGS
    {
        
        public APP_SETTINGS() {
            var path = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName, "appsettings.json");
            
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(path, optional: false, reloadOnChange: true);

            var _configuration = builder.Build();

            CadenaConexion = _configuration.GetConnectionString("ConnectionServer");
        }
        
        public string CadenaConexion { get; }

        public ServidorSMTP servidorSMTP;
    }
    public class ServidorSMTP
    {
        public ServidorSMTP(string _AccountEmail, string _PasswordEmail, string _ServerSMTP, string _PortTSL, string _EnableSsl) {
            AccountEmail = _AccountEmail;
            PasswordEmail = _PasswordEmail;
            ServerSMTP = _ServerSMTP;
            PortTSL = _PortTSL;
            EnableSsl = _EnableSsl;
        }

        public ServidorSMTP() {
            AccountEmail = "";
            PasswordEmail = ""; 
            ServerSMTP = "";
            PortTSL = "";
            EnableSsl = "";
        }
        public string AccountEmail { get;}
        public string PasswordEmail { get;}
        public string ServerSMTP { get; }
        public string PortTSL { get; }
        public string EnableSsl { get; }
    }
}
