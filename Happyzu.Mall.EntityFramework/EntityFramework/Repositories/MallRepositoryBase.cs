using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Happyzu.Mall.EntityFramework.Repositories
{
    public abstract class MallRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MallDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MallRepositoryBase(IDbContextProvider<MallDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MallRepositoryBase<TEntity> : MallRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MallRepositoryBase(IDbContextProvider<MallDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
