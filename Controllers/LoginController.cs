using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PointSale.Bussines.Sistema.Login;
using PointSale.Data;
using PointSale.Models;
using System.Data.SqlClient;
using System.Security.Claims;
using System.Web.Helpers;
using System.Web.Mvc.Ajax;

namespace PointSale.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context _contexto;

        public LoginController(Context contexto)
        {
            _contexto = contexto;
        }

        public IActionResult login()
        {
            ClaimsPrincipal c = HttpContext.User;
            if (c.Identity != null)
            {
                if (c.Identity.IsAuthenticated)
                {
                    TempData["UserAuAuthenticated"] = true;
                    return RedirectToAction("Index", "Home");
                }
            }
            TempData["UserAuAuthenticated"] = false;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Usuarios user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_contexto.Conexion))
                {
                    using (SqlCommand command = new SqlCommand("SpSel_Usuario_01", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.Add("@Usuario", System.Data.SqlDbType.VarChar).Value = user.Username;
                        command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar).Value = user.Password;

                        connection.Open();
                        var dataReader = command.ExecuteReader();
                        while (dataReader.Read())
                        {
                            if (dataReader["UserName"] != null && user.Username != null)
                            {
                                List<Claim> claims = new List<Claim>()
                                {
                                    new Claim(ClaimTypes.NameIdentifier, user.Username)
                                };
                                ClaimsIdentity claim = new(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                                AuthenticationProperties property = new();
                                property.AllowRefresh = true;
                                property.IsPersistent = user.MySession;

                                if (!user.MySession)
                                {
                                    property.ExpiresUtc = DateTime.UtcNow.AddMinutes(1);  // tiempo de espera para cierre de session en caso de no mantenerla activa
                                }
                                else
                                {
                                    property.ExpiresUtc = DateTimeOffset.UtcNow.AddDays(1); // se mantiene activa hasta por 24 hrs
                                }
                                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claim), property);
                                TempData["UserAuAuthenticated"] = true;
                                return RedirectToAction("Index", "Home");
                            }
                            else
                            {
                                ViewBag.Error = "Credenciales Erroneas";
                            }
                        }
                        connection.Close();
                    }
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.ToString();
                return View();
            }
        }

        [HttpPost]
        public JsonResult SolicitudContacto(string NombreContacto, string Asunto, string Telefono, string Correo, string Cuerpo)
        {
            LoginNegocio bLogin = new LoginNegocio();

            string resultado = bLogin.EnvioDatosContacto(NombreContacto, Asunto,  Telefono,  Correo,  Cuerpo);

            object response;

            if(resultado == "OK")
            {
                response = new
                {
                    Resultado = "OK",
                    Mensaje = "La solicitud de contacto se ha enviado correctamente."
                };
            }
            else
            {
                response = new
                {
                    Resultado = "ERROR",
                    Mensaje = resultado
                };
            }

            return Json(response);
        }
    }
}