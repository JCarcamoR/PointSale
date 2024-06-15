using PointSale.Bussines.Servicios.Email;

namespace PointSale.Bussines.Sistema.Login
{
    public class LoginNegocio
    {

        public string EnvioDatosContacto(string JsonData)
        {
            try
            {
                EnvioEmail mail = new EnvioEmail();
                var resultado = string.Empty;





                return resultado;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
