using Cake_AppBE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCakeApp.Tests.FakeData
{
    public class UserMockData
    {
        public static List<User> getUsers()
        {
            return new List<User> 
            {
                new User() { UserName = "supun95", FirstName = "Supun", LastName = "Thilakarathna", Password = "1234" },
                new User() { UserName = "saman89", FirstName = "saman", LastName = "rathnayaka", Password = "1242" },
                new User() { UserName = "kasun90", FirstName = "Kasun", LastName = "ekanayaka", Password = "saman" },
            };
        }

        public static User ExsistingUser()
        {
            return new User
            {
                UserName = "kasun95",
                FirstName = "Kasun",
                LastName = "Kalhara",
                Password = "kasun@123"
            };
        }
    }
}
