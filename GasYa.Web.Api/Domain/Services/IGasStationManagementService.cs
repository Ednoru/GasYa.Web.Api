using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Services;

public interface IGasStationManagementService
{
    Task<GasStationAggregate> GetGasStationAsync(int id);
}