using Andreys.Services;

namespace Andreys.App.Controllers
{
    using SIS.HTTP;
    using SIS.MvcFramework;

    public class HomeController : Controller
    {
        private readonly IProductsService productsService;

      

        [HttpGet("/")]
        public HttpResponse IndexSlash()
        {
            return this.Index();
        }

          public HttpResponse Index()
          {
  
              return this.View();
          }



    }
}
