using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
         WeatherForecastController controller = new WeatherForecastController();
         [Fact]
         public void getReturnsMyName()
         {
         var returnValue = controller.Get(1);
         Assert.Equal("ahmed",returnValue.Value);
         }

    
        [Fact]
        public void Test1()
        {

        }
    }
}
