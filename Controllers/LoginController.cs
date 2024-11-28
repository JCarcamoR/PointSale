using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PointSale.Entidades._00_Sistema;
using PointSale.Negocio._00_Sistema;
using System.Data.SqlClient;
using System.Security.Claims;

namespace PointSale.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult login()
        {
            ClaimsPrincipal c = HttpContext.User;
            if (c.Identity != null)
            {
                if (c.Identity.IsAuthenticated)
                {
                    HttpContext.Session.SetString("UserAuAuthenticated", "true");
                    ViewBag.userAutenticated = "true";
                    return RedirectToAction("Index", "Home");
                }
            }
            HttpContext.Session.SetString("UserAuAuthenticated", "false");
            ViewBag.userAutenticated = "false";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(SYS_USUARIOS user)
        {
            LoginBussines SessionUser = new LoginBussines(user);
            SessionUser.IniciaSession();

            if (SessionUser.UserAutenticated) { 
                List<Claim> claims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.NameIdentifier, user.SUO_DS_CLAVE)
                        };
                ClaimsIdentity claim = new(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties property = new();
                property.AllowRefresh = true;
                property.IsPersistent = false;
                property.ExpiresUtc = SessionUser.SettingsSession ? 
                                      DateTime.UtcNow.AddMinutes(SessionUser.Time) : 
                                      DateTime.UtcNow.AddMinutes(1);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claim), property);
                HttpContext.Session.SetString("UserAuAuthenticated", "true");
                return RedirectToAction("Index", "Home");
            } else
            {
                ViewBag.Error = SessionUser.error.MensajeError;
                return View();
            }
        }

        [HttpPost]
        public JsonResult SolicitudContacto(string NombreContacto, string Asunto, string Telefono, string Correo, string Cuerpo)
        {
            //LoginNegocio bLogin = new LoginNegocio();

            //string resultado = bLogin.EnvioDatosContacto(NombreContacto, Asunto, Telefono, Correo, Cuerpo);

            //object response;

            //if (resultado == "OK")
            //{
            //    response = new
            //    {
            //        Resultado = "OK",
            //        Mensaje = "La solicitud de contacto se ha enviado correctamente."
            //    };
            //}
            //else
            //{
            //    response = new
            //    {
            //        Resultado = "ERROR",
            //        Mensaje = resultado
            //    };
            //}

            return null;
        }
    }
}