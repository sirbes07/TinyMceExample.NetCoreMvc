using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TinyWebApp.Models;

namespace TinyWebApp.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult Create(ContentsModel model)
        {

            ViewBag.HtmlContent = model.Content;

            return View(model);
        }
    }
}