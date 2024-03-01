using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeardedBelligerentsHomepage.Pages
{
    public class IndexModel : PageModel
    {
        public string Title;
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _config;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        

        public void OnGet()
        {
            Title = _config.GetValue<string>("Title") ?? "MissingConfig";            
        }
    }
}