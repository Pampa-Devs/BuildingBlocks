namespace PampaDevs.BuildingBlocks.Common;
public interface IQueryRepository<T> where T : Entity
{
    IQueryable<T> FromSqlRaw(string sql, params object[] parameters);
    IQueryable<T> Queryable();
}
