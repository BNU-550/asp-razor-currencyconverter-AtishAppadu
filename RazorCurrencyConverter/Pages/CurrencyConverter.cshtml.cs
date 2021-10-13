using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrencyConverter.Pages
{
    public class CurrencyConverterModel : PageModel
    {
        // exchange rate
        public const double GBP_To_EUR = 1.18;
        [BindProperty]
        public double InputGBP { get; set; }
        [BindProperty]
        public double OutputEUR { get; set; }

        public void OnGet()
        {

        }

        public void Onpost()
        {
            if (Double.IsNegative(InputGBP))
            {
                ViewData["Message"] = "cannot enter a negative value";
            }
            else if( InputGBP > 0 )
            {
                OutputEUR = InputGBP * GBP_To_EUR;
                ViewData
            }
        }
    }
}
