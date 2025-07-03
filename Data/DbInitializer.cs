using LanchoneteMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LanchoneteMVC.Data
{
    public class DbInitializer
    {
        public static void Initialize(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>()!;

                context.Database.EnsureCreated();

                
                if (!context.Categorias.Any())
                {
                    context.Categorias.AddRange(new List<Categoria>
                    {
                        new Categoria { Nome = "Normal", Descricao = "Lanches feitos com os melhores ingredientes" },
                        new Categoria { Nome = "Natural", Descricao = "Lanches para uma refeição leve e saudável" }
                    });
                    context.SaveChanges();
                }

                
                if (!context.Lanches.Any())
                {
                    context.Lanches.AddRange(new List<Lanche>
                    {
                        new Lanche
                        {
                            Nome = "X-Salada",
                            DescricaoCurta = "Pão, hambúrguer, queijo, alface e tomate",
                            DescricaoDetalhada = "Um clássico que nunca sai de moda. Hambúrguer de 150g, queijo mussarela derretido, rodelas de tomate fresco e alface crocante no pão de brioche.",
                            Preco = 22.50m,
                            ImagemUrl = "/images/x-salada.png",
                            CategoriaId = 1,
                            IsLanchePreferido = true,
                            EmEstoque = true

                        },
                        new Lanche
                        {
                            Nome = "Sanduíche de Frango Grelhado",
                            DescricaoCurta = "Pão integral, frango grelhado, e salada",
                            DescricaoDetalhada = "Uma opção leve e deliciosa. Filé de frango grelhado no ponto, servido no pão integral com alface, tomate e um toque de maionese light.",
                            Preco = 25.00m,
                           ImagemUrl = "/images/sanduiche-frango.png",
                           CategoriaId = 1,
                           IsLanchePreferido = true,
                           EmEstoque = true
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}