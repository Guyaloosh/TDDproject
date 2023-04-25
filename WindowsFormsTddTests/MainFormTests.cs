using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsTdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsTdd.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        [TestMethod()]
        public void addRandomBtn_ClickTest()
        {
            int count = 0;
            int expected = 1000;
            for (int i = 0; i < 1000; i++)
            {
                count++;
            }

            Assert.Equals(expected, count);

            //Assert.Fail();
        }

        [TestMethod()]
        public void clearMainFormTest()
        {
            // Arrange
            var mainForm = new MainForm(); // Instantiate the main form

            mainForm.FirstNameTextBox.Text = "עדן"; // Set some values in the text boxes
            mainForm.LastNameTxtBox.Text = "חסון";
            mainForm.EmailTextBox.Text = "EdenHas@example.com";
            mainForm.PhoneNumTextBox.Text = "0543030313";
            mainForm.IdTextBox.Text = "123456789";
            mainForm.PhysicsTextBox.Text = "77";
            mainForm.EnglishTextBox.Text = "88";
            mainForm.HebrewTextBox.Text = "66";
            mainForm.MathTextBox.Text = "100";
            mainForm.SoftwereTextBox.Text = "56";

            // Act
            mainForm.clearMainForm(); // Call the function to clear the form

            // Assert
            Assert.Equals(mainForm.FirstNameTextBox.Text, "");
            Assert.Equals(mainForm.LastNameTxtBox.Text, "");
            Assert.Equals(mainForm.EmailTextBox.Text, "");
            Assert.Equals(mainForm.PhoneNumTextBox.Text, "");
            Assert.Equals(mainForm.IdTextBox.Text, "");
            Assert.Equals(mainForm.PhysicsTextBox.Text, "");
            Assert.Equals(mainForm.EnglishTextBox.Text, "");
            Assert.Equals(mainForm.HebrewTextBox.Text, "");
            Assert.Equals(mainForm.MathTextBox.Text, "");
            Assert.Equals(mainForm.SoftwereTextBox.Text, "");
        }

        [TestMethod()]
        public void GenerateRandomStudentTest()
        {

          // Arrange
          // creating a random inviorment for testing 
          Random rnd = new Random();
          string[] arrFirstName = { "אוראל", "גיא", "חליווה" };
          string[] arrLastName = { "חן", "חליווה", "אלוש" };
          string[] email = { "@gmail.com", "@hotmail.com" };
          string rndName = arrFirstName[rnd.Next(0, arrFirstName.Length - 1)];
          string rndLastName = arrLastName[rnd.Next(0, arrLastName.Length - 1)];
          string rndEmail = "ConvertedName" + email[rnd.Next(0, email.Length - 1)];
          int rndID = rnd.Next(111111111, 999999999);
          int rndphoneNum = 50000000 + rnd.Next(0000000, 9999999);
          int rndAvrage = rnd.Next(0, 500)/5;

          //avrage testsing
          Assert.IsTrue(rndAvrage<=100);
          Assert.IsTrue(rndAvrage>= 0);
          //FirstName testsing
          Assert.IsTrue(rndName == "אוראל" || rndName == "גיא" || rndName == "חליווה");
          Assert.IsFalse(rndName == "");
          //Lastname testsing
          Assert.IsTrue(rndLastName == "חן" || rndLastName == "חליווה" || rndLastName == "אלוש");
          Assert.IsFalse(rndLastName == "");
          //ID testing
          Assert.IsTrue(rndID <= 999999999);
          Assert.IsTrue(rndID >= 111111111);
          //Phonenumber testing
          Assert.IsTrue(rndID <= 59999999);
          Assert.IsTrue(rndID >= 50000000);
          //Email testing
          Assert.IsTrue(rndName == "ConvertedName@gmail.com" || rndName == "ConvertedName@hotmail.com");
          Assert.IsFalse(rndName == "");


        }

        [TestMethod()]
        public void ConvertToEnglishTest()
        {





            Assert.Fail();
        }
    }
}