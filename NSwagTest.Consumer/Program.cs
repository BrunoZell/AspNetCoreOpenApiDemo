using System;

namespace NSwagTest.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client.NSwagTestApiClient("http://localhost:5000", new System.Net.Http.HttpClient());
        }
    }
}
