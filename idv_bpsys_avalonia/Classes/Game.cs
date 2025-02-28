using System.Collections.Generic;

namespace idv_bpsys_avalonia.Classes;

public class Game
{
    public Team SurTeam { get; set;}
    
    public Team HunTeam { get; set;}

    public List<Player> SurPlayerList { get; set; }
    
    public Player HunPlayer { get; set; }
}