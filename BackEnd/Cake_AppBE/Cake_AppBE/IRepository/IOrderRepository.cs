using Cake_AppBE.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cake_AppBE.IRepository
{
    public interface IOrderRepository
    {
        public Task<IEnumerable<Order>> GetAllOrders();
        public Task<Order> GetOrderById(int id);
        public Task<Order> AddOrder(Order order);
    }
}
