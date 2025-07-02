
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HortifrutidoTorin.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        [Display(Name = "Nome do Produto")]
        public string? Nome { get; set; }

        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Preço (R$)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Preco { get; set; }

        [Display(Name = "Imagem do Produto")]
        public string? ImagemUrl { get; set; }
    }
}