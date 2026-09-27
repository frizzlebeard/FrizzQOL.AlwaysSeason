#nullable disable
public static class SeasonRules
{
    public static bool ShouldBeCraftable(bool normallyEnabled, bool inSeasonGroup)
    {
        return normallyEnabled || inSeasonGroup;
    }
}
