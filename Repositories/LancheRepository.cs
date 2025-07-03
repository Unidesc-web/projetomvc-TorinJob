using LanchoneteMVC.Data;
using LanchoneteMVC.Models;
using LanchoneteMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LanchoneteMVC.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
                                                               .Where(l => l.IsLanchePreferido)
                                                               .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId) => _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
    }
}