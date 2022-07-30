namespace ECommerce.Client.Pages.BaseClasses
{
    public class ProductDetailsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        protected Product? product { get; set; }

        protected string message = String.Empty;
        [Parameter]
        public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            message = "Loading Product...";
            var result = await ProductService.GetProduct(Id);

            if(!result.Success)
            {
                message = result.Message;
            }
            else
            {
                product = result.Data;
            }
        }
    }
}
