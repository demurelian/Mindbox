public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddMvcCore();
        builder.Services.AddRouting();
        builder.Services.AddControllers().AddNewtonsoftJson();

        var app = builder.Build();

        app.UseStaticFiles();

        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());

        app.Run();
    }
}