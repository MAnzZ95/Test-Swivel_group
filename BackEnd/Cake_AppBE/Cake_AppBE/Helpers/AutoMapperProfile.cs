using Cake_AppBE.Models;
using AutoMapper;
namespace Cake_AppBE.Helpers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
        }
    }
}
