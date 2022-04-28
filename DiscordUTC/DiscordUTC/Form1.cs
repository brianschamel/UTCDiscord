using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordUTC
{
    public partial class Form1 : Form
    {
        DateTime epoch;
        public Form1()
        {
            InitializeComponent();
            epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            datePicker.ShowUpDown = true;
            timePicker.ShowUpDown = true;
        }

        private void CopyUTC_Click(object sender, EventArgs e)
        {
            DateTime totalTime = datePicker.Value.Date + timePicker.Value.TimeOfDay;
            double unixTimestamp = ConvertToUnixTimestamp(totalTime);
            
            string discordText = $"<t:{unixTimestamp}>";

            Clipboard.SetText(discordText);
        }
        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return origin.AddSeconds(timestamp);
        }

        public static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }
    }
}
