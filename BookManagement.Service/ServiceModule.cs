using Autofac;
using BookManagement.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Service
{
    /// <summary>
    /// 服务注册模块
    /// </summary>
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(this.ThisAssembly)
                .Where(t => t.IsAssignableTo<IService>())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
