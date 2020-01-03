using System;
using System.Collections.Generic;
using System.Linq;

using Castle.MicroKernel.Registration;
using Castle.Windsor;

using HackerF.Interface;
using HackerF.Model;
using HackerF.Service;

public class CoreInstaller
{
    public static WindsorContainer _container;

    public void Initialise() 
    {
        if (_container != null)
            return;

        _container = new WindsorContainer();

        _container.Register(
            Component.For<IHotkeyMenu>().ImplementedBy<CheatingSheet>(),
            Component.For<ICommandReader>().ImplementedBy<CommandReader>(),
            Component.For<IDelayPrintService>().ImplementedBy<DelayPrintService>()
        );
    }
}