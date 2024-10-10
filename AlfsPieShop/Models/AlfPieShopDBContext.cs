using Microsoft.EntityFrameworkCore;

namespace AlfPieShop.Models
{
    public class AlfPieShopDBContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; } //#50
        public DbSet<Pie> Pies { get; set; } //#50
    }
}
