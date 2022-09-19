using Cake_AppBE.DBContext;
using Cake_AppBE.IRepository;
using Cake_AppBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cake_AppBE.Repository
{
    public class ToppingRepository : IToppingRepository
    {
        private readonly AppDbContext _context;

        public ToppingRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CakeTopping>> GetAllToppings()
        {
            try
            {
                return await _context.CakeToppings.ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
