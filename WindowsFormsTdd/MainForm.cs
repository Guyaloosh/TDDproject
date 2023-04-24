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

        public void addRandomBtn_Click(object sender, EventArgs e)
        {
            clearMainForm();
            string[] arrFirstName = { "אורטל", "רותם","יונתן","גבי" , "גדעון","גד" , "גדליהו" , "גולן","גומא","גורן" ,
                "גיורא","גילי","גלבוע" , "גמליאל","גל","גפן" , "גלעד","אמרי","אנדי" , "אסף","אפרים","אסי" , "אראל","אריה","ארתור",
                "ארנון" , "אפרים","אסיף","תמר","דב", "דביר", "דגן", "דוד", "דודו", "דודי", "דולב", "דור"," דוראל", "דורון", "דורי",
                "דותן", "דן", "דני"," דקל", "דראל", "דרור","הדר", "הללי", "הלליה", "הראל","זאב", "זבולון", "זוהר", "זיו ", "חגי",
                "חזי", "חיים", "חן", "חני", "חניאל", "חננאל", "חנניה", "חפר", "טהר", "טוביה", "טל", "טניה","גיא","תום","נחמיה",
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



            string[] email = { "hen@gmail.com", "orel@gmail.com", "guyaloosh@gmail.com", "orelhen@gmail.com", "guyhalliva@gmail.com", "alush@gmail.com", "haliva@gmail.com" };
            string[] address = { "Beer Sheva", "Omer", "Meitar", "Eilat", "Rishon Letzion", "Tel Aviv", "Gedera", "Lehavim" };
            string[] phone_number = { "0501234569", "0501234561", "0501234523", "0501234559", "0501234554", "0501234589", "0501234505", "0501234532" };
            Random rnd = new Random();

            for (int i = 0; i < 10000; i++)
            {
                int rndID = rnd.Next(111111111, 999999999);
                int rndAvrage = rnd.Next(000, 100);
                int nameIndex = rnd.Next(0, arrFirstName.Length - 1);
                int lastNameIndex = rnd.Next(0, arrLastName.Length - 1);
                int emailIndex = rnd.Next(0, email.Length - 1);
                int addressIndex = rnd.Next(0, address.Length - 1);
                int phone_numberIndex = rnd.Next(0, phone_number.Length - 1);

                string rndName = arrFirstName[nameIndex];
                string rndLastName = arrLastName[lastNameIndex];
                string rndEmail = email[emailIndex];
                string rndaddress = address[addressIndex];
                string rndphone_number = phone_number[phone_numberIndex];


                //add random data to list view  --  avaragge,phone number, email ,id and fullname
                string[] ListviewData = {rndAvrage.ToString() ,rndphone_number , rndEmail, rndID.ToString(),rndName + " " + rndLastName};
                //string[] data2 = { rndEmail, rndaddress, rndphone_number };

                ListViewItem student = new ListViewItem(ListviewData);
                StudentView1.Items.Add(student);
               
            }
        }
    }
}
