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
    class NotaControllerTests
    {
        [Test]
        public void UsuarioIngresaAlIndex()
        {
            List<Nota> MisNotas = new List<Nota>();
            var userMock = new Mock<IUsuarioRepository>();
            var NotaMock = new Mock<INotaRepository>();
            var cookMock = new Mock<ICookieAuthService>();

            userMock.Setup(o => o.ObtenerUsuarioLogin(null)).Returns(new Usuario() { });

            NotaMock.Setup(o => o.MisNotas(new Usuario(), null));
            NotaMock.Setup(o => o.CategoriaDeNotas(MisNotas));
            NotaMock.Setup(o => o.TotalDeNotas(MisNotas));

            var configNota = new NotaController(  userMock.Object, cookMock.Object, NotaMock.Object,null,null);
            var guardarCom = configNota.Index(1,  "");

            Assert.IsInstanceOf<ViewResult>(guardarCom);
        }

    }
}
