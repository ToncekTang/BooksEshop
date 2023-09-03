using Eshop.DataAccess.Data;
using Eshop.DataAccess.Repository.IRepository;
using Eshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.DataAccess.Repository
{
    public class ProductRepository :  Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product products)
        {
            var obj = _db.Products.FirstOrDefault(u => u.Id == products.Id);
            if (obj != null) 
            {
                obj.Title = products.Title;
                obj.Description = products.Description;
                obj.Price = products.Price;
                obj.ISBN = products.ISBN;
                obj.Author = products.Author;
                obj.CategoryId = products.CategoryId;
                obj.PriceFifty = products.PriceFifty;
                obj.PriceHundred = products.PriceHundred;
                obj.ListPrice = products.ListPrice;
                if(obj.ImageUrl != null)
                {
                    obj.ImageUrl = products.ImageUrl;
                }
            }
        }
    }
}
