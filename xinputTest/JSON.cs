using Newtonsoft.Json;

namespace xinputTest
{
    public static class JSON
    {
        public static string Doit(object v)
        {
            return JsonConvert.SerializeObject(v);
        }

        public static ProcessProfile[] Undoit(string data)
        {
            return JsonConvert.DeserializeObject<ProcessProfile[]>(data);
        }

    }
}
