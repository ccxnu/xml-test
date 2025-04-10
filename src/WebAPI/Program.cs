using Application;
namespace WebAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Register MediatR
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

        // Add controllers with XML support
        builder.Services.AddControllers().AddXmlSerializerFormatters();

        builder.Services.AddApplication();

        var app = builder.Build();

        app.MapControllers();
        app.Run();
    }
}
