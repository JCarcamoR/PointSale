using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using PointSale.Datos._00_Sistema;
using PointSale.Entidades._00_Sistema;
using PointSale.Entidades._06_Comunes;

namespace PointSale.Negocio._00_Sistema
{
    public class LoginBussines
    {
        public bool UserAutenticated { get; private set; }
        public bool SettingsSession { get; private set; }
        public int Time { get; }

        public Error error;

        private SYS_USUARIOS _usuario;
        private LoginData _loginData;

        public LoginBussines(SYS_USUARIOS usuario)
        {
            //_loginData = new LoginData();
            _usuario = usuario;
            error = new Error();
        }

        public void IniciaSession()
        {
            try
            {
                UserAutenticated = true;
                SettingsSession = false;

                error.EsError = false;
            }
            catch (Exception ex)
            {
                error.EsError = true;
                error.MensajeError = ex.Message;
            }
        }

        private void ValidaUsuario()
        {
            try
            {
                error.EsError = false;
            }
            catch (Exception ex) {
                error.EsError = true;
                error.MensajeError = ex.Message;
            }
        }

        private void IniciaSesionUsuario()
        {

        }


    }
}
