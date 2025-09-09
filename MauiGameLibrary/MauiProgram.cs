using CommunityToolkit.Maui;
using MauiGameLibrary.Services;
using MauiGameLibrary.ViewModels;
using MauiGameLibrary.Views;
using Microsoft.Extensions.Logging;

namespace MauiGameLibrary
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<ListOfGamesView>();
            builder.Services.AddTransient<ListOfGamesViewModel>();

            builder.Services.AddTransient<UpdateGameView>();
            builder.Services.AddTransient<UpdateGameViewModel>();


            builder.Services.AddSingleton<GameDataService>();

            return builder.Build();
        }
    }
}
