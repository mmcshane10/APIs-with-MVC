using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApiCall.Models;

namespace MVCApiCall.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allReviews = Article.GetReviews(EnvironmentVariables.ApiKey);
            return View(allReviews);
        }
    }
}
