
using HortifrutidoTorin.Models;
using Microsoft.AspNetCore.Mvc;

namespace HortifrutidoTorin.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            var produtos = GetListaDeProdutos();
            return View(produtos);
        }

        private List<Produto> GetListaDeProdutos()
        {
            return new List<Produto>
            {
                new Produto { Id = 1, Nome = "Maçã Fuji", Descricao = "Maçã Fuji fresca e crocante.", Preco = 7.99m, ImagemUrl = "https://cdn.pixabay.com/photo/2017/09/26/13/21/apple-2788662_960_720.jpg" },
                new Produto { Id = 2, Nome = "Banana Prata", Descricao = "Banana rica em potássio.", Preco = 5.50m, ImagemUrl = "https://cdn.pixabay.com/photo/2016/02/23/19/38/bananas-1218733_960_720.jpg" },
                new Produto { Id = 3, Nome = "Alface Crespa", Descricao = "Folhas verdes para salada.", Preco = 3.20m, ImagemUrl = "https://cdn.pixabay.com/photo/2016/09/13/18/38/lettuce-1667922_960_720.jpg" },
                new Produto { Id = 4, Nome = "Tomate Italiano", Descricao = "Tomate maduro para molhos.", Preco = 8.40m, ImagemUrl = "https://cdn.pixabay.com/photo/2018/08/16/22/59/tomatoes-3611404_960_720.jpg" }
            };
        }
    }
}