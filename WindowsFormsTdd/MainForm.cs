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



        private void clearMainForm()
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

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {

        }

        public string ConvertToEnglish(string Name) {

            //Hebrew to english dictionery
            Dictionary<char, string> hebrewToEnglish = new Dictionary<char, string>{
            { 'א', "a" }, { 'ב', "b" }, { 'ג', "g" }, { 'ד', "d" }, { 'ה', "h" }, { 'ו', "v" },
            { 'ז', "z" }, { 'ח', "ch" }, { 'ט', "t" }, { 'י', "y" }, { 'כ', "k" }, { 'ל', "l" },
            { 'מ', "m" }, { 'נ', "n" }, { 'ס', "s" }, { 'ע', "o" }, { 'פ', "p" }, { 'צ', "ts" },
            { 'ק', "q" }, { 'ר', "r" }, { 'ש', "sh" }, { 'ת', "th" }, { 'ם', "m" }, { 'ן', "n" },
            { 'ף', "p" }, { 'ץ', "ts" }};

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
        public string[] GenerateRandom(Random rnd) {


            string[] arrFirstName = { "אוראל", "גיא","יונתן","גבי" , "גדעון","גד" , "גדליהו" , "גולן","גומא","גורן" ,
                "גיורא","גילי","גלבוע" , "גמליאל","גל","גפן" , "גלעד","אמרי","אנדי" , "אסף","אפרים","אסי" , "אראל","אריה","ארתור",
                "ארנון" , "אפרים","אסיף","תמר","דב", "דביר", "דגן", "דוד", "דודו", "דודי", "דולב", "דור"," דוראל", "דורון", "דורי",
                "דותן", "דן", "דני"," דקל", "דראל", "דרור","הדר", "הללי", "הלליה", "הראל" ,"זאב", "זבולון", "זוהר", "זיו ", "חגי",
                "חזי", "חיים", "חן", "חני", "חניאל", "חננאל", "חנניה", "חפר", "טהר", "טוביה", "טל", "טניה","רותם","תום","נחמיה",
                "ישראל","איתי","ים" , "רוני","ירין", "תהל","נטע","בר","שיר" , "מיתר","זינה","רונה" , "מירן","שני","יאיר", "יגאל", "יגיל",
                "ידידיה", "ידין", "יהב", "יהודה", "יהונתן", "יהושע", "יואב", "יובל","יוחאי", "יונתן" };


            string[] arrLastName = {"כהן","לוי","מזרחי", "פרץ", "ביטון", "פרידמן","אברהם", "דהן", "כץ",
               "אזולאי", "מלכה", "דוד", "חדד", "עמר", "אוחיון", "גבאי", "יוסף", "קליין", "לוין", "שפירא",
               "מועלם", "פריד", "גוטליב", "הירש", "ברכה", "מרדכי", "וולף", "אוזן", "שאול", "דגן" , "הורוביץ", "דויטש", "אביטבול",
               "סגל","אשכנזי","חזן","שורץ","רוזנברג","אוחנה","שטרן","גרינברג","בר","גולן","אלבז","גולדשטיין","סויסה","דיין","אטיאס",
               "שרעבי","לביא","ששון","ברוך","פלדמן","חמו","ממן","עובדיה","מימון","גולדברג","אסולין","אלון","וקנין","רובין","רבינוביץ",
               "אמסלם","שוורץ","עזרא","הרשקוביץ","ברקוביץ","סבג","קדוש","ישראל","יפרח","מילר","שמואלי","נעים","אברהמי","ברנשטיין","נוימן","פנחס","סבן",
               "עטיה","קוגן","הופמן","אילוז","קרן","בוזגלו","שקד","זינגר","צברי","יונה","גרוסמן","רובינשטיין","תורג'מן","בן סימון","אשר","שיטרית","חמו",
               "טויטו","בראון","כחלון","פרי","ארביב","ברמן","שגב","שדה","בוסקילה","אלימלך","פינטו"};


            string[] email = { "@gmail.com", "@hotmail.com", "@ac.sce.il", "@ynet.com", "@walla.co.il", "@Isr.il", "@gov.ie.il" };


            int rndID = rnd.Next(111111111, 999999999);
            int rndphoneNum = 50000000 + rnd.Next(0000000, 9999999);
            int rndAvrage = rnd.Next(000, 100);
            string rndName = arrFirstName[rnd.Next(0, arrFirstName.Length - 1)];
            string rndLastName = arrLastName[rnd.Next(0, arrLastName.Length - 1)];
            string rndEmail = ConvertToEnglish(rndName) + rnd.Next(000, 100).ToString() + email[rnd.Next(0, email.Length - 1)];
            
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
                string[] ListviewData = GenerateRandom(rnd);
                ListViewItem student = new ListViewItem(ListviewData);
                StudentView1.Items.Add(student);
               
            }
        }
    }
}
