using Henooh.DeviceEmulator;
using Henooh.DeviceEmulator.Native;
using SharpDX.XInput;
using System;
using System.Diagnostics;

namespace xinputTest
{
    public class Wincon
    {
        readonly KeyboardController o = new KeyboardController();
        readonly Controller controller = new Controller(UserIndex.One);
        public bool abuttondown = false;

        public void Gogo(string jsonpath)
        {

            ProcessProfile[] profiles = JSON.Undoit(System.IO.File.ReadAllText(jsonpath));
            while (true)
            {
                LoopCheck(profiles);
            }
        }

        private void LoopCheck(ProcessProfile[] profiles)
        {
            for (int i = 0; i < profiles.Length; i++)
            {
                ProcessProfile p = profiles[i];
                if (p.ProcessName == ProcessService.GetActiveProcess().ProcessName)
                {
                    Go(p, controller.GetState());
                }
            }
        }

        public void Go(ProcessProfile pp, State s)
        {
            foreach (Binds e in pp.binds)
            {
                bool abutton = s.Gamepad.Buttons == e.button;
                FlipFlop(e, abutton);
            }


        }

        private void FlipFlop(Binds e, bool abutton)
        {
            if (abutton != e.isdown)
            {
                if (abutton)
                {
                    o.Down(e.key);
                } else
                {
                    o.Up(e.key);
                }
                e.isdown = abutton;
            }
        }
    }
}