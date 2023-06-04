using Microsoft.Extensions.Hosting;
using Shared.Scraper.Models;

namespace Mediator;

public interface IMediator :  IHostedService
{
    public void GetPlayerRecords(string username);
    public void StorePlayerRecords(Player player);
    protected void OnPlayerDataReceived(Player player);
}