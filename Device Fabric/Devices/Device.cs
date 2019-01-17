using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device_Fabric.Devices
{
    /// <summary>
    /// В этом классе таскать контекст устройства.
    /// </summary>
    public class Device
    {
        private readonly DeviceTypeObject _deviceTypeObject;

        public Device(DeviceTypeObject deviceTypeObject)
        {
            _deviceTypeObject = deviceTypeObject;
        }

        public int GetDeviceId()
        {
            return _deviceTypeObject.GetId();
        }
    }
}
