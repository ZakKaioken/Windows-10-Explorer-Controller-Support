namespace xinputTest
{
    public class ProcessProfile
    {
        public string ProcessName;
        public Binds[] binds;

        public ProcessProfile(string processName, Binds[] binds)
        {
            ProcessName = processName;
            this.binds = binds;
        }
    }
}
