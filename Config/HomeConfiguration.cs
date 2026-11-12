/****************/
// 202418988
// Nguyễn Văn Thế
/****************/
namespace Assignment10_MI4090.Config;

public sealed class HomeConfiguration
{
    private static readonly Lazy<HomeConfiguration> lazy = new(() => new HomeConfiguration());
    public static HomeConfiguration Instance => lazy.Value;
    public string HomeName { get; set; } = "Elon Musk Home";
    public int NightLightLevel { get; set; } = 30;

    private HomeConfiguration()
    { }
}
