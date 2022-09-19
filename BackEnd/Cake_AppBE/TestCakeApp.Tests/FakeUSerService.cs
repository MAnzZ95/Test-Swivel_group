using Cake_AppBE.IRepository;
using Cake_AppBE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCakeApp.Tests
{
    public class FakeUSerService : IUserRepository
    {
        private readonly IEnumerable<User> _user;
        public FakeUSerService()
        {
            _user = new List<User>()
            {
                new User() { UserName = "supun95", FirstName = "Supun", LastName = "Thilakarathna", Password = "1234" },
                new User() { UserName = "saman89", FirstName = "saman", LastName = "rathnayaka", Password = "1242" },
                new User() { UserName = "kasun90", FirstName = "Kasun", LastName = "ekanayaka", Password = "saman" },
            };
            
        }


        public Task<User> GetUserByUserName(string userName)
        {
            throw new NotImplementedException();
                        
        }
        
    }
}
