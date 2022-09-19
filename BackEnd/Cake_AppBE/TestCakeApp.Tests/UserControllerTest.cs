using Cake_AppBE.Controllers;
using Cake_AppBE.IRepository;
using Cake_AppBE.Models;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using TestCakeApp.Tests.FakeData;
using Xunit;

namespace TestCakeApp.Tests
{
    //public class UserControllerTest
    //{
    //    [Fact]
    //    //public async Task getCorrectUserbyName200Status()
    //    //{
    //    //                //Arrange
    //    //    //var exuser = UserMockData.ExsistingUser();
    //    //    //var userService = new Mock<IUserRepository>();
    //    //    //userService.Setup(a => a.GetUserByUserName(exuser.UserName));
    //    //    //var sut = new UserController(userService.Object);            

    //    //    ////Act
    //    //    //var result =(OkObjectResult)await sut.getUserbyUsername(exuser.UserName);

    //    //    ////Assert
    //    //    //result.StatusCode.Should().Be(200);
    //    //}
    //}
}
