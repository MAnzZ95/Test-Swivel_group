using Cake_AppBE.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cake_AppBE.IRepository
{
    public interface IShapeRepository
    {
        Task <IEnumerable<ShapeOfCake>> GetAllShapes();
    }
}
