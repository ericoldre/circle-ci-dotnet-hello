using hello.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace hello.UT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WeatherForecastController controller = new WeatherForecastController(null);
            var x = controller.Get();
            Assert.IsNotNull(x);
            Assert.IsTrue(x.Count() > 0);
        }
    }
}
