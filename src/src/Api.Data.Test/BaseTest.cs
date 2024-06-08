using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Data.Test
{
    public abstract class BaseTest
    {
        public BaseTest()
        {

        }
    }

    public class DbTest : IDisposable
    {

        private string dataBaseName = $"dbApiTest_{Guid.NewGuid().ToString().Replace("-", string.Empty)}";
        public ServiceProvider ServiceProvider { get; private set; }

        public DbTest()
        {
            //var serviceCollection = new ServiceCollection();
            //serviceCollection.AddDbContext<MyContext>(o =>
            //    o.UseMySql($"Persist Security Info=True;Server=localhost;Database={dataBaseName};User=root;Password=12345678", new MySqlServerVersion(new Version(8, 0, 36))),
            //      ServiceLifetime.Transient
            //);

            //ServiceProvider = serviceCollection.BuildServiceProvider();
            //using (var context = ServiceProvider.GetService<MyContext>())
            //{
            //    context.Database.EnsureCreated();
            //}
        }

        public void Dispose()
        {
            using (var context = ServiceProvider.GetService<MyContext>())
            {
                context.Database.EnsureDeleted();
            }
        }
    }
}