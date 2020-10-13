using Andreys.Services;
using Andreys.ViewModels.Products;
using SIS.HTTP;
using SIS.MvcFramework;

namespace Andreys.Controllers
{
    public class ProductsController:Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }
        public HttpResponse Add()
        {
           
            return this.View();
        }

        [HttpPost]
        public HttpResponse Add(ProductAddInputModel input)
        {
            var userId=this._productsService.Add(input);
            return this.View();
        }
    }
}
