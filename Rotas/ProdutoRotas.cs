using api_dotnet.Models;

namespace api_dotnet.Rotas
{
    public static class ProdutoRotas
    {

        public static List<Produto> Produtos = new List<Produto>(){};

    

        public static void MapProdutoRotas(this WebApplication app) 
        {
            app.MapGet("/produtos", () =>
               Produtos
           );

            app.MapGet("/produtos/{nome}", (string nome) =>
               Produtos.Find(x => x.Nome == nome)
            );

            app.MapPost("/produtos", (Produto produto) =>
                Produtos.Add(produto)
            );
        }
    }
}
