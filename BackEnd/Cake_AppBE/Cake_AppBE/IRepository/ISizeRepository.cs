using Cake_AppBE.DBContext;
using Cake_AppBE.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cake_AppBE.IRepository
{
    public interface ISizeRepository
    {
                
        Task<IEnumerable<SizeOfCake>> GetAllSises();
    }
}
