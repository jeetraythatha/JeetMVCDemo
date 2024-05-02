using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Data;
using MVCDemo.Data.Repository.IRepository;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;
        public ProductController(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var productList = _repository.GetAll();
            var productModelList = _mapper.Map<List<Product>, List<ProductModel>>(productList.ToList());
            return View(productModelList);
        }
        public IActionResult Add()
        {
            var model = new ProductModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(ProductModel model)
        {
            var enity = _mapper.Map<ProductModel, Product>(model);
            _repository.Insert(enity);
            _repository.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int productId)
        {
            var product = _repository.GetById(productId);
            var productModel = _mapper.Map<Product, ProductModel>(product);
            return View(productModel);
        }
        [HttpPost]
        public IActionResult Edit(ProductModel productModel)
        {
            var entity = _mapper.Map<ProductModel, Product>(productModel);
            _repository.Update(entity);
            _repository.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int productId)
        {
            var product = _repository.GetById(productId);
            var productModel = _mapper.Map<Product, ProductModel>(product);
            return View(productModel);
        }
        [HttpPost]
        public IActionResult Delete(ProductModel productModel)
        {
            var entity = _mapper.Map<ProductModel, Product>(productModel);
            _repository.Delete(entity);
            _repository.Save();
            return RedirectToAction("Index");
        }
    }
}
