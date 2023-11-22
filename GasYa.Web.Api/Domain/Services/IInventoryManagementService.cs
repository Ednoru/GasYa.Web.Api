namespace GasYa.Web.Api.Domain.Services;

public interface IInventoryManagementService
{
    Task<int> GetFuelQuantityInStockAsync(int gasStationId, int fuelId);
}