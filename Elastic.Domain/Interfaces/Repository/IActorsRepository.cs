using Elastic.Infrastructure.Elastic;
using Elastic.Infrastructure.Indexes;

namespace Elastic.Domain.Interfaces.Repository
{
    public interface IActorsRepository : IElasticBaseRepository<IndexActors>
    {
    }
}
