using Cake_AppBE.DBContext;
using Cake_AppBE.IRepository;
using Cake_AppBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cake_AppBE.Repository
{
    
    public class ShapeRepository: IShapeRepository
    {
        private readonly AppDbContext _context;

        public ShapeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ShapeOfCake>> GetAllShapes()
        {
            try
            {
                return await _context.ShapeOfCakes.ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
