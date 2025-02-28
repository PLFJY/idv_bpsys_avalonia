using idv_bpsys_avalonia.Classes;

namespace idv_bpsys_avalonia;

public static class StaticData
{
    public static Team MainTeam { get; set; } = new();

    public static Team AwayTeam { get; set; } = new();

    public static Team CurrentSurTeam { get; set; } = MainTeam;

    public static Team CurrentHunTeam { get; set; } = AwayTeam;
    
    public static Game CurrentGame { get; set; } = new();

    public static GameProgresses GameProgress { get; set; } = GameProgresses.Game1FirstHalf;

}