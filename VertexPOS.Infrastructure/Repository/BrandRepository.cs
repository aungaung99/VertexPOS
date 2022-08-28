using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VertexPOS.Core;
using VertexPOS.Core.Repositories;

namespace VertexPOS.Infrastructure.Repository
{
    public class BrandRepository : IBrandRepository
    {
        readonly VertexPOSDbContext _context;
        public BrandRepository(VertexPOSDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Brand>> GetAllAsync(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return await _context.Brands.Where(b=>b.BrandName.ToLower().Contains(name.ToLower())).ToListAsync();
            }
            return await _context.Brands.ToListAsync();
        }
    }
}
