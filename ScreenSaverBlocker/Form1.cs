using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Timers;

namespace ScreenSaverBlocker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            radioButton2.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "user32.dll,LockWorkStation");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScreenSaverBlocker.dll.PreventMonitorPowerdown();
            radioButton1.Checked=true;
            radioButton2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ScreenSaverBlocker.dll.AllowMonitorPowerdown();
            radioButton1.Checked = false;
            radioButton2.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\rundll32.exe", "powrprof.dll,SetSuspendState 0,1,0");
        }
    }
}
