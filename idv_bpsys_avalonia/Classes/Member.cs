using Avalonia.Media.Imaging;

namespace idv_bpsys_avalonia.Classes;

public class Member
{
    public Types Type { get; set; }

    public string Name { get; set; }

    public string NameInGame { get; set; }

    public Bitmap Image { get; set; }

    public bool IsPlaying { get; set; } = false;
    
    public Member()
    {
        
    }

    public Member(Types type, string name, bool isPlaying)
    {
        Type = type;
        Name = name;
        IsPlaying = isPlaying;
    }
    
    public Member(Types type, string name, string nameInGame, bool isPlaying)
    {
        Type = type;
        Name = name;
        NameInGame = nameInGame;
        IsPlaying = isPlaying;
    }
    
    public Member(Types type, string name, string nameInGame, Bitmap image, bool isPlaying)
    {
        Type = type;
        Name = name;
        NameInGame = nameInGame;
        Image = image;
        IsPlaying = isPlaying;
    }
}