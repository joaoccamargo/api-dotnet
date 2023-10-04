namespace api_dotnet.Models
{
    public class Produto
    {
        public int Id { get;}
        public string Nome { get; set; }

        public Produto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }


    }
}
