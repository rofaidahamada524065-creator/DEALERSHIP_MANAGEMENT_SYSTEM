using DEALERSHIP_MANAGEMENT_SYSTEM.Models;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Interface
{
    public interface IVehicleCustom:IGenaricRepo<Vehicle>
    {
        ICollection<Vehicle> GetAllVehicles();
    }
}
