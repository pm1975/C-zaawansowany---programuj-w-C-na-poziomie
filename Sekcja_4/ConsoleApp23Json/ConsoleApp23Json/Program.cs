using System;
using Newtonsoft.Json;

namespace ConsoleApp23Json
{
    class Program
    {
        static void Main(string[] args)
        {
            var someObject = new JSONExample
            {
                Username = "Some Username",
                SomeStrings = new System.Collections.Generic.List<string>
                {
                    "a", "s"
                },
                Value = 5
            };

            var json = JsonConvert.SerializeObject(someObject);

            Console.WriteLine(json);

            var someOtherObject = JsonConvert.DeserializeObject<JSONExample>(json);
        }

        public void SomeApiFunciton(JSONExample dfasdf)
        {

        }
    }

}
