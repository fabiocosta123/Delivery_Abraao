using Delivery_Abraao.Context;
using Delivery_Abraao.Models;
using Delivery_Abraao.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Delivery_Abraao.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido)
            .Include(c => c.Categoria);

        public Lanche GetLancheById(int LancheId) => _context.Lanches.FirstOrDefault(l => l.LancheId == LancheId);
    }
}
