using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CalculatorLogic model, string UserInput)
        {
            if (ModelState.IsValid)
            {
                if (UserInput == "add")
                {
                    model.Result = model.Num1 + model.Num2;
                }
                if (UserInput == "sub")
                {
                    model.Result = model.Num1 - model.Num2;
                }
                if (UserInput == "mul")
                {
                    model.Result = model.Num1 * model.Num2;
                }
                if (UserInput == "div")
                {
                    model.Result = model.Num1 / model.Num2;
                }
            }
            return View(model);
        }
    }
}
