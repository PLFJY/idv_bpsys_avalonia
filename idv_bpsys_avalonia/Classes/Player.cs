using System.Collections.Generic;

namespace idv_bpsys_avalonia.Classes;

public class Player : Member
{
    public Character Character {set; get;}

    public int position { get; set; }
    
    public List<Talent> Talent { get; set; }
    
    public Trait Trait { get; set; }

    public PlayerData Data { get; set; }
}