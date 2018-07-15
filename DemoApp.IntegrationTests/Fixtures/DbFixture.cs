using System.Data.Entity;
using DemoApp.DAL;
using DemoApp.DbLocator;

namespace DemoApp.IntegrationTests.Fixtures
{
    public class DbFixture
    {
        public DbFixture()
        {
            LocateDevDb.SetDataDirectory();
            Database.SetInitializer(new DropCreateDatabaseAlways<DemoAppDbContext>());
            DB = new DemoAppDbContext();
            DB.Database.Initialize(true);
        }

        public DemoAppDbContext DB { get; set; }
    }
}