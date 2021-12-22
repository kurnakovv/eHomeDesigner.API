using Autofac;
using Autofac.Extensions.DependencyInjection;
using eHomeDesigner.Application.Interfaces.Converters;
using eHomeDesigner.Converters.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHomeDesigner.DI.Autofac.Setup;

public static class ContainerSetuper
{
    // TODO: Add logic for asp net core 6.
    public static AutofacServiceProvider Setup()
    {
        var containerBuilder = new ContainerBuilder();
        containerBuilder.RegisterType<Converter>().As<IConverter>();

        IContainer container = containerBuilder.Build();
        var serviceProvider = new AutofacServiceProvider(container);

        return serviceProvider;
    }
}
