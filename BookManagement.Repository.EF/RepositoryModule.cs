using Autofac;
using BookManagement.Infrusture.Contract;
using BookManagement.Infrusture.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Repository.EF
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EFUnitOfWork>()
                .As<IUnitOfWork>()
                .InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(this.ThisAssembly)
                .Where(t => t.IsAssignableTo<IRepository>())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
