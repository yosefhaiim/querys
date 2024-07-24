using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics.Eventing.Reader;

namespace querys
{
    public partial class Form1 : Form
    {
        // יצירת מסמך XML
        XmlDocument xmlDocument;
        // הכרזה על נתיב בו ימצא הקובץ ושמו של הקובץ
        string pathName = Directory.GetCurrentDirectory() + "\\drinkData.xml";
        // הכרזת משתנה שיהיה נגיש בכל מקום
        XmlNode root;


        public Form1()
        {
            InitializeComponent();
            loadDocoment();
        }
        public void loadDocoment()
        {
            // הכרזה על מסמך אקסאמאל חדש  
            xmlDocument = new XmlDocument();
            // בדיקה אם המסמך קיים בנתיב שהוגדר מראש
            if (File.Exists(pathName))
            {
                try
                {
                    // נסיון לטעון את המסמך
                    xmlDocument.Load(pathName);
                }
                // במידה וזה נכשל מחזירים מה השגיאה
                catch (Exception ex)
                {
                    MessageBox.Show("Eror loading xml file " + ex.Message);
                }
            }
            else
            {
                // אם הוא לא קיים יוצרים אותו עכשיו, כאלמנט.
                // ומכניסים את ה"תוכן" שלו לתוך המשתנה רות
                root = xmlDocument.CreateElement("querys");
                // כעת אני מוסיף למסמך את האלמנט שיצרנו מה שנקרא שורש
                xmlDocument.AppendChild(root);
                // עכשיו אני שומר את המסמך בחזרה במיקום שממנו טענתי אותו קודם
                xmlDocument.Save(pathName);
            }
        }



        private bool CreateQuery(XmlNode root)
        {
            if(cmbDayInMonth.Text == "" || cmbDayInWeek.Text == "" || cmbMonth.Text == "" || cmbYear.Text == "")
            {
                MessageBox.Show("אחד השדות ריקים אנא בדוק ומלא");
                return false;
            }

            string temp = "";
            switch (cmbYear.Text)
            {
                case "תשפ''ד":
                    temp = "בשנת חמשת אלפים ושבע מאות ושמונים וארבע";
                    break;
                case "תשפ''ה":
                    temp = "בשנת חמשת אלפים ושבע מאות ושמונים וחמש";
                    break;
                case "תשפ''ו":
                    temp = "בשנת חמשת אלפים ושבע מאות ושמונים ושש";
                    break;
                case "תשפ''ז":
                    temp = "בשנת חמשת אלפים ושבע מאות ושמונים ושבע";
                    break;
                case "תשפ''ח":
                    temp = "בשנת חמשת אלפים ושבע מאות ושמונים ושמונה";
                    break;
                case "תשפ''ט":
                    temp = "בשנת חמשת אלפים ושבע מאות ושמונים ותשע";
                    break;
            }

            // בדיקה האם החודש מלא

            if (cmbDayInMonth.Text == "יום שלושים לחודש")
            {
                string nextMonth = "";
                switch (cmbMonth.Text)
                {

                    case "תשרי":
                        nextMonth = "מרחשון";
                        break;
                    case "מרחשון":
                        nextMonth = "כסלו";
                        break;
                    case "כסלו":
                        nextMonth = "טבת";
                        break;
                    case "טבת":
                        nextMonth = "שבט";
                        break;
                    case "אדר הראשון":
                        nextMonth = "אדר השני";
                        break;
                    case "ניסןי":
                        nextMonth = "אייר";
                        break;
                    case "סיון":
                        nextMonth = "תמוז";
                        break;
                    case "אב":
                        nextMonth = "אלול";
                        break;
                    default:
                        MessageBox.Show("החודש הזה חסר, אנא בדוק ותקן");
           
                        return false;
                }
                

                lblTheAll.Text = cmbDayInWeek.Text + " "
                    + cmbDayInMonth.Text + " "
                    + cmbMonth.Text + " "
                    + "שהוא ראש חודש" + " "
                     + nextMonth + " " + temp;
            }
            else
            {
                lblTheAll.Text = cmbDayInWeek.Text + " "
                    + cmbDayInMonth.Text + " "
                    + cmbMonth.Text + " "
                    + temp;
            }

            try
            {
                // יצירת מסמך אקסמאל
                XmlNode query = xmlDocument.CreateElement("drink");
                // בניית השאילתה
                query.AppendChild(xmlDocument.CreateElement("name")).InnerText = cmbDayInWeek.Text;
                query.AppendChild(xmlDocument.CreateElement("sugar")).InnerText = cmbDayInMonth.Text;
                query.AppendChild(xmlDocument.CreateElement("cofee")).InnerText = cmbMonth.Text;
                query.AppendChild(xmlDocument.CreateElement("cocoa")).InnerText = cmbYear.Text;
                query.AppendChild(xmlDocument.CreateElement("TheAllQuery")).InnerText = lblTheAll.Text;


                // יצירה של השאילתה             
                xmlDocument.FirstChild.AppendChild(query);
                xmlDocument.Save(pathName);      
                MessageBox.Show("השאילתה נוצרה בהצלחה");
                ShowoTheQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }



        private void ShowoTheQuery()
        {
            
            foreach (XmlNode query in xmlDocument.FirstChild.ChildNodes)
            {
                string dayInWeek = "", dayInmonth = "", month = "", year = "";

                foreach (XmlNode node in query.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "dayInWeek":
                            dayInWeek = node.InnerText;
                            break;

                        case "dayInmonth":
                            dayInmonth = node.InnerText;
                            break;

                        case "month":
                            month = node.InnerText;
                            break;

                        case "year":
                            year = node.InnerText;
                            break;
                    }
                }
                lblTheAll.Text = "";
            }
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            CreateQuery(root);
            
        }
    }
}
