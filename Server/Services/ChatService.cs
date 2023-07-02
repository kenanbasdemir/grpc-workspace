using Grpc.Core;
using Server.Protos;
using System.Threading.Tasks;

namespace Server.Services
{
    public class ChatService : ChatEndpoint.ChatEndpointBase
    {
        public override Task<TextResponse> SendText(TextRequest request, ServerCallContext context)
        {
            return Task.FromResult(new TextResponse
            {
                Result = "Request handled: " + request.TextData
            });
        }
    }
}
