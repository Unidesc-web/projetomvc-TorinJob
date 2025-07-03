using System.Collections.Generic;

namespace LanchoneteMVC.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public List<Lanche> Lanches { get; set; } = new List<Lanche>();
    }
}