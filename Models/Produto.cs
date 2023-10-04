
namespace api_dotnet.Models
{
    public class Produto
    {

        public int Id { get; private set; }
        public string Nome { get; set; }

        public Produto(int id)
        {
            Id = id;
        }

    }
}
