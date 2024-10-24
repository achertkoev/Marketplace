using Microsoft.AspNetCore.Http.HttpResults;
using ProductCatalog.Service.Models;

public static class ProductApi
{
    public static IEndpointRouteBuilder MapProductApiV1(this IEndpointRouteBuilder app)
    {
        var api = app.MapGroup("api/products");
        api.MapGet(string.Empty, GetProducts)
            .WithDescription("Получить продукты");

        return app;
    }

    static Results<Ok<List<Product>>, BadRequest<string>> GetProducts()
    {
        
        return TypedResults.Ok(new List<Product>());
    }
}