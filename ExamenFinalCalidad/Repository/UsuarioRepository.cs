using ExamenFinalCalidad.DB.Maps;
using ExamenFinalCalidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ExamenFinalCalidad.Repository
{
    public interface IUsuarioRepository
    {
       public Usuario UsuarioNota(Nota Nota);
        public Usuario ObtenerUsuarioLogin(Claim claim);
        public Usuario EncontrarUsuario(String user, String password);
        public void AgregarUsuario(string Username, string Password, string Nombres);


        public Dictionary<int, String> IndicesPorId();
    }
    public class UsuarioRepository : IUsuarioRepository
    {
        private CalidadContext _context;

        public UsuarioRepository(CalidadContext context)
        {
            _context = context;
        }

        public void AgregarUsuario(string Username, string Password, string Nombres)
        {
            Usuario nuevo = new Usuario();
            nuevo.Username = Username;
            nuevo.Password = Password;
            nuevo.Nombres = Nombres;
            _context._Usuarios.Add(nuevo);
            _context.SaveChanges();
        }

        public Usuario EncontrarUsuario(string user, string password)
        {
            var Usuario = _context._Usuarios.Where(o => o.Username == user && o.Password == password).FirstOrDefault();
            return Usuario;
        }

        public Dictionary<int, string> IndicesPorId()
        {
            Dictionary<int, string> indices = new Dictionary<int, string>();
            var usuarios = _context._Usuarios.ToList();

            foreach (var item in usuarios)
            {
                indices.Add(item.Id, item.Nombres);
            }

            return indices;
        }

        public Usuario ObtenerUsuarioLogin(Claim claim)
        {
            var user = _context._Usuarios.FirstOrDefault(o => o.Username == claim.Value);
            return user;
        }

        public Usuario UsuarioNota(Nota Nota)
        {
            var Usuario = _context._Usuarios.FirstOrDefault(o => o.Id == Nota.IdCreador);
            return Usuario;
        }
    }
}
