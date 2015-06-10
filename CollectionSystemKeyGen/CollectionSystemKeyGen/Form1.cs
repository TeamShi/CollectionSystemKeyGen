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
            timeArray[0] = temp[2];
            timeArray[1] = temp[5];
            timeArray[2] = temp[8];
            timeArray[3] = temp[4];
            timeArray[4] = temp[6];
            timeArray[5] = temp[0];
            timeArray[6] = temp[3];
            timeArray[7] = temp[7];
            timeArray[8] = temp[1];
            timeArray[9] = temp[8];

            StringBuilder sb = new StringBuilder();
            sb.Append((char)(30 + (int)timeArray[0]));
            sb.Append((char)(50 + (int)timeArray[1]));
            sb.Append((char)(60 + (int)timeArray[2]));
            sb.Append((char)(40 + (int)timeArray[3]));


        }

        private static double DateTimeToUnixTimestamp(DateTime dateTime)
        {
            return (dateTime - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }

    }
}
