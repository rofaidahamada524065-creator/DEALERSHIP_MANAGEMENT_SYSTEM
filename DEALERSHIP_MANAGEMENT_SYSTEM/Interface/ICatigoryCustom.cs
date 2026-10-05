using DEALERSHIP_MANAGEMENT_SYSTEM.Models;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Interface
{
    public interface ICatigoryCustom:IGenaricRepo<Category>
    {
        int count();
    }
}
