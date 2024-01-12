using EasyMicroservices.Cores.AspEntityFrameworkCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.WhiteLabelsMicroservice.Database.Contexts;

namespace EasyMicroservices.WhiteLabelsMicroservice.WebApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var app = CreateBuilder(args);
            var build = await app.BuildWithUseCors<WhiteLabelContext>(default, true);
            build.MapControllers();
            Init(build.Services);
            await build.RunAsync();
        }

        static WebApplicationBuilder CreateBuilder(string[] args)
        {
            var app = StartUpExtensions.Create<WhiteLabelContext>(args);
            app.Services.Builder<WhiteLabelContext>("WhiteLabel").UseDefaultSwaggerOptions();
            app.Services.AddTransient(serviceProvider => new WhiteLabelContext(serviceProvider.GetService<IEntityFrameworkCoreDatabaseBuilder>()));
            app.Services.AddTransient<IEntityFrameworkCoreDatabaseBuilder, DatabaseBuilder>();
            return app;
        }

        public static async Task Run(string[] args, Action<IServiceCollection> use, Action<IServiceProvider> serviceProvider)
        {
            var app = CreateBuilder(args);
            use?.Invoke(app.Services);
            var build = await app.Build<WhiteLabelContext>(true);
            build.MapControllers();
            serviceProvider(build.Services);
            Init(build.Services);
            await build.RunAsync();
        }

        static void Init(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                using var uow = scope.ServiceProvider.GetRequiredService<IUnitOfWork>() as UnitOfWork;
                uow.Initialize("WhiteLabel");
            }
        }
    }
}