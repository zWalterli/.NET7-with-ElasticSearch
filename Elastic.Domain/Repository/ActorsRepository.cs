using Elastic.Domain.Interfaces.Repository;
using Elastic.Infrastructure.Elastic;
using Elastic.Infrastructure.Indexes;
using Nest;

namespace Elastic.Domain.Repository
{
    public class ActorsRepository : ElasticBaseRepository<IndexActors>, IActorsRepository
    {
        public ActorsRepository(IElasticClient elasticClient)
            : base(elasticClient)
        {
        }

        public override string IndexName { get; } = "indexactors";
    }
}
