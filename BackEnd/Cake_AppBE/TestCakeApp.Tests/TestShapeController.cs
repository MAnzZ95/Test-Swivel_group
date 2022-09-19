using Cake_AppBE.Controllers;
using Cake_AppBE.IRepository;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestCakeApp.Tests.FakeData;
using Xunit;

namespace TestCakeApp.Tests
{
    public class TestShapeController
    {
        [Fact]
        public async Task GetAllShapes_Return200OkContentStatus()
        {
            //Arrange
            var shapeService = new Mock<IShapeRepository>();
            shapeService.Setup(a => a.GetAllShapes()).ReturnsAsync(ShapeMockData.getMockShapes());
            var sut = new ShapeController(shapeService.Object);

            /// Act
            var result = (OkObjectResult)await sut.getShapeAllShapes();


            /// Assert
            result.StatusCode.Should().Be(200);
           
        }
        [Fact]
        public async Task GetAllShapes_Return204NoContentStatus()
        {
            //Arrange
            var shapeService = new Mock<IShapeRepository>();
            shapeService.Setup(a => a.GetAllShapes()).ReturnsAsync(ShapeMockData.getEmptyShapes());
            var sut = new ShapeController(shapeService.Object);

            /// Act
            var result = (NoContentResult)await sut.getShapeAllShapes();


            /// Assert
            result.StatusCode.Should().Be(204);
            shapeService.Verify(a => a.GetAllShapes(), Times.Exactly(1));

        }

    }
}
