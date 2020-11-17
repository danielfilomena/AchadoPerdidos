using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{

    public class LostFoundContext : DbContext
    {

        public LostFoundContext(DbContextOptions<LostFoundContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }

    }
}
