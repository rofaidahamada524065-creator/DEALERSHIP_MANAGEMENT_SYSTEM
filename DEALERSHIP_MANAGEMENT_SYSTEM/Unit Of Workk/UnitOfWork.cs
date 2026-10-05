using DEALERSHIP_MANAGEMENT_SYSTEM.Data;
using DEALERSHIP_MANAGEMENT_SYSTEM.Interface;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Unit_Of_Workk
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public UnitOfWork(AppDbContext context,IVehicleCustom vehicleCustom,ICatigoryCustom catigoryCustom)
        { 
            _appDbContext = context;
            this.vehicleCustom = vehicleCustom;
            this.catigory = catigoryCustom;
        }
        public IVehicleCustom vehicleCustom {  get; }

        public ICatigoryCustom catigory { get; }

        public int save()
        {
           return _appDbContext.SaveChanges();
        }
    }
}
