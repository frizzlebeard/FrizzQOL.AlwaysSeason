using Xunit;

public class SeasonRulesTests
{
    [Fact]
    public void Seasonal_item_is_craftable_out_of_season()
    {
        Assert.True(SeasonRules.ShouldBeCraftable(normallyEnabled: false, inSeasonGroup: true));
    }

    [Fact]
    public void Normal_item_stays_craftable()
    {
        Assert.True(SeasonRules.ShouldBeCraftable(normallyEnabled: true, inSeasonGroup: false));
    }

    [Fact]
    public void Disabled_item_outside_a_season_stays_disabled()
    {
        Assert.False(SeasonRules.ShouldBeCraftable(normallyEnabled: false, inSeasonGroup: false));
    }
}
