using System.Collections;
using System.Collections.Generic;
using Andreys.Models;
using Andreys.ViewModels.Products;

namespace Andreys.Services
{
    public interface IProductsService
    {
        int Add(ProductAddInputModel model);

        IEnumerable<Product> GetAll();

        public Product GetById(int id);


    }
}
