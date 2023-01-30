using Microsoft.EntityFrameworkCore;
using OperaWebSite.Models;

namespace OperaWebSite.Data
{
    public class OperaDBContext : DbContext
    {

        public OperaDBContext(DbContextOptions<OperaDBContext> options) : base(options) { }

        public DbSet<Opera> Operas { get; set; }
    }

}
