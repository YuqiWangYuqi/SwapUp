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
    /* using model definition*/
    public class IndexModel : PageModel
    {
        // private logger 
        private readonly ILogger<IndexModel> _logger;

        // init json file service
        public JsonFileProductService ProductService;

        // products getter and private setter
        public IEnumerable<Product> Products { get; private set; }

        // public constructor
        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        // public getter to deliever prodcut info
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}