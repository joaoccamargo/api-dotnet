using api_dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace api_dotnet.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base (options) 
        { 
            
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
