using Microsoft.AspNetCore.Components;
using ECommerce.Shared;
using System.Net.Http.Json;


namespace ECommerce.Client.Shared.BaseClasses
{
    public class ProductListBase : ComponentBase
    {
        protected static List<Product> products = new List<Product>();
        private readonly HttpClient Http = new HttpClient();

        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<List<Product>>(Http.BaseAddress + "api/product");

            if(result != null)
            {
                products = result;
            }
        }
    }
}
