using Cake_AppBE.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cake_AppBE.IRepository
{
    public interface IWordDesignRepository
    {
        public Task<IEnumerable<CakeWordDesign>> GetAllWordDesign();
    }
}
