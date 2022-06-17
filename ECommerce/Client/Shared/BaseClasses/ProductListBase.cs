using Microsoft.AspNetCore.Components;
using ECommerce.Shared;
using System.Net.Http.Json;


namespace ECommerce.Client.Shared.BaseClasses
{
    public class ProductListBase : ComponentBase
    {
        protected static List<Product> products = new List<Product>();

        [Inject]
        protected HttpClient? Http { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var result = await Http.GetFromJsonAsync<List<Product>>("/api/product");

            if(result != null)
            {
                products = result;
            }
        }
    }
}
