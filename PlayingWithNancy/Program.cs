using System;
using Nancy;

namespace PlayingWithNancy
{
    public class Program
    {
        static void Main(string[] args) {
            Console.Write("Starting server...");
            var server = new Nancy.Hosting.Self.NancyHost(new Uri("http://localhost:8282"));
            server.Start();
            Console.Read();
        }
    }
}
