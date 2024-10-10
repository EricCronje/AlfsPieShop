using AlfPieShop.Models;
using Microsoft.EntityFrameworkCore;

namespace AlfPieShop.Models
{
    public class PieRepository(AlfPieShopDBContext alfPieShopDBContext) : IPieRepository
    {
        private readonly AlfPieShopDBContext _alfPieShopDBContext = alfPieShopDBContext;

        public IEnumerable<Pie> AllPies => _alfPieShopDBContext.Pies.Include(c => c.Category);

        public IEnumerable<Pie> PiesOfTheWeek => _alfPieShopDBContext.Pies.Include(c => c.Category).Where( p => p.IsPieOfTheWeek);

        public Pie? GetPieById(int pieId) => _alfPieShopDBContext.Pies.FirstOrDefault(p => p.PieId == pieId);
    }
}
