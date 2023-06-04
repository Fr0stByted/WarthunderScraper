using Scraper;
using Shared.Scraper.Models;

namespace Mediator;

public class Mediator : IMediator
{
    private readonly IWebScraper _webScraper;
    
    public Mediator(WebScraper webScraper)
    {
        _webScraper = webScraper;
    }

    public void GetPlayerRecords(string username)
    {
        _webScraper.GetPlayerRecords(username);
    }

    public void StorePlayerRecords(Player player)
    {
        
    }

    public void OnPlayerDataReceived(Player player)
    {
        
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        GetPlayerRecords("Monodrail97");
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}