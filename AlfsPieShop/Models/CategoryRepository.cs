using AlfPieShop.Models;

namespace AlfPieShop.Models
{
    public class CategoryRepository(AlfPieShopDBContext alfPieShopDBContext) : ICategoryRepository
    {
        private readonly AlfPieShopDBContext _alfPieShopDBContext = alfPieShopDBContext;

        public IEnumerable<Category> AllCategories => _alfPieShopDBContext.Categories.OrderBy(c => c.CategoryName);
    }
}
