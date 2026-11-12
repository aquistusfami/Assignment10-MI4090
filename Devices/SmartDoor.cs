/****************/
// 202418988
// Nguyễn Văn Thế
/****************/
namespace Assignment10_MI4090.Devices;

public class SmartDoor : IDevice, ILockable
{
    private readonly string name;
    public bool IsOn { get; private set; }
    public bool IsLocked { get; private set; }

    public SmartDoor(string name)
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

    public void Lock()
    {
        IsLocked = true;
        Console.WriteLine($"{name}: LOCKED");
    }

    public void Unlock()
    {
        IsLocked = false;
        Console.WriteLine($"{name}: UNLOCKED");
    }
}
