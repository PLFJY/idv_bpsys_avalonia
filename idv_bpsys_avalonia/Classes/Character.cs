using Avalonia.Media.Imaging;

namespace idv_bpsys_avalonia.Classes;

public class Character
{
    public Types Type { get; set; }
    
    public string Name { get; set; }

    public Bitmap HeaderImage { get; set; }
    
    public Bitmap HeaderBanImage { get; set; }
    
    public Bitmap HalfImage { get; set;}
    
    public Bitmap FullImage { get; set; }
    
}