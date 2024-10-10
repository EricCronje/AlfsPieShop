using Microsoft.EntityFrameworkCore;

namespace AlfPieShop.Models
{
    public class AlfPieShopDBContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
    }
}
