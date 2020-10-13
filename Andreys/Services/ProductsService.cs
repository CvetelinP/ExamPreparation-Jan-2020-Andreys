using System;
using Andreys.Data;
using Andreys.Models;
using Andreys.ViewModels.Products;

namespace Andreys.Services
{
    public class ProductsService : IProductsService
    {
        private readonly AndreysDbContext _db;

        public ProductsService(AndreysDbContext db)
        {
            _db = db;
        }
        public int Add(ProductAddInputModel model)
        {
            var categoryEnum = Enum.Parse<Category>(model.Category);
            var genderEnum = Enum.Parse<Gender>(model.Gender);
            var product = new Product
            {
               
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Price = model.Price,
                Category = categoryEnum,
                Gender = genderEnum

            };
            _db.Products.Add(product);
            _db.SaveChanges();

            return product.Id;

        }
        //public string Name { get; set; }

        //public string Description { get; set; }

        //public string ImageUrl { get; set; }

        //public decimal Price { get; set; }

        //public string Category { get; set; }

        //public string Gender { get; set; }
    }
}
