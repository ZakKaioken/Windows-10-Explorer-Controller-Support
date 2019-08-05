using Henooh.DeviceEmulator.Native;
using SharpDX.XInput;

namespace xinputTest
{
    public class Binds
    {
        public string name;
        public GamepadButtonFlags button;
        public VirtualKeyCode key;
        public bool isdown = false;

        public Binds(string name, GamepadButtonFlags button, VirtualKeyCode key)
        {
            this.name = name;
            this.button = button;
            this.key = key;
        }
    }
}
