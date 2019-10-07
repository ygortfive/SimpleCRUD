using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleCRUD.Models;
using SimpleCRUD.Models.Contexto;

namespace SimpleCRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly Context _context;

        public ProductController(Context context)
        {
            _context = context;
        }
        
        //Listar
        [HttpGet]
        public IActionResult Index()
        {
            var listar = _context.Product_DB.ToList();
            return View(listar);
        }

        //Create
        [HttpGet]
        public IActionResult Create()
        {
            var product = new Product();
            return View(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Product_DB.Add(product);
                _context.SaveChanges();
                RedirectToAction("Index"); 
            }

            return View(product);
        }

        //Update

        [HttpGet]
        public IActionResult Edit(int IDProduct)
        {
            var product = _context.Product_DB.Find(IDProduct);
            return View(product);
        }

        [HttpPut]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Product_DB.Update(product);
                _context.SaveChanges();
                RedirectToAction("Index");
            }

            return View(product);
        }

        //Delete

        [HttpGet]
        public IActionResult Delete(int ProductID)
        {
            var product = _context.Product_DB.Find(ProductID);
            return View(product);
        }

        [HttpDelete]
        public IActionResult Delete(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Product_DB.Remove(product);
                _context.SaveChanges();
            }

            return View(product);
        }

        //Detalhes 
        [HttpGet]
        public IActionResult Details(int IDProduct)
        {
            var product = _context.Product_DB.Find(IDProduct);
            return View(product);
        }
    }
}