using Cake_AppBE.DBContext;
using Cake_AppBE.IRepository;
using Cake_AppBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cake_AppBE.Repository
{
    public class SizeRepository : ISizeRepository
    {
        private readonly AppDbContext _context;

        public SizeRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SizeOfCake>> GetAllSises()
        {
            try
            {
                return await _context.SizeOfCakes.ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
