using Grpc.Core;
using GrpcService;
using Microsoft.AspNetCore.Authorization;

namespace GrpcService.Services
{
    [Authorize]
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            Console.WriteLine("Hello "+context.GetHttpContext().User.Identity);
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }

    }
}