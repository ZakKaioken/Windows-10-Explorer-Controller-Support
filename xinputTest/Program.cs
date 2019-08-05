namespace xinputTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Wincon wincon = new Wincon();
            string jsonpath = args.Length > 0 ? args[0] : "processes.json";
            wincon.Gogo(jsonpath);
        }
    }
}
