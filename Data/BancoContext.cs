using Microsoft.EntityFrameworkCore;
using SiteEmMVC.Models;

namespace SiteEmMVC.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<ContatoModel> Contatos {  get; set; }
    }
}
