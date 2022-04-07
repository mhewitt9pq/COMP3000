using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using secPass;

namespace SecPassTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void hashcalc()
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

        [TestMethod]
        public void encryption()
        {
            //Arrange
            string passT = "secret123";
            string massPassT = "mastp";
            secController sec = new secController();

            //Act
            string enc = sec.encrypt(massPassT, passT);

            //Assert
            Assert.AreEqual("aKBNsu6q4FCkX3EM93lnYg==", enc);
        }

        [TestMethod]
        public void decryption()
        {
            //Arrange
            string cryptText = "aKBNsu6q4FCkX3EM93lnYg==";
            string massPassT = "mastp";
            secController sec = new secController();

            //Act
            string dec = sec.decrypt(massPassT, cryptText);

            //Assert
            Assert.AreEqual("secret123", dec);
        }

        [TestMethod]
        public void strengthTest1()
        {
            //Arrange
            string weakpass1 = "pass";
            int strengthScore;

            //Act
            strengthScore = secPass.UserControls.StorePassword.strengthCheck(weakpass1);

            //Assert
            Assert.AreEqual(1, strengthScore);
        }

        [TestMethod]
        public void strengthTest2()
        {
            //Arrange
            string weakpass2 = "password";
            int strengthScore;

            //Act
            strengthScore = secPass.UserControls.StorePassword.strengthCheck(weakpass2);

            //Assert
            Assert.AreEqual(2, strengthScore);
        }

        [TestMethod]
        public void strengthTest3()
        {
            //Arrange
            string weakpass3 = "password1";
            int strengthScore;

            //Act
            strengthScore = secPass.UserControls.StorePassword.strengthCheck(weakpass3);

            //Assert
            Assert.AreEqual(3, strengthScore);
        }

        [TestMethod]
        public void strengthTest4()
        {
            //Arrange
            string weakpass4 = "weakpassword123";
            int strengthScore;

            //Act
            strengthScore = secPass.UserControls.StorePassword.strengthCheck(weakpass4);

            //Assert
            Assert.AreEqual(4, strengthScore);
        }

        [TestMethod]
        public void strengthTest5()
        {
            //Arrange
            string weakpass5 = "weakpassword123!";
            int strengthScore;

            //Act
            strengthScore = secPass.UserControls.StorePassword.strengthCheck(weakpass5);

            //Assert
            Assert.AreEqual(5, strengthScore);
        }

        [TestMethod]
        public void strengthTest6()
        {
            //Arrange
            string weakpass6 = "Weakpassword123!";
            int strengthScore;

            //Act
            strengthScore = secPass.UserControls.StorePassword.strengthCheck(weakpass6);

            //Assert
            Assert.AreEqual(6, strengthScore);
        }
    }
}