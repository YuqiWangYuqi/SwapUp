using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwapUp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SwapUp.Model;

namespace SwapUp.Pages
{
    /* page model class for  */
    public class IndexModel : PageModel
    {
        // local veriable to deternmain login in status
        private readonly ILogger<IndexModel> _logger;

        // init json file object
        public JsonFileProductService ProductService;

        // support return a collection of the product object
        public IEnumerable<Product> Products { get; private set; }
    }
}