using System;
using System.Collections.Generic;
using System.Linq;

using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;

using HackerF.Interface;
using HackerF.Model;

public class CoreInstaller
{
    public static WindsorContainer _container;

    public void Initialise() 
    {
        if (_container != null)
            return;

        _container = new WindsorContainer();
        _container.Kernel.Resolver.AddSubResolver(new ListResolver(_container.Kernel));

        _container.Register(
            Component.For<IMenuItem>().ImplementedBy<Hotkey>()
        );

        _container.Register(
            Component.For<IMenu>().ImplementedBy<CheatingSheet>()
        );

        var cheatSheet = _container.Resolve<IMenu>();
        cheatSheet.Show();
    }
}

