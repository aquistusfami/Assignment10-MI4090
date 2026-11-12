/****************/
// 202418988
// Nguyễn Văn Thế
/****************/
namespace Assignment10_MI4090.Devices;

public class SmartLight : IDevice
{
    private readonly string name;
    public bool IsOn { get; private set; }

    public SmartLight(string name)
    {
        this.name = name;
    }
    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{name}: OFF");
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{name}: ON");
    }
}
