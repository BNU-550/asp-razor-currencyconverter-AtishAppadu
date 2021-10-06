using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorCurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FullName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Atish Appadu";
        }
        public void OnPost()
        {
            if(string.IsNullOrWhiteSpace(FullName))
            {
                ViewData["NoName"] = "Please Enter a Name";
                FullName = "Atish Appadu";
            }
            else
            {
                ViewData["Message"] = "Name is Registered!";
                // the user is registered
            }
        }

    }
}
