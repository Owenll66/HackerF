using System;
using System.Collections.Generic;
using System.Linq;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using HackerF.Model;

/*singleton pattern*/
public sealed class CoreInstaller
{
    private static CoreInstaller _coreInstaller = null;
    private static WindsorContainer _container;

    public static CoreInstaller getInstance() 
    {
        if (_coreInstaller == null)
            return new CoreInstaller();
        else
            return _coreInstaller;
    }

    public IMenu Initialise() 
    {
        if (_container != null)
            return null;

        _container = new WindsorContainer();

        _container.Register(
            Component.For<IMenu>().ImplementedBy<Menu>()
        
        );

        var menu = _container.Resolve<IMenu>();

        return menu;
    }
}

