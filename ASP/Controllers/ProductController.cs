﻿using ASP.Handlers;
using ASP.Models;
using BLL.Entities;
using Microsoft.AspNetCore.Mvc;
using Shared.Repositories;

namespace ASP.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository<Product> _productRepository;

        public ProductController(IProductRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: ProductController
        public ActionResult Index()
        {
            IEnumerable<ProductListItemViewModel> model = _productRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            ProductDetailsViewModel model = _productRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "No form returned!");
                if (!ModelState.IsValid) throw new Exception();
                int id = _productRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Index), new { id });
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
    }
}
