/****************/
// 202418988
// Nguyễn Văn Thế
/****************/
using Assignment10_MI4090.Config;
using Assignment10_MI4090.Devices;

namespace Assignment10_MI4090.Facade;

public sealed class SmartHomeFacade
{
    private readonly IDevice light;
    private readonly IDevice fan;
    private readonly ILockable door;

    public SmartHomeFacade(IDevice light, IDevice fan, ILockable door)
    {
        this.light = light;
        this.fan = fan;
        this.door = door;
    }

    public void GoToWork()
    {
        light.TurnOff();
        fan.TurnOff();
        door.Lock();
    }

    public void GoToSleep()
    {
        fan.TurnOff();
        door.Lock();
        light.TurnOn();

        int level = HomeConfiguration.Instance.NightLightLevel;
        Console.WriteLine($"Night light level: {level}%");
    }
}
