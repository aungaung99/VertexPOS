using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using VertexPOS.Core;
using VertexPOS.Core.Interfaces;
using VertexPOS.Core.Repositories;

namespace VertexPOS.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IAppLogger<IndexModel> _logger;
        private readonly IBrandRepository _brandRepository;

        public IndexModel(IAppLogger<IndexModel> logger, IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository ?? throw new ArgumentNullException(nameof(brandRepository));
            _logger = logger;
        }

        public IEnumerable<Brand> BrandList { get; set; } = new List<Brand>();

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            BrandList = await _brandRepository.GetAllAsync(SearchTerm);
            _logger.LogCritical("Success call list");
            return Page();
        }
    }
}
