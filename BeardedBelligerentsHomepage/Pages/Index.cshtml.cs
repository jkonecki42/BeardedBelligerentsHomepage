using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeardedBelligerentsHomepage.Pages
{
    public class IndexModel(ILogger<IndexModel> logger, IConfiguration config) : PageModel
    {
        public string? Title;
        private readonly ILogger<IndexModel> _logger = logger;
        private readonly IConfiguration _config = config;

        public void OnGet()
        {
            Title = _config.GetValue<string>("Title") ?? "MissingConfig";            
        }
    }
}