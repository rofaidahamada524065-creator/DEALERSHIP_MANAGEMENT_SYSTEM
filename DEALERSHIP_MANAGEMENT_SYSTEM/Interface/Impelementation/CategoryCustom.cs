using DEALERSHIP_MANAGEMENT_SYSTEM.Data;
using DEALERSHIP_MANAGEMENT_SYSTEM.Models;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Interface.Impelementation
{
    public class CategoryCustom : GenaricRepo<Category>, ICatigoryCustom
    {
        private readonly AppDbContext _appDbContext;
        public CategoryCustom(AppDbContext _context) : base(_context)
        {
            _appDbContext = _context;
        }

        public int count()
        {
           var x= _appDbContext.Categories.GroupBy(c => c.CategoryId).Count();
            return x;
        }
    }
}
