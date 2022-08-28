using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexPOS.Core.Repositories
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetAllAsync(string name);
    }
}
