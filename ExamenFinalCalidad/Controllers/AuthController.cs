using ExamenFinalCalidad.Repository;
using ExamenFinalCalidad.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ExamenFinalCalidad.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUsuarioRepository _usuario;
        private readonly ICookieAuthService _cookieAuthService;

        public AuthController(IUsuarioRepository _usuario, ICookieAuthService _cookieAuthService)
        {

            this._usuario = _usuario;
            this._cookieAuthService = _cookieAuthService;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var usuario = _usuario.EncontrarUsuario(username, password);
            if (usuario != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                _cookieAuthService.SetHttpContext(HttpContext);
                _cookieAuthService.Login(claimsPrincipal);


                return RedirectToAction("TodasLasNotas", "Nota");
            }

            ViewBag.Validation = "Usuario y/o contraseña incorrecta";
            return View();
        }

        public IActionResult Registrar()
        {
            return View();
        }
        public IActionResult RegisterC(string Username, string Password, string Nombres)
        {
            _usuario.AgregarUsuario(Username, Password, Nombres);
            return RedirectToAction("Login", "Auth");
        }

    }
}
