﻿using LanchoneteMVC.Data;
using LanchoneteMVC.Models;
using LanchoneteMVC.Repositories.Interfaces;

namespace LanchoneteMVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias.OrderBy(c => c.Nome);
    }
}