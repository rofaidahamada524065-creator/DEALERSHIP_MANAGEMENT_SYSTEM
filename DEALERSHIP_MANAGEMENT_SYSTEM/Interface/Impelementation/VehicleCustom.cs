using DEALERSHIP_MANAGEMENT_SYSTEM.Data;
using DEALERSHIP_MANAGEMENT_SYSTEM.Models;
using Microsoft.EntityFrameworkCore;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Interface.Impelementation
{
    public class VehicleCustom : GenaricRepo<Vehicle>, IVehicleCustom
    {
        private readonly AppDbContext _context;
        public VehicleCustom(AppDbContext context) : base(context)
        {
            _context=context;
        }

        public ICollection<Vehicle> GetAllVehicles()
        {
          var dat=DateTime.Now;

            var x = _context.Vehicles.OrderBy(a => a.Price).ThenBy(a => a.Year).
                Where(a => a.Status == "Available")
               .ToList();
            return x;
        }
    }
}
