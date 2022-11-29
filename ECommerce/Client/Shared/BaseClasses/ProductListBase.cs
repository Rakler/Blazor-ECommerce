using ECommerce.Shared;
using System.Net.Http.Json;


namespace ECommerce.Client.Shared.BaseClasses
{
    public class ProductListBase : ComponentBase, IDisposable
    {
        protected static List<Product> products = new List<Product>();



        [Inject]
        protected IProductService ProductService { get; set; }

        protected override void OnInitialized()
        {
            ProductService.ProductsChanged += StateHasChanged;
        }

        public void Dispose()
        {
            ProductService.ProductsChanged -= StateHasChanged;
        }
    }
}
