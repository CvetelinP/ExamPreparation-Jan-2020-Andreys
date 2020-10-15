using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Product> GetAll()
            => this._db.Products.Select(x => new Product
            {
                Id = x.Id,
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Price = x.Price
            }).ToArray();

        public Product GetById(int id)
            => this._db.Products.FirstOrDefault(x => x.Id == id);



        //public string Name { get; set; }

        //public string Description { get; set; }

        //public string ImageUrl { get; set; }

        //public decimal Price { get; set; }

        //public string Category { get; set; }

        //public string Gender { get; set; }
    }
}
