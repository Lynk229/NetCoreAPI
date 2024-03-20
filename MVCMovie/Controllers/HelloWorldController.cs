    using System.Diagnostics;
    using Microsoft.AspNetCore.Mvc;
    using MvcMovie.Models;
namespace MvcMovie.Controllers 
{
    public class HelloWorldController : Controller
    {
        //GET: /HelloWorld/
        public  class string Index()
        {
            return"This is my default action...";
        }
        //GET: /HelloWorld/Welcome/

        public IActionResult stringWelcome()
        {
             return View();
        }
    }
}