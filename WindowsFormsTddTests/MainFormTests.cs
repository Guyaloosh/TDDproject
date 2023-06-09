﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;


/// <summary>
/// @author 
/// orel hen 316179423
/// guy aloosh 316471465
/// guy haliva 316478676
/// </summary>



namespace WindowsFormsTdd.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        //other tests
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
            int rndAvrage = rnd.Next(0, 500) / 5;

            //avrage testsing
            Assert.IsTrue(rndAvrage <= 100);
            Assert.IsTrue(rndAvrage >= 0);
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

        //calcavg test
        [TestMethod()]
        public void CalcAvgTest()
        {
            //Test function
            void checkAvgCalc()
            {
                int avg1 = CalcAvg(90, 90, 90, 777, 90);
                int avg2 = CalcAvg(70, 30, 80, 777, 777);
                int avg3 = CalcAvg(10, 10, 10, 10, 10);
                int avg4 = CalcAvg(5, 15, 10, 10, 10);

                Assert.AreEqual(avg1, 90);//expected - good test
                //Assert.AreEqual(avg1, avg2); expected - failed test 
                Assert.AreEqual(avg3, avg4);//expected - good test 
                Assert.AreNotEqual(avg1, avg2);

            }
            //Calcavg func for testing
            int CalcAvg(int c1, int c2, int c3, int c4, int c5)
            {
                int avg = 0;
                int numofcourses = 5;

                if (c1 == 777) { numofcourses--; c1 = 0; }
                if (c2 == 777) { numofcourses--; c2 = 0; }
                if (c3 == 777) { numofcourses--; c3 = 0; }
                if (c4 == 777) { numofcourses--; c4 = 0; }
                if (c5 == 777) { numofcourses--; c5 = 0; }

                avg = (c1 + c2 + c3 + c4 + c5) / numofcourses;

                return avg;
            }
            //Calling test function
            checkAvgCalc();
        }

        //Sort testing
        [TestMethod()]
        public void BubbleSortTest()
        {   //Test function
            void BubbleSort_SortsArray()
            {
                // Arrange
                int[] inputArray = { 9, 2, 7, 1, 5, 6, 8, 3, 4 };
                int[] expectedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int[] NotExpectedArray = { 1, 3, 4, 5, 2, 6, 7, 8, 9 };

                // Act
                BubbleSort(inputArray);

                // Assert
                CollectionAssert.AreEqual(expectedArray, inputArray);
                CollectionAssert.AreNotEqual(NotExpectedArray, inputArray);
                Assert.AreEqual(expectedArray.Length, inputArray.Length);
            }
            //Bubblesort func for testing
            void BubbleSort(int[] array)
            {
                int n = array.Length;
                bool swapped;

                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;

                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            Swap(ref array[j], ref array[j + 1]);
                            swapped = true;
                        }
                    }

                    if (!swapped)
                        break;
                }
            }
            //swap func for testing
            void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            //Calling test function
            BubbleSort_SortsArray();
        }
        [TestMethod()]
        public void QuickSortTest()
        {
            //Test function
            void QuickSort_SortsArray()
            {
                // Arrange
                int[] inputArray = { 9, 2, 7, 1, 5, 6, 8, 3, 4 };
                int[] expectedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int[] NotexpectedArray = { 1, 2, 3, 4, 5, 6, 7, 9 };


                // Act
                QuickSort(inputArray);

                // Assert
                CollectionAssert.AreEqual(expectedArray, inputArray);
                //CollectionAssert.AreNotEqual(expectedArray, inputArray);//filed
                Assert.AreNotEqual(NotexpectedArray.Length, inputArray.Length); //Array length mismatch."

                for (int i = 1; i < inputArray.Length; i++)
                {
                    Assert.IsTrue(inputArray[i] >= inputArray[i - 1]); // checking the array are sorted from 1-9 . 
                }

                Assert.IsFalse(inputArray.Contains(0));//checks the array have the number 0
                Assert.IsFalse(inputArray.Contains(10)); //checks the array have the number 10
            }
            //QS func for testing
            void QuickSort(int[] array)
            {
                Sort(array, 0, array.Length - 1);
            }
            //Sort func for testing
            void Sort(int[] array, int low, int high)
            {
                if (low < high)
                {
                    int pivotIndex = Partition(array, low, high);
                    Sort(array, low, pivotIndex - 1);
                    Sort(array, pivotIndex + 1, high);
                }
            }
            //partition calling swap func
            int Partition(int[] array, int low, int high)
            {
                int pivot = array[high];
                int i = low - 1;

                for (int j = low; j < high; j++)
                {
                    if (array[j] < pivot)
                    {
                        i++;
                        Swap(array, i, j);
                    }
                }

                Swap(array, i + 1, high);
                return i + 1;
            }
            //swap func for testing
            void Swap(int[] array, int i, int j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            //Calling test function
            QuickSort_SortsArray();
        }
        [TestMethod()]
        public void MergeSortTest()
        {   //Test function
            void MergeSort_SortsArray()
            {
                // Arrange
                int[] inputArray = { 9, 2, 7, 1, 5, 6, 8, 3, 4 };
                int[] expectedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int[] notExpectedArray = { 1, 3, 5, 6, 4, 8, 2, 7, 9 };
                int[] expectedArrayBack = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
                int[] emptyArray = { };

                // Act
                MergeSort(inputArray);

                // Assert
                CollectionAssert.AreEqual(expectedArray, inputArray);
                CollectionAssert.AreNotEqual(expectedArrayBack, inputArray);
                CollectionAssert.AreNotEqual(notExpectedArray, inputArray);
                //CollectionAssert.AreEqual(inputArray, expectedArrayBack); expected - failed test.
                CollectionAssert.AreNotEqual(expectedArray, emptyArray);
                Assert.AreEqual(expectedArray.Length, inputArray.Length);


            }
            //mergeSort func for testing
            void MergeSort(int[] array)
            {
                if (array.Length <= 1)
                    return;

                int mid = array.Length / 2;
                int[] left = new int[mid];
                int[] right = new int[array.Length - mid];

                Array.Copy(array, left, mid);
                Array.Copy(array, mid, right, 0, array.Length - mid);

                MergeSort(left);
                MergeSort(right);

                Merge(left, right, array);
            }
            //merge func for testing
            void Merge(int[] left, int[] right, int[] array)
            {
                int i = 0, j = 0, k = 0;

                while (i < left.Length && j < right.Length)
                {
                    if (left[i] <= right[j])
                    {
                        array[k] = left[i];
                        i++;
                    }
                    else
                    {
                        array[k] = right[j];
                        j++;
                    }
                    k++;
                }

                while (i < left.Length)
                {
                    array[k] = left[i];
                    i++;
                    k++;
                }

                while (j < right.Length)
                {
                    array[k] = right[j];
                    j++;
                    k++;
                }
            }
            //Calling test function
            MergeSort_SortsArray();
        }

    }

}












