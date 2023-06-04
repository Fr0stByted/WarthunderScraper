using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scraper;
using Shared.AppSettings;

namespace Base;

public class Startup
{
    private readonly IHostBuilder _builder;
    public Startup()
    {
        _builder = Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration(ConfigureAppConfiguration)
            .ConfigureServices(ConfigureServices);
    }

    private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.Configure<AppSettings>(context.Configuration.GetSection(nameof(AppSettings)));
        services.AddTransient<WebScraper>();
        services.AddTransient<WarthunderParser>();
        services.AddHostedService<Mediator.Mediator>();

    }

    private void ConfigureAppConfiguration(HostBuilderContext context, IConfigurationBuilder builder)
    {
        builder.AddJsonFile("appsettings.json", false, true);
    } 

    public Task RunAsync()
    {
        var host = _builder.UseConsoleLifetime().Build();
        return host.RunAsync();
    }
}