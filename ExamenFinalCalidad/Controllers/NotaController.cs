    using ExamenFinalCalidad.Models;
using ExamenFinalCalidad.Repository;
using ExamenFinalCalidad.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalCalidad.Controllers
{

    public class NotaController : Controller
    {
        private readonly IUsuarioRepository _usuario;
        private readonly ICookieAuthService _cookieAuthService;
        private readonly INotaRepository _nota;
        private readonly IEtiquetaRepository _etiqueta;

        private readonly IDetalleUsuarioNotaRepository _detalleUsuarioNota;
        public NotaController(IUsuarioRepository _usuario, ICookieAuthService _cookieAuthService, INotaRepository _nota, IEtiquetaRepository _etiqueta, IDetalleUsuarioNotaRepository _detalleUsuarioNota)
        {

            this._usuario = _usuario;
            this._cookieAuthService = _cookieAuthService;
            this._nota = _nota;
            this._etiqueta = _etiqueta;
            this._detalleUsuarioNota = _detalleUsuarioNota;
        }

        public IActionResult Index(int IdNota, String busqueda = " ")
        {
            Usuario user = LoggedUser();

            ViewBag.UsuarioId = user.Id;
            ViewBag.NombreUsuario = user.Nombres;

            var MisNotas = _nota.MisNotas(user, busqueda);
            ViewBag.Categorias = _nota.CategoriaDeNotas(MisNotas);
            ViewBag.Cantidad = _nota.TotalDeNotas(MisNotas);

            return View();
        }

        public IActionResult CrearNotaInterface()
        {
            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;
            ViewBag.Categorias = _etiqueta.Categorias();
            return View();
        }

        public IActionResult CrearNotaForm(String Nota, int categoria)
        {
            if(Nota == null)
            {
                return RedirectToAction("CrearNotaInterface");
            }
            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;
            _nota.CrearNota(Nota, categoria, user);

            HttpContext.Response.StatusCode = 200;

            return RedirectToAction("NotasCreadasPorUsuario", "Nota");
        }



        public IActionResult DetalleNota(int Id)
        {
            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;
            ViewBag.NombreUsuario = user.Nombres;

            var notaDetalle = _detalleUsuarioNota.DetalleNota(Id);
            ViewBag.Nota = notaDetalle;

            var Usuario = _usuario.UsuarioNota(notaDetalle);

            ViewBag.usuariosIndice = _usuario.IndicesPorId();

            return View();

        }

        public IActionResult DetalleNotaLogout(int Id)
        {

            var notaDetalle = _detalleUsuarioNota.DetalleNota(Id);
            ViewBag.Nota = notaDetalle;

            var Usuario = _usuario.UsuarioNota(notaDetalle);
            ViewBag.Usuario = Usuario;

            return View();
        }

        public IActionResult TodasLasNotas(String busqueda = "")
        {
            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;
            ViewBag.NombreUsuario = user.Nombres;

            var notas = _nota.TodasLasNotas(busqueda);
            ViewBag.Notas = notas;

            var categorias = _nota.CategoriaDeNotas(notas);
            ViewBag.Categorias = categorias;

            return View(); 

        }

        public IActionResult TodasLasNotasLogout(String busqueda = "")
        {
            var notas = _nota.TodasLasNotas(busqueda);
            ViewBag.Notas = notas;

            var categorias = _nota.CategoriaDeNotas(notas);
            ViewBag.Categorias = categorias;
            return View();
        }

        public IActionResult agregarNota(int Id)
        {
            Usuario user = LoggedUser();
            if(user != null)
            {
                ViewBag.UsuarioId = user.Id;
                _nota.AgregarNota(Id, user);
                return RedirectToAction("TodasLasNotas", "Notas");
            }
            return RedirectToAction("Login", "Auth");
        }

        public IActionResult desagregarNota(int Id)
        {
            Usuario user = LoggedUser();
            ViewBag.UsuarioId = user.Id;
            _nota.DesagregarNota(Id, user);

            return RedirectToAction("Index", "Nota");
        }

        public IActionResult NotasCreadasPorUsuario()
        {
            Usuario user = LoggedUser();
            ViewBag.UsurioId = user.Id;
            ViewBag.NombreUsuario = user.Nombres;
            var notas = _nota.NotasCreadas(user);

            ViewBag.Usuario = user.Nombres;
            ViewBag.NotasCreadasPorUsuario = notas;

            ViewBag.Cantidad = notas.Count();

            var categorias = _nota.CategoriaDeNotas(notas);
            ViewBag.Categorias = categorias;

            return View();

        }
        
        public IActionResult EditarNota(int Id)
        {
            var nota = _nota.BuscarNotaId(Id);
            ViewBag.Nota = nota;
            ViewBag.Categorias = _etiqueta.Categorias();

            return View();
               
        }

        public IActionResult EditarNotaForm(int Id, String Nombre, int Categoria)
        {
            _nota.EditarNota(Id, Nombre, Categoria);
            return RedirectToAction("NotasCreadasPorUsuario", "Nota");

        }





        private Usuario LoggedUser()
        {
            _cookieAuthService.SetHttpContext(HttpContext);
            var claim = _cookieAuthService.ObtenerClaim();
            var user = _usuario.ObtenerUsuarioLogin(claim);
            return user;
        }


    }
}
