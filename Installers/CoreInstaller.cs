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
            Component.For<IHotkeyFunctionService>().ImplementedBy<HotkeyFunctionService>(),
            Component.For<ICommandReader>().ImplementedBy<CommandReader>(),
            Component.For<IDelayPrintService>().ImplementedBy<DelayPrintService>(),
            Component.For<IAsciiImageService>().ImplementedBy<AsciiImageService>(),
            Component.For<IFileReader>().ImplementedBy<FileReader>()
        );
    }
}