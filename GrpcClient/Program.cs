using Grpc.Net.Client;
using GrpcClient;

var channel = GrpcChannel.ForAddress("https://localhost:7047");
var client = new Greeter.GreeterClient(channel);

var response = await client.SayHelloAsync(
    new HelloRequest { Name = "World" });

Console.WriteLine(response.Message);

var client2 = new Product.ProductClient(channel);
var product = new GetProductDetails { ProductId = 2 };
var response2 = await client2.GetProductsInformationAsync(product);

Console.WriteLine(response2);


