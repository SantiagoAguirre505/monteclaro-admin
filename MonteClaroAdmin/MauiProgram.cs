using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace MonteClaroAdmin;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<MonteClaroAdmin.Services.IMockDataService, MonteClaroAdmin.Services.MockDataService>();
        builder.Services.AddTransient<MonteClaroAdmin.ViewModels.DashboardViewModel>();

        return builder.Build();
    }
}
