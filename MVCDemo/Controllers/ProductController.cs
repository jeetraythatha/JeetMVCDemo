using Microsoft.AspNetCore.Mvc;
using MVCDemo.Data;
using MVCDemo.Data.Repository.IRepository;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository<Product> _repository;
        public ProductController(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var productList = _repository.GetAll();
            List<ProductModel> productModelList = new List<ProductModel>();
            foreach(var product in productList)
            {
                var model = new ProductModel();
                model.Id = product.Id;
                model.Name = product.Name;
                model.Description = product.Description;
                model.Category = product.Category;
                productModelList.Add(model);
            }
            return View(productModelList);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
