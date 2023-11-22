using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Services;

public interface IFuelManagementService
{
    Task<FuelAggregate> AddFuelAsync(string type, string description, double price);
}