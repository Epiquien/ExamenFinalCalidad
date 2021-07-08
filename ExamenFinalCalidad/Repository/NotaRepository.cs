using ExamenFinalCalidad.DB.Maps;
using ExamenFinalCalidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinalCalidad.Repository
{
    public interface INotaRepository
    {
        public List<int> IndiceDeNotas(Usuario user);
        public List<Nota> MisNotas (Usuario user, String busqueda);
        public Dictionary<int, String> CategoriaDeNotas(List<Nota> MisNotas);
        public List<Nota> TodasLasNotas(String busqueda);
        //public List<Nota> TodasLasNotas();
        public void CrearNota(String Nota, int Categoria, Usuario user);

        public int TotalDeNotas(List<Nota> Notas);

       

        public void AgregarNota(int Id, Usuario user);

        public void DesagregarNota(int Id, Usuario user);

        public Nota BuscarNotaId(int Id);

        public void EditarNota(int Id, string Nombre, int Categoria);

        public List<Nota> NotasCreadas(Usuario user);

        
    }
    public class NotaRepository : INotaRepository
    {
        private CalidadContext _context;

        public NotaRepository(CalidadContext context)
        {
            _context = context;
        }

        public void AgregarNota(int Id, Usuario user)
        {
            DetalleUsuarioNota nuevoDetalleUsuarioNota = new DetalleUsuarioNota();

            nuevoDetalleUsuarioNota.Estado = true;
            nuevoDetalleUsuarioNota.IdNota = Id;
            nuevoDetalleUsuarioNota.IdUsuario = user.Id;

            _context._DetalleUsuarioNotas.Add(nuevoDetalleUsuarioNota);
            _context.SaveChanges();

            Nota nuevo = new Nota();
            nuevo.ContenidoNota = "";
            nuevo.TituloNota = "";
            _context._Notas.Add(nuevo);
            _context.SaveChanges();
        }

        public Nota BuscarNotaId(int Id)
        {
            var nota = _context._Notas.Where(o => o.IdNota == Id).FirstOrDefault();
            return nota;
        }

        public Dictionary<int, string> CategoriaDeNotas(List<Nota> MisNotas)
        {
            Dictionary<int, String> categorias = new Dictionary<int, string>();
            var categoriasa = _context._Etiquetas.ToList();
            foreach (var item in MisNotas)
            {
                categorias.Add(item.IdNota, _context._Etiquetas.Where(o => o.IdEtiqueta == item.IdCategoria).FirstOrDefault().NombreEtiqueta);
            }

            return categorias;
        }

        public void CrearNota(string Nota, int categoria, Usuario user)
        {
            Nota NotaCreada = new Nota();
            NotaCreada.TituloNota = Nota;
            NotaCreada.ContenidoNota = Nota;
            NotaCreada.Fecha = DateTime.Now;
            NotaCreada.IdCategoria = categoria;
            _context._Notas.Add(NotaCreada);
            _context.SaveChanges();


        }

        public void DesagregarNota(int Id, Usuario user)
        {
            var notaQuitar = _context._DetalleUsuarioNotas
                .FirstOrDefault(o => o.IdNota == Id && o.IdUsuario == user.Id);
            _context._DetalleUsuarioNotas.Remove(notaQuitar);
            _context.SaveChanges();

        }

       

        public void EditarNota(int Id, string Nombre, int Categoria)
        {
            var nota = _context._Notas.Where(o => o.IdNota == Id).FirstOrDefault();
            nota.IdNota = Id;
            nota.TituloNota = Nombre;
            nota.IdCategoria = Categoria;
            _context.SaveChanges();
        }

        public List<int> IndiceDeNotas(Usuario user)
        {
            var indices = _context._DetalleUsuarioNotas.Where(o => o.IdUsuario == user.Id).ToList()
                .Select(o => o.IdNota).ToList();
            return indices;

        }

        public List<Nota> MisNotas(Usuario user, String busqueda)
        {
            var indicesDeMisNotas = IndiceDeNotas(user);
            List<Nota> MisNotas = new List<Nota>();
            var notas = _context._Notas.ToList();
            for (int i = 0; i < notas.Count; i++)
            {
                if(indicesDeMisNotas.Contains(notas[i].IdNota))
                {
                    MisNotas.Add(notas[i]);
                }
            }
            if(busqueda=="" || busqueda == null)
            {
                return MisNotas;
            }

            return MisNotas.Where(o => o.TituloNota.ToLower().Contains(busqueda.ToLower())).ToList();
        }

        public List<Nota> NotasCreadas(Usuario user)
        {
            var notas = _context._Notas.Where(o => o.IdCreador == user.Id).ToList();
            return notas;
        }

        public List<Nota> TodasLasNotas(String busqueda)
        {

            if (busqueda == "" || busqueda == null)
            {
                return _context._Notas.ToList();
            }
            var Notas = _context._Notas.ToList().Where(o => o.TituloNota.ToLower().Contains(busqueda.ToLower())).ToList();
            return Notas;
        }

        public int TotalDeNotas(List<Nota> Notas)
        {
            var TotalDeNotas = Notas.Count();
            return TotalDeNotas;
        }
    }
}
