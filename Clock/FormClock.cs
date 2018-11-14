using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clock
{
    public partial class FormClock : Form
    {
        public FormClock()
        {
            InitializeComponent();

            timerClock.Enabled = true;
            getTime();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            getTime();
        }

        public void getTime()
        {
            DateTime time = DateTime.Now;
            labelTime.Text = time.Year+"/"+time.Month+"/"+time.Day+"\n\n"+time.Hour + ":" + time.Minute + ":" + time.Second;
        }
    }
}
