using PointSale.Datos._00_Sistema;
using PointSale.Entidades._06_Comunes;
using PointSale.Negocio._06_Comunes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PointSale.Negocio._00_Sistema
{
    public class MenuBussines
    {
        #region PropiedadesPublicas
        public List<SYS_MENUS> ltsMenus { get; private set; }
        public Error error { get; }
        #endregion

        #region VariablesPrivadas
        private FuncionesComunes funciones;
        private MenuData menuData;
        #endregion

        #region Constructores
        public MenuBussines()
        {
            funciones = new FuncionesComunes();
            ltsMenus = new List<SYS_MENUS>();
            menuData = new MenuData();
            error = new Error();
        }
        #endregion

        public void ObtenerMenuPerfil(string CAT_DS_PERFIL)
        {
            var menuData = new MenuData();
            try
            {
                ValidaFormatoUsuario(CAT_DS_PERFIL);
                if (!error.EsError) 
                {
                    menuData.ObtenerMenusPerfil(CAT_DS_PERFIL);
                    if (!menuData.error.EsError)
                    {
                        ltsMenus = menuData.ltsMenus;
                    }
                }
            }
            catch (Exception ex)
            {
                error.EsError = true;
                error.MensajeError = ex.ToString();
            }
        }

        private void ValidaFormatoUsuario(string CAT_DS_PERFIL)
        {
            try
            {
                if (funciones.ValidarCaracteresEspeciales(CAT_DS_PERFIL))
                {
                    error.EsError = true;
                    error.MensajeError = "NO SE PUEDEN OBTENER LOS ACCESOS DEBIDO A UN ERROR EN EL PERFIL DE USUARIO";
                }

                if (funciones.ValidarEspacios(CAT_DS_PERFIL))
                {
                    CAT_DS_PERFIL = CAT_DS_PERFIL.Trim();
                }

                if (CAT_DS_PERFIL.Any(char.IsLower))
                {
                    CAT_DS_PERFIL = CAT_DS_PERFIL.ToUpper();
                }

                if (CAT_DS_PERFIL.Any(char.IsDigit))
                {
                    CAT_DS_PERFIL = Regex.Replace(CAT_DS_PERFIL, @"\d", "");
                }

                error.EsError = false;
            }
            catch (Exception ex)
            {
                error.EsError = true;
                error.MensajeError = ex.ToString();
            }
        }
    }
}
