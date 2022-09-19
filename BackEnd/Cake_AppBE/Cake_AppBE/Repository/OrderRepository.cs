using Cake_AppBE.IRepository;
using Cake_AppBE.Models;
using Cake_AppBE.DBContext;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace Cake_AppBE.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Order> AddOrder(Order order)
        {
            try
            {
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();
                return order;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            try
            {
                return await _context.Orders.ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
            
        }

        public async Task<Order> GetOrderById(int id)
        {
            try
            {
                return await _context.Orders.FindAsync(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }

            
        }
    }
}
