using Autofac;
using MiddleEarth.Core.Repositories;
using MiddleEarth.Core.Services;
using MiddleEarth.Core.UnitOfWorks;
using MiddleEarth.Repository;
using MiddleEarth.Repository.Repositories;
using MiddleEarth.Repository.UnitOfWorks;
using MiddleEarth.Service.Mapping;
using MiddleEarth.Service.Services;
using System.Reflection;
using Module = Autofac.Module;


namespace MMidleEarthApi.Modules
{
    public class RepoServiceModule:Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            var apiAssembly=Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(
                x=>x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(
                x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();


        }
    }
}
