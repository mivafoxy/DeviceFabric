using Device_Fabric.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Device_Fabric.Devices
{

    /// <summary>
    /// Устройства, подключаемые к компьютеру.
    /// </summary>
    public abstract class DeviceTypeObject : TypeObject
    {
        public abstract int GetId();

        public abstract Type GetDeviceType();

        public abstract Device CreateNewDevice();

        public class MouseTypeObject : DeviceTypeObject
        {
            public override Device CreateNewDevice()
            {
                return new Mouse(this);
            }

            public override Type GetDeviceType()
            {
                return typeof(Mouse);
            }

            public override int GetId()
            {
                return (int)DeviceType.MOUSE;
            }
        }

        public class KeyboardTypeObject : DeviceTypeObject
        {
            public override Device CreateNewDevice()
            {
                return new Keyboard(this);
            }

            public override Type GetDeviceType()
            {
                return typeof(Keyboard);
            }

            public override int GetId()
            {
                return (int)DeviceType.KEYBOARD;
            }
        }
    }
}
