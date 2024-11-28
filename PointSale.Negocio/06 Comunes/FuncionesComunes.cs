using PointSale.Entidades._06_Comunes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PointSale.Negocio._06_Comunes
{
    public class FuncionesComunes
    {
        #region PropiedadesPublicas
        public Error error { get; }
        #endregion

        #region VariablesPrivadas
        #endregion

        #region Constructores
        public FuncionesComunes()
        {

        }
        #endregion

        public bool ValidarCaracteresEspeciales(string cadena)
        {
            bool result = false;
            try
            {
                string pattern = @"[áéíóúÁÉÍÓÚüÜñÑ¿¡´'|,:]";
                result = Regex.IsMatch(cadena, pattern) ? true : false;
            }
            catch (Exception ex) {
                error.EsError = true;
                error.MensajeError =  ex.ToString();
                result = true;
            }
            return result;
        }

        public bool ValidarEspacios(string cadena) 
        {
            bool result = false;
            try
            {
                result = cadena.Contains(' ') ? true : false;
            }
            catch (Exception ex) { 
                error.EsError = true; 
                error.MensajeError = ex.ToString();
            }
            return result;
        }

    }
}
