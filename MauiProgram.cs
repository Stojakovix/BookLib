using BookLib.Data;
using Microsoft.Extensions.Logging;

namespace BookLib
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
                });
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "books.db");
           // string dbPath = Path.Combine(Environment.GetFolderPath(Environment.Pers), "books.db");
            builder.Services.AddSingleton(s => ActivatorUtilities.CreateInstance<Conn>(s, dbPath));


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
