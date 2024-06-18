using Microsoft.Extensions.DependencyInjection;
using PointSale.Data;
using PointSale.Models;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace PointSale.Bussines.Servicios.Email
{
    public class EnvioEmail
    {
        private string EmailContacto;
        private string Email;
        private string PwdEmail;
        private string Servidor;
        private string UsoSSL;
        private string Puerto;

        public EnvioEmail() {
            CargaServicioEnvioEmail();
        }

        private void CargaServicioEnvioEmail()
        {
            List<Parametros> ConfiguracionSMPT = new List<Parametros>();
            AdministracionBD BD = new AdministracionBD();
            ConfiguracionSMPT = BD.GetParametros(1);
            if(ConfiguracionSMPT.Count > 0)
            {
                Email = (from configuracion in ConfiguracionSMPT
                         where configuracion.DescParametro == "EMAIL"
                         select configuracion.ParValor).FirstOrDefault();

                PwdEmail = (from configuracion in ConfiguracionSMPT
                            where configuracion.DescParametro == "PWD_EMAIL"
                            select configuracion.ParValor).FirstOrDefault();

                Servidor = (from configuracion in ConfiguracionSMPT
                            where configuracion.DescParametro == "SERVIDOR"
                            select configuracion.ParValor).FirstOrDefault();

                Puerto = (from configuracion in ConfiguracionSMPT
                          where configuracion.DescParametro == "PUERTO"
                          select configuracion.ParValor).FirstOrDefault();

                UsoSSL = (from configuracion in ConfiguracionSMPT
                          where configuracion.DescParametro == "SSL"
                          select configuracion.ParValor).FirstOrDefault();

                EmailContacto = (from configuracion in ConfiguracionSMPT
                                 where configuracion.DescParametro == "EMAIL_CONTACTO"
                                 select configuracion.ParValor).FirstOrDefault();
            }
            else
            {
                Email = "correoPuntoVenta@dominio.com";
                PwdEmail = "contraseñaCorreo";
                Servidor = "smtp-mail.outlook.com";
                Puerto = "587";
                UsoSSL = "true";
            }
        }

        public string EnviarEmailContacto(string asunto, string cuerpo)
        {
            try
            {
                var mensaje = "OK";

                MailMessage oMensaje = new MailMessage(Email, EmailContacto, asunto, cuerpo);
                oMensaje.IsBodyHtml = true;

                SmtpClient oSmptClient = new SmtpClient(Servidor);
                oSmptClient.EnableSsl = true;
                oSmptClient.UseDefaultCredentials = false;
                oSmptClient.Port = Convert.ToInt16(Puerto);
                oSmptClient.Credentials = new NetworkCredential(Email, PwdEmail);
                oSmptClient.Send(oMensaje);
                oSmptClient.Dispose();

                return mensaje;
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
