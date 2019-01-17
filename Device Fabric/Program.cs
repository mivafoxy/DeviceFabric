using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Device_Fabric.Devices;
using Device_Fabric.Utils;

namespace Device_Fabric
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пришёл идентификатор устройства, по которому нужно создать класс, с которым надо работать.
            var requiredDevice = DeviceType.MOUSE;

            Device device = CreateRequiredDevice(requiredDevice);

            Console.WriteLine(device.GetDeviceId());

            Console.WriteLine("This works!");
        }

        static Device CreateRequiredDevice(DeviceType deviceType)
        {
            // Как привести TypeObject[] к DeviceTypeObject[] ?
            TypeObject[] deviceTypeObjects = TypeObject.GetDerrivedElements(typeof(DeviceTypeObject));

            foreach (TypeObject element in deviceTypeObjects)
            {
                DeviceTypeObject deviceTypeObject = (DeviceTypeObject)element;

                if (deviceTypeObject.GetId() == (int)deviceType)
                    return deviceTypeObject.CreateNewDevice();
            }

            throw new Exception("В системе не существует подобного устройства.");
        }
    }
}
