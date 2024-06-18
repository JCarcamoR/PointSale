using PointSale.Bussines.Servicios.Email;

namespace PointSale.Bussines.Sistema.Login
{
    public class LoginNegocio
    {
        public string EnvioDatosContacto(string NombreContacto, string Asunto, string Telefono, string Correo, string Cuerpo)
        {
            try
            {
                EnvioEmail mail = new EnvioEmail();
                var resultado = string.Empty;
                var cuerpo = $@"<html>
                                   <body>
                                       <p><b>{Cuerpo}</b></p>
                                       <br/>
                                       <p>Datos de contacto:</p>
                                       <ul>
                                           <li>Telefono: <b>{Telefono}</b></li>
                                           <li>Correo: <b>{Correo}</b></li>
                                       </ul>
                                       <p>Atentamente,<br /><b>{NombreContacto}</b></p>
                                   </body>
                               </html>";

                resultado = mail.EnviarEmailContacto(Asunto, cuerpo);

                return resultado;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
