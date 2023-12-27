using Delivery_Abraao.Context;
using Delivery_Abraao.Models;
using Delivery_Abraao.Repositories.Interfaces;

namespace Delivery_Abraao.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
