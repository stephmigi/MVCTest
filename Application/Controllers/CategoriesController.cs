using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ObjectModel;
using Application.Models.ViewModels;

namespace Application.Controllers
{
    public class CategoriesController : Controller
    {

        // GET: /Categories/
        public ActionResult Index()
        {
            var model = new CategoriesViewModel { Categories = Category.GetFakeCategoryList() };
            return View("Index", model);
        }

        //GET : Show category
        public ActionResult Detail(int id)
        {
            var model = new CategoryViewModel { Category = Category.GetFakeCategoryList().FirstOrDefault(p => p.Id == id) };
            return View("Category", model);
        }

        //GET : Edit category
        public ActionResult Edit(int id)
        {
            var model = new CategoryViewModel { Category = Category.GetFakeCategoryList().FirstOrDefault(p => p.Id == id) };
            return View("EditCategory", model);
        }

        // POST : Edit category
        [HttpPost]
        public ActionResult Edit(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                Category.GetFakeCategoryList().Where(p => p.Id == model.Category.Id);
                return RedirectToAction("Index");
            }
            return View("EditCategory", model);
        }

        // GET : Show subcategory
        public ActionResult SubCatDetail(int id)
        {
            var model = new SubCategoryViewModel { SubCategory = SubCategory.GetAllSubCategories().FirstOrDefault(p => p.Id == id) };
            return View("SubCategory", model);
        }

        //GET : Edit subcategory
        public ActionResult SubCatEdit(int id)
        {
            var model = new SubCategoryViewModel { SubCategory = SubCategory.GetAllSubCategories().FirstOrDefault(p => p.Id == id) };
            return View("EditSubCategory", model);
        }

        // POST : Edit category
        [HttpPost]
        public ActionResult SubCatEdit(SubCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                //saveToDb
                return RedirectToAction("Index");
            }
            return View("EditSubCategory", model);
        }
    }
}
