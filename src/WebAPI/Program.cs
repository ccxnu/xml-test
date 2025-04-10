using Application;

namespace WebAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add controllers with XML support
        builder.Services.AddControllers().AddXmlSerializerFormatters();

        builder.Services.AddApplication();

        var app = builder.Build();

        app.MapControllers();
        app.Run();
    }
}
