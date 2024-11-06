using Microsoft.Extensions.Logging;

namespace MauiAppHotelFinalizado
{
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
                    fonts.AddFont("Monda-Bold.ttf", "MondaBold");
                    fonts.AddFont("Monda-Medium.ttf", "MondaMedium");
                    fonts.AddFont("Monda-Regular.ttf", "Monda");
                    fonts.AddFont("Monda-VariableFont_wght.ttf", "MondaVariableFont");
                    fonts.AddFont("Monda-SemiBold.ttf", "MondaSemiBold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
