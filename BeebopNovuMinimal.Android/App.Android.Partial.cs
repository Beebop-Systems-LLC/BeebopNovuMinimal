using Microsoft.Extensions.DependencyInjection;
using BeebopNovuMinimal.Domain.Interfaces;
using BeebopNovuMinimal.Android.Infrastructure.Services;

namespace BeebopNovuMinimal;

public partial class App
{
    protected override void ConfigurePlatformSpecificServices(IServiceCollection services)
    {
        services.AddSingleton<IPlatformFileService, AndroidFileService>();
    }

    protected override void InitializePlatformSpecific()
    {
        // Android-specific initialization
    }
}
