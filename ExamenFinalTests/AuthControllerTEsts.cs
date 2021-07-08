using ExamenFinalCalidad.Controllers;
using ExamenFinalCalidad.Models;
using ExamenFinalCalidad.Repository;
using ExamenFinalCalidad.Service;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenFinalTests
{
    class AuthControllerTEsts
    {

        [Test]
        public void UsuarioSeLoguea()
        {
            var usuario = new Usuario();

            usuario.Password = "ricardo";
            usuario.Username = "ricardo";


            var userMock = new Mock<IUsuarioRepository>();
            userMock.Setup(o => o.EncontrarUsuario(usuario.Username, usuario.Password)).Returns(usuario);

            var cookMock = new Mock<ICookieAuthService>();

            var authCont = new AuthController(userMock.Object, cookMock.Object);
            var log = authCont.Login("ricardo", "ricardo");

            Assert.IsInstanceOf<RedirectToActionResult>(log);
        }


        [Test]
        public void UsuarioNoSeLoguea()
        {
            var usuario = new Usuario();

            usuario.Password = "ricardoEpiquien";
            usuario.Username = "admin345";


            var userMock = new Mock<IUsuarioRepository>();
            userMock.Setup(o => o.EncontrarUsuario(usuario.Username, usuario.Password)).Returns(usuario);

            var cookMock = new Mock<ICookieAuthService>();

            var authCont = new AuthController(userMock.Object, cookMock.Object);

            var log = authCont.Login("ricardoEpiquien", "admin345");

            Assert.IsInstanceOf<ViewResult>(log);
        }
    }
}
