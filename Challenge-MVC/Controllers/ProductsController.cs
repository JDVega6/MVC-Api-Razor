using Challenge_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Challenge_MVC.Controllers
{
    public class ProductsController : Controller
    {
        // GET: ProductsController
        public ActionResult Index()
        {
            var products = GetData();
            return View(products);
        }

        public IActionResult Product(int idProduct)
        {
            Products modelProduct = new Products();

            ViewBag.Accion = "New Product";


            if (idProduct != 0)
            {
                ViewBag.Accion = "Edit Product";
                //modelProduct = await _servicioApi.GetById(idProduct);
            }

            return View(modelProduct);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public List<Products> GetData()
        { 
            List<Products> products = new List<Products>();
            products.Add(new Products { Id = 1, Description = "Country hous", Type = (EntityTypeOption)1, Value = 5000000, Status = (EntityStatus)1});
            products.Add(new Products { Id = 2, Description = "Country", Type = (EntityTypeOption)2, Value = 540000, Status = (EntityStatus)1 });
            products.Add(new Products { Id = 1, Description = "House", Type = (EntityTypeOption)1, Value = 5000000, Status = (EntityStatus)1 });

            return products;
        
        }
    }
}
