using System.Data.Entity.Migrations;

namespace Happyzu.Mall.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Mall.EntityFramework.MallDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Mall";
        }

        protected override void Seed(Mall.EntityFramework.MallDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
