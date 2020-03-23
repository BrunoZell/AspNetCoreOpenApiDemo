namespace NSwagTest.Client
{
    public class Class1
    {
        void Main()
        {
            var client = new Rabot.Swagger.NSwagTest_Server_NSwagTestApiClient("http://localhost:5000", new System.Net.Http.HttpClient());
        }
    }
}
