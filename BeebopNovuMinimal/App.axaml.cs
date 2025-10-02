using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BeebopNovuMinimal;

public partial class App : Application
{
    private IServiceProvider? _serviceProvider;

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var services = new ServiceCollection();

        // Call into platform-specific registration hook
        ConfigurePlatformSpecificServices(services);

        _serviceProvider = services.BuildServiceProvider();

        base.OnFrameworkInitializationCompleted();
        InitializePlatformSpecific();
    }

    // 👇 These MUST exist in the base project
    protected virtual void ConfigurePlatformSpecificServices(IServiceCollection services) { }
    protected virtual void InitializePlatformSpecific() { }
}
