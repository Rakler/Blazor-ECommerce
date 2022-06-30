namespace ECommerce.Client.Pages.BaseClasses
{
    public class ProductDetailsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        protected Product? product { get; set; }

        [Parameter]
        public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            product = ProductService.Products.Find(p => p.Id == Id);
        }
    }
}
