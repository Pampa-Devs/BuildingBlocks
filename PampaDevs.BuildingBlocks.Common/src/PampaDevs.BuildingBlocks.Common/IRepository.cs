namespace PampaDevs.BuildingBlocks.Common;
public interface IRepository<T> : IAggregateRoot
{
    IUnitOfWork UnitOfWork { get; }
}