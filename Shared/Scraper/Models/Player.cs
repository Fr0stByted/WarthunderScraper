using System.Runtime.InteropServices.ComTypes;

namespace Shared.Scraper.Models;

public class Player
{
    public uint Id { get; set; }
    public string Username { get; set; }
    public string Clan { get; set; }
    public string Tag { get; set; }
    public uint Level { get; set; }
    public DateTime Registration_Date { get; set; }
    
    public List<Level_Track> Level_Track { get; set; }
    
    public List<AB_Stats> AB_Stats { get; set; }
    public List<AB_Aviation> AB_Aviations { get; set; }
    public List<AB_Ground> AB_Ground { get; set; }
    public List<AB_Fleet> AB_Fleet { get; set; }
    
    public List<AB_Stats> RB_Stats { get; set; }
    public List<AB_Aviation> RB_Aviations { get; set; }
    public List<AB_Ground> RB_Ground { get; set; }
    public List<AB_Fleet> RB_Fleet { get; set; }
    
    public List<AB_Stats> SB_Stats { get; set; }
    public List<AB_Aviation> SB_Aviations { get; set; }
    public List<AB_Ground> SB_Ground { get; set; }
    public List<AB_Fleet> SB_Fleet { get; set; }
}