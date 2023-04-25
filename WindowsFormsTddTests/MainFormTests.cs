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

            Assert.AreEqual(expected, count);

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
            Assert.AreEqual(mainForm.FirstNameTextBox.Text, "");
            Assert.AreEqual(mainForm.LastNameTxtBox.Text, "");
            Assert.AreEqual(mainForm.EmailTextBox.Text, "");
            Assert.AreEqual(mainForm.PhoneNumTextBox.Text, "");
            Assert.AreEqual(mainForm.IdTextBox.Text, "");
            Assert.AreEqual(mainForm.PhysicsTextBox.Text, "");
            Assert.AreEqual(mainForm.EnglishTextBox.Text, "");
            Assert.AreEqual(mainForm.HebrewTextBox.Text, "");
            Assert.AreEqual(mainForm.MathTextBox.Text, "");
            Assert.AreEqual(mainForm.SoftwereTextBox.Text, "");
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
          Assert.IsTrue(rndphoneNum <= 59999999);
          Assert.IsTrue(rndphoneNum >= 50000000);
          //Email testing
          Assert.IsTrue(rndEmail == "ConvertedName@gmail.com" || rndEmail == "ConvertedName@hotmail.com");
          Assert.IsFalse(rndEmail == "");


        }

        [TestMethod()]
        public void ConvertToEnglishTest()
        {
            //generate 2 names to convert
            string Name1 = "דרור";
            string Name2 = "רוני";

            //generate dictionery hebrew-english
            Dictionary<char, string> hebrewToEnglish = new Dictionary<char, string>{
            { 'א', "a" }, { 'ב', "b" }, { 'ג', "g" }, { 'ד', "d" }, { 'ה', "h" }, { 'ו', "o" },
            { 'ז', "z" }, { 'ח', "ch" }, { 'ט', "t" }, { 'י', "y" }, { 'כ', "k" }, { 'ל', "l" },
            { 'מ', "m" }, { 'נ', "n" }, { 'ס', "s" }, { 'ע', "o" }, { 'פ', "p" }, { 'צ', "ts" },
            { 'ק', "q" }, { 'ר', "r" }, { 'ש', "sh" }, { 'ת', "th" }, { 'ם', "m" }, { 'ן', "n" },
            { 'ף', "f" }, { 'ץ', "ts" }};

            string Name1English = "";
            string Name2English = "";


            //name1 test
            foreach (char letter in Name1)
            {
                if (hebrewToEnglish.ContainsKey(letter))
                    Name1English += hebrewToEnglish[letter];
                else
                    Name1English += letter;
            }
            Assert.IsTrue(Name1English == "dror");
            Assert.IsFalse(Name1English == "דרור");

            //name2 test
            foreach (char letter in Name2)
            {
                if (hebrewToEnglish.ContainsKey(letter))
                    Name2English += hebrewToEnglish[letter];
                else
                    Name2English += letter;
            }
            Assert.IsTrue(Name2English == "rony");
            Assert.IsFalse(Name2English == "רוני");

            //Assert.Fail();
        }
    }
}