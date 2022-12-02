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

        public string GetPriceText(Product product)
        {
            var variants = product.Variants;

            if(variants.Count == 0)
            {
                return string.Empty;
            }
            else if(variants.Count == 1)
            {
                return $"${variants[0].Price}";
            }
            decimal minPrice = variants.Min(v => v.Price);

            return $"Starting at ${minPrice}";
        }
    }
}
