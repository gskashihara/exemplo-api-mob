using BelMob.Core.Entidades;
using BelMob.Core.Interfaces.Repositorios;
using BelMob.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelMob.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SistemaContext _context;

        public UsuarioRepository(SistemaContext ctx)
        {
            _context = ctx;
        }

        public void Create(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.Include(i => i.Enderecos).ToList();
        }
    }
}
