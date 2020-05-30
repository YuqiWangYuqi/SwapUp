using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SwapUp.Pages
{   /*
     * error page c# class
     */
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {   //Generate property accessors
        public string RequestId { get; set; }
        //ShowRequestId
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        //Creates a logger, ILogger<AboutModel>, which uses a log category of the fully qualified name of the type AboutModel
        private readonly ILogger<ErrorModel> _logger;
        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }
        //OnGet methood
        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}
