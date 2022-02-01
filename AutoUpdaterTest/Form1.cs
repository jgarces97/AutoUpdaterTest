using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUpdaterDotNET;

namespace AutoUpdaterTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoUpdater.Start("https://clickoncetestvs.blob.core.windows.net/autoupdater/TestUpdate.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Application.ProductVersion.ToString();
        }
    }
}
