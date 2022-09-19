using Cake_AppBE.DBContext;
using Cake_AppBE.Helpers;
using Cake_AppBE.IRepository;
using Cake_AppBE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Cake_AppBE.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<User> GetUserByUserName(string userName)
        {
            try
            {
                return  await _context.Users.FindAsync(userName);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<User> Authenticate(string username, string password)
        {
            try
            {
                HashPassword hash = new HashPassword();
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    return null;

                var user = await _context.Users.SingleOrDefaultAsync(x => x.UserName == username);

                
                if (user == null)
                    return null;
                                
                if (!hash.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                    return null;
                                
                return user;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<User> Create(User user, string password)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(password))
                    throw new AppException("Password is required");

                if (_context.Users.Any(x => x.UserName == user.UserName))
                    throw new AppException("Username \"" + user.UserName + "\" is already taken");

                byte[] passwordHash, passwordSalt;
                HashPassword hash = new HashPassword();
                hash.CreatePasswordHash(password, out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                return user;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
