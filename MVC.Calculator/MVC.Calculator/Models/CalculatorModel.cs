using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace MVC.Calculator.Models
{
    public class CalculatorModel
    {
        [DisplayName("First Number")]
        public decimal FirstNum { get; set; }

        [DisplayName("Second Number")]
        public decimal SecondNum { get; set; }

        [DisplayName("Addition of two number")]
        public decimal Addition { get; set; }

        [DisplayName("Subtraction of two number")]
        public decimal Subtraction { get; set; }

        [DisplayName("Multiplication of two number")]
        public decimal Multiplication { get; set; }

        [DisplayName("Division of two number")]
        public decimal Division { get; set; }

    }
}