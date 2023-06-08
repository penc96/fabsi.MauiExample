namespace fabsi.MauiExample.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var t = TimeSpan.ParseExact("", "HH:mm:ss", null);
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}