using Microsoft.VisualStudio.TestTools.UnitTesting;
using secPass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secPass.Tests
{
    [TestClass()]
    public class DashTests
    {
        [TestMethod()]
        public void calcHashTest()
        {
            //Arrange
            string userT = "username";
            string passT = "password";

            Dash dash = new Dash();

            //Act
            string hash = dash.calcHash(userT, passT);

            //Assert
            Assert.AreEqual("21320917311317814778193155414222430137215229180110736171169150331771389134172896856", hash);
        }
    }
}