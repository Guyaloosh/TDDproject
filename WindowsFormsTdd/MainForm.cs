using System;
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
            IDErrorLable.Visible = false;
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

        bool CheckName(string FN,string LN) {

            foreach (char letter in FN)
            {
                if (char.IsNumber(letter)|| char.IsSeparator(letter) || char.IsControl(letter)) 
                {
                    NameErrorLable.Visible = true;
                    return false; }
                else NameErrorLable.Visible = false;
            }
           
            foreach (char letter in LN)
            {
                if (char.IsNumber(letter)|| char.IsSeparator(letter)|| char.IsControl(letter)) {

                    LastNameErrorLable.Visible = true;
                    return false; }
                else LastNameErrorLable.Visible = false;

            }
            return true;
        }
        bool CheckID(string ID) {

            foreach (char letter in ID)
            {
                if (char.IsLetter(letter) || char.IsSeparator(letter) || char.IsControl(letter) || ID.Length != 9)
                {
                    IDErrorLable.Visible = true;
                    return false;
                }
                else IDErrorLable.Visible = false;
            }
            return true;
        }
        bool Checkmail(string email) {
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
        bool CheckPhone(string ph)
        {

            foreach (char letter in ph)
            {
                if (char.IsLetter(letter) || char.IsSeparator(letter) || char.IsControl(letter) || ph.Length != 10)
                {
                    PhoneErrorLable.Visible = true;
                    return false;
                }
                else PhoneErrorLable.Visible = false;
            }
            return true;
        }
        private void AddStudentBtn_Click(object sender, EventArgs e)
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


            int numofcourses = 5;
            /*
            if (int.Parse(PhysicsTextBox.Text) == 777) { numofcourses--;}
            if (int.Parse(MathTextBox.Text) == 777) { numofcourses--; }
            if (int.Parse(SoftwereTextBox.Text) == 777) { numofcourses--; }
            if (int.Parse(EnglishTextBox.Text) == 777) { numofcourses--; }
            if (int.Parse(HebrewTextBox.Text) == 777) { numofcourses--; }
            */
            int Avrage = 0 +
                (int.Parse(PhysicsTextBox.Text)+
                int.Parse(MathTextBox.Text) +
                int.Parse(SoftwereTextBox.Text) +
                int.Parse(EnglishTextBox.Text) +
                int.Parse(HebrewTextBox.Text))/ numofcourses
                ;

            if (nameok && idok && Emailok && phoneok)
            {
                string[] newuser = { Avrage.ToString(), phoneNum.ToString(), Email, ID.ToString(), Name + " " + LastName };
                ListViewItem student = new ListViewItem(newuser);
                StudentView1.Items.Add(student);
                errorlable.Visible = false;
                SortBtn.Visible = true;
                clearMainForm();
            }
            else {
                errorlable.Visible = true; }
        }

       

        public string ConvertToEnglish(string Name) {

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
        public string[] GenerateRandomStudent(Random rnd) {

            //Firstnames list
            string[] arrFirstName = { "אוראל", "גיא","יונתן","גבי" , "גדעון","גד" , "גדליהו" , "גולן","גומא","גורן" ,
                "גיורא","גילי","גלבוע" , "גמליאל","גל","גפן" , "גלעד","אמרי","אנדי" , "אסף","אפרים","אסי" , "אראל","אריה","ארתור",
                "ארנון" , "אפרים","אסיף","תמר","דב", "דביר", "דגן", "דוד", "דודו", "דודי", "דולב", "דור"," דוראל", "דורון", "דורי",
                "דותן", "דן", "דני"," דקל", "דראל", "דרור","הדר", "הללי", "הלליה", "הראל" ,"זאב", "זבולון", "זוהר", "זיו ", "חגי",
                "חזי", "חיים", "חן", "חני", "חניאל", "חננאל", "חנניה", "חפר", "טהר", "טוביה", "טל", "טניה","רותם","תום","נחמיה",
                "ישראל","איתי","ים" , "רוני","ירין", "תהל","נטע","בר","שיר" , "מיתר","זינה","רונה" , "מירן","שני","יאיר", "יגאל", "יגיל",
                "ידידיה", "ידין", "יהב", "יהודה", "יהונתן", "יהושע", "יואב", "יובל","יוחאי", "יונתן" };


            //Lastnames list
            string[] arrLastName = {"כהן","לוי","מזרחי", "פרץ", "ביטון", "פרידמן","אברהם", "דהן", "כץ",
               "אזולאי", "מלכה", "דוד", "חדד", "עמר", "אוחיון", "גבאי", "יוסף", "קליין", "לוין", "שפירא",
               "מועלם", "פריד", "גוטליב", "הירש", "ברכה", "מרדכי", "וולף", "אוזן", "שאול", "דגן" , "הורוביץ", "דויטש", "אביטבול",
               "סגל","אשכנזי","חזן","שורץ","רוזנברג","אוחנה","שטרן","גרינברג","בר","גולן","אלבז","גולדשטיין","סויסה","דיין","אטיאס",
               "שרעבי","לביא","ששון","ברוך","פלדמן","חמו","ממן","עובדיה","מימון","גולדברג","אסולין","אלון","וקנין","רובין","רבינוביץ",
               "אמסלם","שוורץ","עזרא","הרשקוביץ","ברקוביץ","סבג","קדוש","ישראל","יפרח","מילר","שמואלי","נעים","אברהמי","ברנשטיין","נוימן","פנחס","סבן",
               "עטיה","קוגן","הופמן","אילוז","קרן","בוזגלו","שקד","זינגר","צברי","יונה","גרוסמן","רובינשטיין","תורג'מן","בן סימון","אשר","שיטרית","חמו",
               "טויטו","בראון","כחלון","פרי","ארביב","ברמן","שגב","שדה","בוסקילה","אלימלך","פינטו"};

            //emails list
            string[] email = { "@gmail.com", "@hotmail.com", "@ac.sce.il", "@ynet.com", "@walla.co.il", "@Isr.il", "@gov.ie.il" };



            string rndName = arrFirstName[rnd.Next(0, arrFirstName.Length - 1)];
            string rndLastName = arrLastName[rnd.Next(0, arrLastName.Length - 1)];
            string rndEmail = ConvertToEnglish(rndName) + rnd.Next(000, 100).ToString() + email[rnd.Next(0, email.Length - 1)];
            int rndID = rnd.Next(111111111, 999999999);
            int rndphoneNum = 50000000 + rnd.Next(0000000, 9999999);
            int rndAvrage = rnd.Next(50, 500)/5;
           
            
            //generate a listview Data string-  avrage / phonenumber / email / ID / full name

            string[] RandomData = { rndAvrage.ToString(), "0" + rndphoneNum.ToString(), rndEmail, rndID.ToString(), rndName + " " + rndLastName };
            
            return RandomData;
        }


        //generate 1000 random student btn
        public void addRandomBtn_Click(object sender, EventArgs e)
        {
            clearMainForm();
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                SortBtn.Visible = true;
                string[] ListviewData = GenerateRandomStudent(rnd);
                ListViewItem student = new ListViewItem(ListviewData);
                StudentView1.Items.Add(student);
            }
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

        private void SortBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
