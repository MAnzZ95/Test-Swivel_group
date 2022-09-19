using Cake_AppBE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCakeApp.Tests.FakeData
{
    public class ShapeMockData
    {
        public static List<ShapeOfCake> getMockShapes()
        {
            return new List<ShapeOfCake>
            {
                new ShapeOfCake() {ShepeId=1,ShapeName="Square",Price=1},
                new ShapeOfCake() {ShepeId=2,ShapeName="Round",Price=2}
            };
        }

        public static List<ShapeOfCake> getEmptyShapes()
        {
            return new List<ShapeOfCake>();
        }
    }
}
