using System.ComponentModel.DataAnnotations.Schema;
using LanchoneteMVC.Models;

public class Lanche
{
    public int LancheId { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string DescricaoCurta { get; set; } = string.Empty;
    public string DescricaoDetalhada { get; set; } = string.Empty;

    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }
    public string ImagemUrl { get; set; } = string.Empty;
    public bool IsLanchePreferido { get; set; }
    public bool EmEstoque { get; set; }

    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; } = null!;
}