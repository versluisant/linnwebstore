using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using linn.admin.Models;
using linn.admin.ViewModels;

namespace linn.admin.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public JsonResult Index()
        {
            var category1 = new Category()
            {
                Id = 1,
                Description = "Category1",
                Url = "/Category1",
                ParentCategory = null
            };
            var category2 = new Category()
            {
                Id = 1,
                Description = "Category2",
                Url = "/Category2",
                ParentCategory = null
            };
            var category3 = new Category()
            {
                Id = 1,
                Description = "Category3",
                Url = "/Category3",
                ParentCategory = null
            };
            var category4 = new Category()
            {
                Id = 1,
                Description = "Category4",
                Url = "/Category1/Category4",
                ParentCategory = category1
            };
            var category5 = new Category()
            {
                Id = 1,
                Description = "Category5",
                Url = "/Category1/Category5",
                ParentCategory = null
            };
            var category6 = new Category()
            {
                Id = 1,
                Description = "Category6",
                Url = "/Category2/Category6",
                ParentCategory = category1
            };
            var category7 = new Category()
            {
                Id = 1,
                Description = "Category7",
                Url = "/Category2/Category7",
                ParentCategory = category2
            };
            var category8 = new Category()
            {
                Id = 1,
                Description = "Category8",
                Url = "/Category2/Category8",
                ParentCategory = category2
            };
            var categories = new List<Category>() {category1, category2, category3};
            var categoriesViewModel = new CategoriesViewModel()
            {
                Categories = categories
            };


            var json = Json(categories);
            return Json(categories);
        }
    }
}