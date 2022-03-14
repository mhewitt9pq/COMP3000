using Microsoft.VisualStudio.TestTools.UnitTesting;
using secPass;

namespace secPass_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string strongpass = "T3stpassword!";

            string weakpass1 = "password";
            string weakpass2 = "password1";
            string weakpass3 = "weakpassword123";
            string weakpass4 = "weakpassword123!";
            string weakpass5 = "Weakpassword123!";



            //secPass.Form1.generatePass



            //Act
            
            //Code to test strengh of each password
            



            //Assert
            
            //Check strength scores - Pass if score strength matches password strength


        }
    }
}