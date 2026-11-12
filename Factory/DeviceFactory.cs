/****************/
// 202418988
// Nguyễn Văn Thế
/****************/
using Assignment10_MI4090.Devices;

namespace Assignment10_MI4090.Factory;

public class DeviceFactory
{
    public static IDevice Create(string type, string name)
    {
        return type.Trim().ToLowerInvariant() switch
        {
            "light" => new SmartLight(name),
            "fan" => new SmartFan(name),
            "door" => new SmartDoor(name),
            _ => throw new ArgumentException($"Unsupported device type: {type}")
        };
    }
}
