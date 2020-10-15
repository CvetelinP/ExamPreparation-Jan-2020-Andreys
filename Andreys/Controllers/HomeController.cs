using Andreys.Services;

namespace Andreys.App.Controllers
{
    using SIS.HTTP;
    using SIS.MvcFramework;

    public class HomeController : Controller
    {
        private readonly ProductsService _productsService;


        public HomeController(ProductsService productsService)
        {
            _productsService = productsService;
        }
      

        [HttpGet("/")]
        public HttpResponse IndexSlash()
        {
            return this.Index();
        }

          public HttpResponse Index()
          {


              if (IsUserLoggedIn())
              {
                  var allproducts = _productsService.GetAll();


                  return this.View(allproducts, "Home");
              }
              
  
              return this.View();
          }



    }
}
