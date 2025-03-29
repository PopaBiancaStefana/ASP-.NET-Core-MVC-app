using PieShop.Models.Repositories.Interfaces;

namespace PieShop.Models.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PieShopDbContext _pieShopDbContext;

        public CategoryRepository(PieShopDbContext pieShopDbContext)
        {
            _pieShopDbContext = pieShopDbContext;
        }

        public IEnumerable<Category> AllCategories => _pieShopDbContext.Categories.OrderBy(c => c.CategoryName);
    }
}