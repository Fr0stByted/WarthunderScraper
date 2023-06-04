using HtmlAgilityPack;
using Shared.Scraper.Models;

namespace Scraper;

public class WebScraper : IWebScraper
{
    private readonly WarthunderParser _wtParser;

    public WebScraper(WarthunderParser wtParser)
    {
        _wtParser = wtParser;
    }

    public Player GetPlayerRecords(string username)
    {
        var web = new HtmlWeb();
        var doc = web.Load(@"https://warthunder.com/en/community/userinfo/?nick=" + username);
        var headers = doc.DocumentNode.SelectNodes("//span[@class='toctext']");
        throw new NotImplementedException();
    }
}