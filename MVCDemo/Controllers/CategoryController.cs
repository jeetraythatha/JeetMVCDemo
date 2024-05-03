using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Data;
using MVCDemo.Data.Repository.IRepository;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;
        public CategoryController(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public IActionResult Index()
        {
            var categories = _repository.GetAll(); 
            var categoryModels = _mapper.Map<List<CategoryModel>>(categories);
            return View(categoryModels);
        }
        public IActionResult Add()
        {
            var categoryModel = new CategoryModel();
            return View(categoryModel);
        }
        [HttpPost]
        public IActionResult Add(CategoryModel categoryModel)
        {
            var category = _mapper.Map<CategoryModel, Category>(categoryModel);
            _repository.Insert(category);
            _repository.Save();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int categoryId)
        {
            var category = _repository.GetById(categoryId);

            var categoryModel = _mapper.Map<Category, CategoryModel>(category);
            return View(categoryModel);
        }
        [HttpPost]
        public IActionResult Edit(CategoryModel categoryModel)
        {
            var category = _mapper.Map<CategoryModel, Category>(categoryModel);
            _repository.Update(category);
            _repository.Save();
            return RedirectToAction("Index");
        }
    }
}
