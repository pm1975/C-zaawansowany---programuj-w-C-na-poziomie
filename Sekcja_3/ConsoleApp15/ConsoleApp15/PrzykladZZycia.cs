using System;
using System.Collections.Generic;

namespace ConsoleApp15
{
    public class PrzykladZZycia
    {
        static void Main(string[] args)
        {
            var response = new ApiResponse<DateTime>();
            var response2 = new ApiResponse<string>();
            var response3 = new ApiResponse<bool>();

            Dictionary<int, string> dictionary = new Dictionary<int, string>();


            // ...
            if (response.Succeeded)
            {
                var data = response.Response;
            }
            else
            {
                var error = response.ErrorMessage;
                Console.WriteLine(error);
            }
        }
    }

    public class ApiResponse
    {
        public DateTime DateOfBirth { get; set; }
        public string ErrorMessage { get; set; }
        public bool Succeeded { get; set; }
    }
    public class ApiResponse2
    {
        public string UserName { get; set; }
        public string ErrorMessage { get; set; }
        public bool Succeeded { get; set; }
    }

    public class ApiResponse<T>
    {
        public T Response { get; set; }
        public string ErrorMessage { get; set; }
        public bool Succeeded { get; set; }
    }
}
