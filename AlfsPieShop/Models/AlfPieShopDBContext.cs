using Microsoft.EntityFrameworkCore;

namespace AlfPieShop.Models
{
    public class AlfPieShopDBContext(DbContextOptions options) : DbContext(options)
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Pie> Pies { get; set; }
    }
}
