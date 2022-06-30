using Microsoft.AspNetCore.Components;
using ECommerce.Shared;
using System.Net.Http.Json;


namespace ECommerce.Client.Shared.BaseClasses
{
    public class ProductListBase : ComponentBase
    {
        protected static List<Product> products = new List<Product>();



        [Inject]
        protected IProductService ProductService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await ProductService.GetProducts();
        }
    }
}
