using GasYa.Web.Api.Domain.Aggregates;

namespace GasYa.Web.Api.Domain.Services;

public interface IPromotionManagementService
{
    Task<PromotionAggregate> GetPromotionAsync(int id);
}