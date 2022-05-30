using GraphQLSample.Context.SuperHeroApi.Data.ContextConfigurations;
using GraphQLSample.Model;
using Microsoft.EntityFrameworkCore;

namespace GraphQLSample.Context.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        
        // Add the DbSets for each of our models we would like at our database
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Generate three GUIDS and place them in an arrays
            var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
            builder.Entity<Project>().ToTable("Project");
            // Apply configuration for the three contexts in our application
            // This will create the demo data for our GraphQL endpoint.
            builder.ApplyConfiguration(new ProjectContextConfiguration(ids));
        }
    }
}
