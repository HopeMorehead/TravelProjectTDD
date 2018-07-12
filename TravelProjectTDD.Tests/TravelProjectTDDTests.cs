using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelProjectTDD.Tests
{
    [TestFixture]
    class TravelProjectTDDTests
    {
        [Test]
        public void Test_Default_CTR()//method travel place
        {
            // This will test the instantiation of the Travel class 
            var PersonalInfo = new TravelProject_1();//Arrange
            //  This test MUST use a property to take in the string "FName" and return the same.
            var result = PersonalInfo.FName = "Hope ";//Action
            Assert.That(result, Is.EqualTo("Hope "));//Assert
        }
        [Test]
        public void Test_LastName_Prop()
        {
            //This will test the instantiation of the Travel class
            var PersonalInfo = new TravelProject_1();//Arrange
            //This test MUST use a property to take in the string "LName" and return the same.
            var result = PersonalInfo.LName = "Moore";//Action
            Assert.That(result, Is.EqualTo("Moore"));//Assert
        }
        [Test]
        public void Test_Address_Prop()
        {
            //This will test the instantiation of the Travel class
            var PersonalInfo = new TravelProject_1();//Arrange
            //This test MUST use a property to take in the string "Address " and return the same.
            var result = PersonalInfo.Address = "4908 Est 67th Cleveland OH";//Action
            Assert.That(result, Is.EqualTo("4908 Est 67th Cleveland OH"));//Assert
        }
        [Test]
         public void Test_Address_Email()
        {
            //This will test the instantiation of the Travel 
            var PersonalInfo = new TravelProject_1();//Arrange
            // This test MUST use a property to take in the string " " and return the same.
            var result = PersonalInfo.Email ="HMoore@yahoo.com";//Action;
            Assert.That(result, Is.EqualTo("HMoore@yahoo.com"));//Assert
        }
         [Test]
         public void Test_vaild_Email()
         {
            var PersonalInfo = new TravelProject_1();//Arrange
           // This test MUST use a property to take in the string " " and return the same.
           var result = PersonalInfo.GetEmail("@");//Action;
           Assert.That(result, Is.EqualTo(true));//Assert
          }
        [Test]
        public void Test_vaild_Email_1()
        {
           var PersonalInfo = new TravelProject_1();//Arrange
          // This test MUST use a property to take in the string " " and return the same.
          var result = PersonalInfo.GetEmail("h");//Action;
          Assert.That(result, Is.EqualTo(false));//Assert
        }
        [Test]
        public void Test_Date_Travel_Method() 
        {
        var PersonalInfo = new TravelProject_1();//Arrange
        //This will test the function of the GetDate method.
        //This test MUST accept the following value parementer as integers 9, 8, 2018.
        var result = PersonalInfo.GetDate(9,8,2018);//Action;
        //The test MUST return a value in the following string format "9/8/2018".
         Assert.That(result, Is.EqualTo("9/8/2018"));//Assert
        }

        [Test]
        public void Test_Total_Travel_Time_Method()
        {
           var PersonalInfo = new TravelProject_1();//Arrange
          //This will test the function of the TtlTravel method.
          //This test MUST accept the following value parementer as integers 9, 13, 2018 
          //and return the integer 5.
          var result = PersonalInfo.TtlTravel(9,13,2018);//Action;
          //  TravelProject_1.TtlTravelFunctionDelegate TtlTravel = null;
           TravelProject_1.TtlTravelFunctionDelegate del = new TravelProject_1.TtlTravelFunctionDelegate(PersonalInfo.TtlTravel);
          //  del


            //This test MUST calculate the total number of days the user will spend on vacation.
            //The method MUST use 2 arrays, Split() method, int.Parse() method, for loop, 2 if statments to perform the calculations.
            //Hint: You MUST set a var equal to "9/8/2018" and use this date for the start date.
            Assert.That(result, Is.EqualTo(5));//Assert

        }

    }
}
   