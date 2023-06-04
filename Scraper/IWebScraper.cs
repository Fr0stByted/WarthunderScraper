using Shared.Scraper.Models;

namespace Scraper;

public interface IWebScraper
{
    public Player GetPlayerRecords(string username);
}