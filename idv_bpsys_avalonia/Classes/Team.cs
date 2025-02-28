using System;
using System.Collections.Generic;
using Avalonia.Media.Imaging;

namespace idv_bpsys_avalonia.Classes;

public class Team
{
    public string Name { get; set; } 

    public Bitmap Logo { get; set; }

    public List<Member> MemberList { get; set; } = new List<Member>();
    
    public List<Character> SurGlobalBanList { get; set;} = new List<Character>();
    
    public List<Character> HunGlobalBanList { get; set;} = new List<Character>();
    
    public Score Score { get; set; } = new Score();
}