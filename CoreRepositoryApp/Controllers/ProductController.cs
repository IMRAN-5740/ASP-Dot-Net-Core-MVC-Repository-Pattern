using CoreRepositoryApp.Data;
using CoreRepositoryApp.Interfaces.Manager;
using CoreRepositoryApp.Manager;
using CoreRepositoryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace CoreRepositoryApp.Controllers
{


    public class ProductController : Controller
    {
       // private ApplicationDbContext _context;
        private ProductManager _productManager;
        //public ProductController(ApplicationDbContext context)
        //{
        //    _context = context;
        //    _productManager=new ProductManager(_context);
        //}
        public ProductController(ProductManager productManager)
        {
            _productManager = productManager;   
        }

        public IActionResult Index()
        {
            var products = _productManager.GetAll();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult Create(Product product)
        {
            string msg = "";
            bool isResult = _productManager.Add(product);
            if(isResult)
            {
                msg = "Product has been saved Successfully";
                return RedirectToAction(nameof(Index));

            }
            else
            {
                msg = "Product not Saved";
            }
            ViewBag.Message = msg;
            ModelState.Clear();
           // return RedirectToAction(nameof(Index));
           return View();
        }

        public IActionResult Edit(int id)
        {
            var product = _productManager.GetById(id);  
            if(product==null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            string msg = "";
            bool isUpdated = _productManager.Update(product);
            if(isUpdated)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                msg = "Product not Updated";
            }
            ViewBag.Message = msg;
            return View(product);
        }

        public IActionResult Details(int id)
        {
            var product = _productManager.GetById(id);
            if(product == null)
            {
                return NotFound();
            }

            return View(product);
        }

       public IActionResult Delete(int id)
        {
            var product = _productManager.GetById(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            string msg = "";
            bool isDelete = _productManager.Delete(product);
            if(isDelete)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                msg = "Product Delete Failed";
            }
            ViewBag.Message = msg;
            return View(product);
        }
    }
}
