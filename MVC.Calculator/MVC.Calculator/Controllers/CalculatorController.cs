using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Calculator.Models;

namespace MVC.Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CalculatorModel model)
        {
            model.Addition = model.FirstNum + model.SecondNum;
            model.Subtraction = model.FirstNum - model.SecondNum;
            model.Multiplication = model.FirstNum * model.SecondNum;
            model.Division = Math.Round(model.FirstNum / model.SecondNum,2);
            return View(model);
        }
    }
}