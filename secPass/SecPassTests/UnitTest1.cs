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
        public void strengthTest()
        {
            //Arrange
            string strongpass = "T3stpassword!";
            string weakpass1 = "password";
            string weakpass2 = "password1";
            string weakpass3 = "weakpassword123";
            string weakpass4 = "weakpassword123!";
            string weakpass5 = "Weakpassword123!";



            string cryptText = "aKBNsu6q4FCkX3EM93lnYg==";
            string massPassT = "mastp";
            secController sec = new secController();

            //Act
            string dec = sec.decrypt(massPassT, cryptText);

            //Assert
            Assert.AreEqual("secret123", dec);
        }
        string strongpass = "T3stpassword!";

        string weakpass1 = "password";
        string weakpass2 = "password1";
        string weakpass3 = "weakpassword123";
        string weakpass4 = "weakpassword123!";
        string weakpass5 = "Weakpassword123!";
    }
}