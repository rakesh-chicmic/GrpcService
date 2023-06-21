using Grpc.Core;
using Microsoft.AspNetCore.Authorization;

namespace GrpcService.Services
{
    [Authorize]
    public class ProductService : Product.ProductBase
    {
        private readonly ILogger<ProductService> _logger;

        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }

        public override Task<ProductModel> GetProductsInformation(GetProductDetails request ,ServerCallContext context)
        {
            ProductModel productDetail = new ProductModel();
            if (request.ProductId == 1)
            {
                productDetail.ProductName = "Samsung TV";
                productDetail.ProductDescription = "Smart TV";
                productDetail.ProductPrice = 35000;
                productDetail.ProductStock = 10;
            }
            else if (request.ProductId == 2)
            {
                productDetail.ProductName = "HP Laptop";
                productDetail.ProductDescription = "HP Pavilion";
                productDetail.ProductPrice = 55000;
                productDetail.ProductStock = 20;
            }
            else if (request.ProductId == 3)
            {
                productDetail.ProductName = "IPhone";
                productDetail.ProductDescription = "IPhone 12";
                productDetail.ProductPrice = 65000;
                productDetail.ProductStock = 30;
            }

            return Task.FromResult(productDetail);
        }
    }
}
