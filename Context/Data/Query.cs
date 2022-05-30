using GraphQLSample.Model;
namespace GraphQLSample.Context.Data
{
    public class Query
    {
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Project> GetProjects([Service] ApplicationDbContext context) =>
            context.Projects;
    }
}
