using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionSystemKeyGen
{
    public partial class Form1 : Form

        
    {

        private readonly int MAGIC_NUMBER = 239;

        private readonly String FRONT_SALT = "883";
        public Form1()
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            DateTime dt = dateTimePicker1.Value;

            double sec = DateTimeToUnixTimestamp(dateTimePicker1.Value);

            int[] timeArray = new int[10];

            String temp = (sec).ToString();
            StringBuilder sb = new StringBuilder();

            sb.Append(temp[2]).Append(temp[5]).Append(temp[8]).Append(temp[4]).Append(temp[6]).Append(temp[0]).Append(temp[3]).Append(temp[7]).Append(temp[1]).Append(temp[8]);
       
            textBox2.Text = EncodeTimeDate(sb.ToString());
        }

        private static String EncodeTimeDate(String dateString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dateString.Length; i++)
            {
                sb.Append(EncodeChar(dateString[i]));
            }

            return sb.ToString();
        }

        private static double DateTimeToUnixTimestamp(DateTime dateTime)
        {
            return (dateTime - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }

        private static String EncodeChar(char c)
        {
            switch (c)
            {
                case '0':
                    return "X";
                case '1':
                    return "A";
                case '2':
                    return "Z";
                case '3':
                    return "F";
                case '4':
                    return "D";
                case '5':
                    return "G";
                case '6':
                    return "H";
                case '7':
                    return "T";
                case '8':
                    return "R";
                case '9':
                    return "L";
                default:
                    return String.Empty;
       
            }
        }

    }
}
