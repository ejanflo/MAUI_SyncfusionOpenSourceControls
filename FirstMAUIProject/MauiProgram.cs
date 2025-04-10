using FirstMAUIProject.ViewModels;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Toolkit.Hosting;

namespace FirstMAUIProject
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
                    fonts.AddFont("Roboto-Semibold.ttf", "RobotoSemibold"); 
                    fonts.AddFont("MauiMaterialAssets.ttf", "MaterialAssets");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            //Views
            builder.Services.AddSingleton<LoginPage>();

            //ViewModels
            builder.Services.AddSingleton<LoginPageViewModel>();

            return builder.Build();
        }
    }
}
