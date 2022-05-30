using GraphQLSample.Context.Data;
using GraphQLSample.Repository.Interfaces;

namespace GraphQLSample.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public ProjectRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
