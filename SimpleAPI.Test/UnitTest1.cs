using SimpleAPI.Controllers;
using System;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(null);

        [Fact]
        public void GetReturnsMyName()
        {
            var returnedValue = controller.Get();
            Assert.Equal("Naved Rasul", returnedValue);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
