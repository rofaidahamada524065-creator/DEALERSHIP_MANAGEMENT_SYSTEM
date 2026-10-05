using DEALERSHIP_MANAGEMENT_SYSTEM.Interface;

namespace DEALERSHIP_MANAGEMENT_SYSTEM.Unit_Of_Workk
{
    public interface IUnitOfWork
    {
       IVehicleCustom vehicleCustom { get; }
        ICatigoryCustom catigory { get; }
        int save();
    }
}
