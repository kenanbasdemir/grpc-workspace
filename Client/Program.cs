using Client.Protos;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ChatEndpoint.ChatEndpointClient(channel);
            var reply = client.SendText(
                              new TextRequest { TextData = "Send someone text!" });
            Console.WriteLine("Server: " + reply.Result);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
