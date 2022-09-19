using Cake_AppBE.DBContext;
using Cake_AppBE.IRepository;
using Cake_AppBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cake_AppBE.Repository
{
    public class WordDesignRepository : IWordDesignRepository
    {
        private readonly AppDbContext _context;

        public WordDesignRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CakeWordDesign>> GetAllWordDesign()
        {
            try
            {
                return await _context.CakeWordDesigns.ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
