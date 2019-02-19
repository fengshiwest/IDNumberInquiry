using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDNumberInquiry
{
    public partial class IDNumberInquiry : Form
    {
        public IDNumberInquiry()
        {
            InitializeComponent();
        }

        private void IDNumberInquiry_Load(object sender, EventArgs e)
        {
            this.IDNumberTextBox.Text = "";
        }

        private void IDNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = false;
            else if (IDNumberTextBox.Text.Length == 17 && (e.KeyChar == 'X' || e.KeyChar == 'x'))
                e.Handled = false;
            else if (e.KeyChar == '\b')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            Boolean flag = validateId();
            if (flag == false)
                return;
            getAge();
            getSex();
            getBirthday();
            getLocation();
        }

        //校验身份证号
        private Boolean validateId()
        {
            Regex regex = new Regex("[1-8][0-9]{5}[0-9]{11}[0-9||X||x]");
            if (regex.IsMatch(IDNumberTextBox.Text))
            {
                //出生年月
                String date = IDNumberTextBox.Text.Substring(6, 8);
                try
                {
                    DateTime dt = DateTime.ParseExact(date, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                }
                catch
                {
                    MessageBox.Show("身份证号出生年月编码" + date + "有误", "错误");
                    return false;
                }
                //第十八位校验码
                int[] w = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
                int sum = 0;
                char[] charArray = IDNumberTextBox.Text.ToCharArray();
                for (int i = 0; i < w.Length; i++)
                {
                    sum += (charArray[i] - '0') * w[i];
                }
                char[] ch = { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2' };
                int c = sum % 11;
                char code = ch[c];
                char last = charArray[17];
                last = last == 'x' ? 'X' : last;
                if (!(last == code))
                {
                    DialogResult result = MessageBox.Show("第十八位校验码错误，是否自动更正？", "错误", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        IDNumberTextBox.Text = IDNumberTextBox.Text.Substring(0, 17) + code.ToString();
                        return true;
                    }
                }
                MessageBox.Show("身份证号正确", "填写正确");
                return true;
            }
            else
            {
                MessageBox.Show("身份证号错误", "填写错误");
                return false;
            }
        }

        private void getAge()
        {
            try
            {
                String date = IDNumberTextBox.Text.Substring(6, 8);
                DateTime dt = DateTime.ParseExact(date, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                int intAge = Int32.Parse((DateTime.Now.Year).ToString()) - Int32.Parse(dt.Year.ToString());
                if (DateTime.Now.Month < dt.Month || (DateTime.Now.Month == dt.Month && DateTime.Now.Day < dt.Day))
                {
                    intAge--;
                }
                String age = intAge.ToString();
                ageMessageLabel.Text = age.ToString();
            }
            catch
            {
                ageMessageLabel.Text = "暂无信息";
            }
        }

        private void getSex()
        {
            try
            {
                int num = Int32.Parse(IDNumberTextBox.Text.Substring(16, 1));
                num = num % 2;
                if (num == 1)
                    sexMessageLabel.Text = "男";
                else
                    sexMessageLabel.Text = "女";
            }
            catch
            {
                sexMessageLabel.Text = "暂无信息";
            }         
        }

        private void getBirthday()
        {
            try
            {
                String birthday = IDNumberTextBox.Text.Substring(6, 8);
                DateTime dt = DateTime.ParseExact(birthday, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
                DateTime dtNew = ChinaDate.GetSunYearDate(dt);
                birthdayMessageLabel.Text = dt.ToString("yyyy年MM月dd日")+" (农历：" +dtNew.ToString("yyyy年MM月dd日")+")";

            }
            catch
            {
                birthdayMessageLabel.Text = "暂无信息";
            }         
        }

        public class ChinaDate
        {
            private static ChineseLunisolarCalendar china = new ChineseLunisolarCalendar();
            public static DateTime GetSunYearDate(DateTime dt)
            {
                int year = china.GetYear(dt);
                int month = china.GetMonth(dt);
                int day = china.GetDayOfMonth(dt);
                int leapMonth = china.GetLeapMonth(year);
                bool isLeapMonth = month == leapMonth;
                if (leapMonth != 0 && month >= leapMonth)
                    month--;
                string str = string.Format("{0}-{1}-{2}", year, month, day);
                DateTime dtNew = DateTime.Now;
                try
                {
                    dtNew = Convert.ToDateTime(str);
                }
                catch
                {
                    MessageBox.Show("阴阳历转换错误！");
                }
                return dtNew;
            }

        }


        private void getLocation()
        {
            try
            {
                String str = IDNumberTextBox.Text.Substring(0, 2);
                if (str == "11")
                {
                    placeMessageLabel.Text = "北京市";
                }
                else if (str == "12")
                {
                    placeMessageLabel.Text = "天津市";
                }
                else if (str == "13")
                {
                    placeMessageLabel.Text = "河北省";
                }
                else if (str == "14")
                {
                    placeMessageLabel.Text = "山西省";
                }
                else if (str == "15")
                {
                    placeMessageLabel.Text = "内蒙古自治区";
                }
                else if (str == "21")
                {
                    placeMessageLabel.Text = "辽宁省";
                }
                else if (str == "22")
                {
                    placeMessageLabel.Text = "吉林省";
                }
                else if (str == "23")
                {
                    placeMessageLabel.Text = "黑龙江省";
                }
                else if (str == "31")
                {
                    placeMessageLabel.Text = "上海市";
                }
                else if (str == "32")
                {
                    placeMessageLabel.Text = "江苏省";
                }
                else if (str == "33")
                {
                    placeMessageLabel.Text = "浙江省";
                }
                else if (str == "34")
                {
                    placeMessageLabel.Text = "安徽省";
                }
                else if (str == "35")
                {
                    placeMessageLabel.Text = "福建省";
                }
                else if (str == "36")
                {
                    placeMessageLabel.Text = "江西省";
                }
                else if (str == "37")
                {
                    placeMessageLabel.Text = "山东省";
                }
                else if (str == "41")
                {
                    placeMessageLabel.Text = "河南省";
                }
                else if (str == "42")
                {
                    placeMessageLabel.Text = "湖北省";
                }
                else if (str == "43")
                {
                    placeMessageLabel.Text = "湖南省";
                }
                else if (str == "44")
                {
                    placeMessageLabel.Text = "广东省";
                }
                else if (str == "45")
                {
                    placeMessageLabel.Text = "广西省";
                }
                else if (str == "46")
                {
                    placeMessageLabel.Text = "海南省";
                }
                else if (str == "50")
                {
                    placeMessageLabel.Text = "重庆市";
                }
                else if (str == "51")
                {
                    placeMessageLabel.Text = "四川省";
                }
                else if (str == "52")
                {
                    placeMessageLabel.Text = "贵州省";
                }
                else if (str == "53")
                {
                    placeMessageLabel.Text = "云南省";
                }
                else if (str == "54")
                {
                    placeMessageLabel.Text = "西藏自治区";
                }
                else if (str == "61")
                {
                    placeMessageLabel.Text = "陕西省";
                }
                else if (str == "62")
                {
                    placeMessageLabel.Text = "甘肃省";
                }
                else if (str == "63")
                {
                    placeMessageLabel.Text = "青海省";
                }
                else if (str == "64")
                {
                    placeMessageLabel.Text = "宁夏回族自治区";
                }
                else if (str == "65")
                {
                    placeMessageLabel.Text = "新疆维吾尔自治区";
                }
                else if (str == "71")
                {
                    placeMessageLabel.Text = "台湾省";
                }
                else if (str == "81")
                {
                    placeMessageLabel.Text = "香港特别行政区";
                }
                else if (str == "82")
                {
                    placeMessageLabel.Text = "澳门特别行政区";
                }
                else
                {
                    placeMessageLabel.Text = "暂无信息";
                }
            }
            catch
            {
                return;
            }
        }
    }
}
