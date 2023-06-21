using Grpc.Core;
using Grpc.Net.Client;
using GrpcClient;

var channel = GrpcChannel.ForAddress("https://localhost:7047");
var client = new Greeter.GreeterClient(channel);
var headers = new Metadata();
headers.Add("Authorization", "Bearer eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiempoZ2RoZ2RzQGdtYWlsLmNvbSIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IkxvZ2luIiwiZXhwIjoxNjg3NDIxNDY4fQ.de4LJHZNLtk_0kbZkpZ-OBGOsf9HHAd4dUesXlkZAHyxgK8cByJOzPpFpbaOcUjyMOOBx27fefELDQBvfQCufA");
var response = await client.SayHelloAsync(
    new HelloRequest { Name = "World" }, headers);



Console.WriteLine(response.Message);

var client2 = new Product.ProductClient(channel);
var product = new GetProductDetails { ProductId = 2 };
var response2 = await client2.GetProductsInformationAsync(product);

Console.WriteLine(response2);


