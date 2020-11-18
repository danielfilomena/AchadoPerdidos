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
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<TipoContato> TipoContato { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemFoto> ItemFoto { get; set; }

    }
}
