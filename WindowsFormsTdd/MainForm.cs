using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;







namespace WindowsFormsTdd
{


    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();


        }


        public void clearMainForm()
        {
            //clearing all main Form
            FirstNameTextBox.Clear();
            LastNameTxtBox.Clear();
            EmailTextBox.Clear();
            PhoneNumTextBox.Clear();
            IdTextBox.Clear();
            PhysicsTextBox.Clear();
            EnglishTextBox.Clear();
            HebrewTextBox.Clear();
            MathTextBox.Clear();
            SoftwereTextBox.Clear();

            errorlable.Visible = false;
            PhoneErrorLable.Visible = false;
            EmailErrorLable.Visible = false;
            NameErrorLable.Visible = false;
            LastNameErrorLable.Visible = false;
            IDErrorLable.Visible = false;
            GradesErrorLabel.Visible = false;
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GradesLabels_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //checking First and LastName inputs
        bool CheckName(string FN, string LN)
        {

            foreach (char letter in FN)
            {
                if (char.IsNumber(letter) || char.IsSeparator(letter) || char.IsControl(letter))
                {
                    NameErrorLable.Visible = true;
                    return false;
                }
            }

            foreach (char letter in LN)
            {
                if (char.IsNumber(letter) || char.IsSeparator(letter) || char.IsControl(letter))
                {

                    LastNameErrorLable.Visible = true;
                    return false;
                }


            }
            if (FN == "" || LN == "") { NameErrorLable.Visible = true; LastNameErrorLable.Visible = true; return false; }


            NameErrorLable.Visible = false;
            LastNameErrorLable.Visible = false;
            return true;
        }

        //checking ID input
        bool CheckID(string ID)
        {

            if (confirmOnlyInt(ID))
            {
                IDErrorLable.Visible = true;
                return false;
            }

            if (ID.Length != 9) { IDErrorLable.Visible = true; return false; }

            IDErrorLable.Visible = false;
            return true;
        }

        //checking Email adress input
        bool Checkmail(string email)
        {
            //check for errors - test
            if (string.IsNullOrWhiteSpace(email))
            {
                EmailErrorLable.Visible = true;
                return false;
            }

            int atSymbolIndex = email.IndexOf('@');
            if (atSymbolIndex == -1)
            {
                EmailErrorLable.Visible = true;
                return false;
            }

            int dotIndex = email.LastIndexOf('.');
            if (dotIndex == -1 || dotIndex < atSymbolIndex)
            {
                EmailErrorLable.Visible = true;
                return false;
            }

            string domain = email.Substring(atSymbolIndex + 1);
            if (string.IsNullOrWhiteSpace(domain))
            {
                EmailErrorLable.Visible = true;
                return false;
            }

            string tld = email.Substring(dotIndex + 1);
            if (string.IsNullOrWhiteSpace(tld) || tld.Length < 2 || tld.Length > 3)
            {
                EmailErrorLable.Visible = true;
                return false;
            }

            EmailErrorLable.Visible = false;
            return true;
        }


        //checking Phonenumber inputs 
        bool CheckPhone(string ph)
        {
            if (confirmOnlyInt(ph))
            {
                PhoneErrorLable.Visible = true;
                return false;
            }

            if (ph.Length != 10)
            {
                PhoneErrorLable.Visible = true;
                return false;
            }
            PhoneErrorLable.Visible = false;
            return true;
        }

        //Checking if INput is not only an intiger.
        bool confirmOnlyInt(String C)
        {

            foreach (char letter in C)
            {
                if (char.IsLetter(letter) || char.IsSeparator(letter) || char.IsControl(letter) || char.IsSymbol(letter))
                {
                    return true;
                }
            }

            if (C == "") { return true; }

            //confirm only digits
            foreach (char letter in C)
            {
                if (!char.IsDigit(letter))
                {
                    return true;
                }
            }


            return false;
        }
        //Confirming that Course Grade input Value is ok.
        bool incorrectCval(int c)
        {
            if (c < 0 || c > 100 && c != 777)
                return true;
            else
                return false;
        }

        bool CheckCourses(String C1, String C2, String C3, String C4, String C5)
        {

            //ERROR @
            if (confirmOnlyInt(C1) || confirmOnlyInt(C2) || confirmOnlyInt(C3) || confirmOnlyInt(C4) || confirmOnlyInt(C5)) { GradesErrorLabel.Visible = true; return false; }

            //Converting courses to int
            int c1 = int.Parse(C1);
            int c2 = int.Parse(C2);
            int c3 = int.Parse(C3);
            int c4 = int.Parse(C4);
            int c5 = int.Parse(C5);

            //check courses int value
            if (incorrectCval(c1) || incorrectCval(c2) || incorrectCval(c3) || incorrectCval(c4) || incorrectCval(c5)) { GradesErrorLabel.Visible = true; return false; }

            GradesErrorLabel.Visible = false;
            return true;
        }

        //function that calcs avrage from course inputs.
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




        public string ConvertToEnglish(string Name)
        {

            //Hebrew to english dictionery
            Dictionary<char, string> hebrewToEnglish = new Dictionary<char, string>{
            { 'א', "a" }, { 'ב', "b" }, { 'ג', "g" }, { 'ד', "d" }, { 'ה', "h" }, { 'ו', "o" },
            { 'ז', "z" }, { 'ח', "ch" }, { 'ט', "t" }, { 'י', "y" }, { 'כ', "k" }, { 'ל', "l" },
            { 'מ', "m" }, { 'נ', "n" }, { 'ס', "s" }, { 'ע', "o" }, { 'פ', "p" }, { 'צ', "ts" },
            { 'ק', "q" }, { 'ר', "r" }, { 'ש', "sh" }, { 'ת', "th" }, { 'ם', "m" }, { 'ן', "n" },
            { 'ף', "f" }, { 'ץ', "ts" }};

            string ToEnglish = "";

            foreach (char letter in Name)
            {
                if (hebrewToEnglish.ContainsKey(letter))
                    ToEnglish += hebrewToEnglish[letter];
                else
                    ToEnglish += letter;
            }

            return char.ToUpper(ToEnglish[0]) + ToEnglish.Substring(1);
        }


        //generate random student function
        public string[] GenerateRandomStudent(Random rnd)
        {

            //Firstnames list
               string[] arrFirstName = { "אוראל", "גיא","יונתן","גבי" , "גדעון","גד" , "גדליהו" , "גולן","גומא","גורן" ,
                "גיורא","גילי","גלבוע" , "גמליאל","גל","גפן" , "גלעד","אמרי","אנדי" , "אסף","אפרים","אסי" , "אראל","אריה","ארתור",
                "ארנון" , "אפרים","אסיף","תמר","דב", "דביר", "דגן", "דוד", "דודו", "דודי", "דולב", "דור"," דוראל", "דורון", "דורי",
                "דותן", "דן", "דני"," דקל", "דראל", "דרור","הדר", "הללי", "הלליה", "הראל" ,"זאב", "זבולון", "זוהר", "זיו ", "חגי",
                "חזי", "חיים", "חן", "חני", "חניאל", "חננאל", "חנניה", "חפר", "טהר", "טוביה", "טל", "טניה","רותם","תום","נחמיה",
                "ישראל","איתי","ים" , "רוני","ירין", "תהל","נטע","בר","שיר" , "מיתר","זינה","רונה" , "מירן","שני","יאיר", "יגאל", "יגיל",
                "ידידיה", "ידין", "יהב", "יהודה", "יהונתן", "יהושע", "יואב", "יובל","יוחאי", "יונתן" 
                };


            //Lastnames list
            string[] arrLastName = {"כהן","לוי","מזרחי", "פרץ", "ביטון", "פרידמן","אברהם", "דהן", "כץ",
               "אזולאי", "מלכה", "דוד", "חדד", "עמר", "אוחיון", "גבאי", "יוסף", "קליין", "לוין", "שפירא",
               "מועלם", "פריד", "גוטליב", "הירש", "ברכה", "מרדכי", "וולף", "אוזן", "שאול", "דגן" , "הורוביץ", "דויטש", "אביטבול",
               "סגל","אשכנזי","חזן","שורץ","רוזנברג","אוחנה","שטרן","גרינברג","בר","גולן","אלבז","גולדשטיין","סויסה","דיין","אטיאס",
               "שרעבי","לביא","ששון","ברוך","פלדמן","חמו","ממן","עובדיה","מימון","גולדברג","אסולין","אלון","וקנין","רובין","רבינוביץ",
               "אמסלם","שוורץ","עזרא","הרשקוביץ","ברקוביץ","סבג","קדוש","ישראל","יפרח","מילר","שמואלי","נעים","אברהמי","ברנשטיין","נוימן","פנחס","סבן",
               "עטיה","קוגן","הופמן","אילוז","קרן","בוזגלו","שקד","זינגר","צברי","יונה","גרוסמן","רובינשטיין","תורג'מן","בן סימון","אשר","שיטרית","חמו",
               "טויטו","בראון","כחלון","פרי","ארביב","ברמן","שגב","שדה","בוסקילה","אלימלך","פינטו"
            };

            //emails list
            string[] email = { "@gmail.com", "@hotmail.com", "@ac.sce.il", "@ynet.com", "@walla.co.il", "@Isr.il", "@gov.ie.il" };



            string rndName = arrFirstName[rnd.Next(0, arrFirstName.Length - 1)];
            string rndLastName = arrLastName[rnd.Next(0, arrLastName.Length - 1)];
            string rndEmail = ConvertToEnglish(rndName) + rnd.Next(000, 100).ToString() + email[rnd.Next(0, email.Length - 1)];
            int rndID = rnd.Next(111111111, 999999999);
            int rndphoneNum = 50000000 + rnd.Next(0000000, 9999999);

            int rndc1 = rnd.Next(0, 110); if (rndc1 > 100) rndc1 = 777;
            int rndc2 = rnd.Next(0, 110); if (rndc2 > 100) rndc2 = 777;
            int rndc3 = rnd.Next(0, 110); if (rndc3 > 100) rndc3 = 777;
            int rndc4 = rnd.Next(0, 110); if (rndc4 > 100) rndc4 = 777;
            int rndc5 = rnd.Next(0, 110); if (rndc5 > 100) rndc5 = 777;

            String Avrage = CalcAvg(rndc1, rndc2, rndc3, rndc4, rndc5).ToString();


            //generate a listview Data string-  avrage / phonenumber / email / ID / full name

            string[] RandomData = { Avrage, rndc5.ToString(), rndc4.ToString(), rndc3.ToString(), rndc2.ToString(), rndc1.ToString(), "0" + rndphoneNum.ToString(), rndEmail, rndID.ToString(), rndName + " " + rndLastName };

            return RandomData;
        }




        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cleanbtn_Click(object sender, EventArgs e)
        {
            clearMainForm();
        }




        private void PhoneErrorLable_Click(object sender, EventArgs e)
        {

        }




        private void AddStudentBtn1_Click(object sender, EventArgs e)
        {

            string Name = FirstNameTextBox.Text;
            string LastName = LastNameTxtBox.Text;
            bool nameok = CheckName(Name, LastName);

            string ID = IdTextBox.Text;
            bool idok = CheckID(ID);

            string Email = EmailTextBox.Text;
            bool Emailok = Checkmail(Email);


            string phoneNum = PhoneNumTextBox.Text;
            bool phoneok = CheckPhone(phoneNum);

            bool courseok = CheckCourses(PhysicsTextBox.Text, MathTextBox.Text, SoftwereTextBox.Text, EnglishTextBox.Text, HebrewTextBox.Text);


            if (nameok && idok && Emailok && phoneok && courseok)
            {
                String Avrage = CalcAvg(int.Parse(PhysicsTextBox.Text), int.Parse(MathTextBox.Text), int.Parse(SoftwereTextBox.Text), int.Parse(EnglishTextBox.Text), int.Parse(HebrewTextBox.Text)).ToString();
                string[] newuser = { Avrage, SoftwereTextBox.Text, PhysicsTextBox.Text, HebrewTextBox.Text, EnglishTextBox.Text, MathTextBox.Text, phoneNum.ToString(), Email, ID.ToString(), Name + " " + LastName };
                ListViewItem student = new ListViewItem(newuser);
                StudentView1.Items.Add(student);
                errorlable.Visible = false;
                SortBtn1.Visible = true;
                clearMainForm();
            }
            else
            {
                errorlable.Visible = true;
            }
        }

        //generate 1000 random student btn
        private void addRandomBtn1_Click(object sender, EventArgs e)
        {
            clearMainForm();
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                string[] ListviewData = GenerateRandomStudent(rnd);
                ListViewItem student = new ListViewItem(ListviewData);
                StudentView1.Items.Add(student);
            }
            SortBtn1.Visible = true;
        }


     public void BubbleSort(List<ListViewItem> items)
     {
         bool swapped;
         int n = items.Count;
         do
         {
             swapped = false;
             for (int i = 1; i < n; i++)
             {
                 if (int.Parse(items[i - 1].SubItems[0].Text) > int.Parse(items[i].SubItems[0].Text))
                 {
                     ListViewItem temp = items[i - 1];
                     items[i - 1] = items[i];
                     items[i] = temp;
                     swapped = true;
                 }
             }
               n--;
         } while (swapped);
     }




    //-------------------------------------------------------------------------------------------------//

    // sort button using merge sort . 
     public void SortBtn1_Click(object sender, EventArgs e)
     {
      // Create a list of the ListView items
        List<ListViewItem> items = new List<ListViewItem>();
        
        foreach (ListViewItem item in StudentView1.Items)
        {
            items.Add(item);
        }

            // Sort the list of items by the first column using Merge Sort

            int start = DateTime.Now.Millisecond;

            //BubbleSort(items);

            MergeSort(items, 0, items.Count - 1);
            int end = DateTime.Now.Millisecond;
  

            // Clear the ListView items and add the sorted items back in

            StudentView1.Items.Clear();
            StudentView1.Items.AddRange(items.ToArray());
            string message = string.Format("Sorting took {0} milliseconds.", end - start);
            MessageBox.Show(message);
     }


        public void MergeSort(List<ListViewItem> items, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(items, left, middle);
                MergeSort(items, middle + 1, right);
                Merge(items, left, middle, right);
            }
        }

        public void Merge(List<ListViewItem> items, int left, int middle, int right)
        {
            int leftIndex = left;
            int rightIndex = middle + 1;
            List <ListViewItem> merged = new List<ListViewItem>();
            while (leftIndex <= middle && rightIndex <= right)
            {
                double leftValue, rightValue;
                if (double.TryParse(items[leftIndex].SubItems[0].Text, out leftValue) &&
                    double.TryParse(items[rightIndex].SubItems[0].Text, out rightValue))
                {
                    if (leftValue > rightValue)
                    {
                        merged.Add(items[leftIndex]);
                        leftIndex++;
                    }
                    else
                    {
                        merged.Add(items[rightIndex]);
                        rightIndex++;
                    }
                }
                else
                {
                    // If the values can't be parsed as doubles, compare the string representations
                    if (items[leftIndex].SubItems[0].Text.CompareTo(items[rightIndex].SubItems[0].Text) > 0)
                    {
                        merged.Add(items[leftIndex]);
                        leftIndex++;
                    }
                    else
                    {
                        merged.Add(items[rightIndex]);
                        rightIndex++;
                    }
                }
            }
            while (leftIndex <= middle)
            {
                merged.Add(items[leftIndex]);
                leftIndex++;
            }
            while (rightIndex <= right)
            {
                merged.Add(items[rightIndex]);
                rightIndex++;
            }
            for (int i = 0; i < merged.Count; i++)
            {
                items[left + i] = merged[i];
            }
        }
    }
}
