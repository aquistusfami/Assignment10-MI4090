/****************/
// 202418988
// Nguyễn Văn Thế
/****************/
namespace Assignment10_MI4090;

using Assignment10_MI4090.Devices;
using Assignment10_MI4090.Factory;
using Assignment10_MI4090.Config;
using Assignment10_MI4090.Facade;
class Program
{
    static void Main(string[] args)
    {
        // t1
        try
        {
            // client tạo đèn, quạt, cửa
            IDevice den = DeviceFactory.Create(" Light", "Den phong khach");
            IDevice quat = DeviceFactory.Create("Fan", "Quat phong khach");
            IDevice cua = DeviceFactory.Create("Door ", "Cua chinh");

            // check có đúng là kiểu đối tượng không
            if (den is SmartLight)
            {
                Console.WriteLine($"[1]: SmartLight OK");
            }

            if (quat is SmartFan)
            {
                Console.WriteLine($"[1]: SmartFan OK");
            }

            if (cua is SmartDoor)
            {
                Console.WriteLine($"[1]: SmartDoor OK");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex}");
        }
        // t2
        try
        {
            IDevice camera = DeviceFactory.Create("camera", "Camera viettel");
            Console.WriteLine("[2]: Fail, không ném ArgumentException.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"[2]: {ex}");
        }
        // t3
        try
        {
            var c1 = HomeConfiguration.Instance;
            var c2 = HomeConfiguration.Instance;

            if (!ReferenceEquals(c1, c2))
            {
                throw new Exception("[3] Singleton implementation is incorrect!");
            }

            Console.WriteLine("[3]: Singleton hoạt động đúng");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex}");
        }

        // t4, t5
        try
        {
            IDevice den = DeviceFactory.Create("light", "Den phong khach");
            IDevice quat = DeviceFactory.Create("fan", "Quat phong khach");
            IDevice cua = DeviceFactory.Create("door", "Cua chinh");

            var facade = new SmartHomeFacade(den, quat, (SmartDoor)cua);

            Console.WriteLine("[4]: Test facade khi đi làm");
            facade.GoToWork();
            Console.WriteLine("[5]: Test facade khi đi ngủ");
            facade.GoToSleep();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex}");
        }
    }
}
