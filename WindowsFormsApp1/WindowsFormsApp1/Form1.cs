using CefSharp.WinForms;
using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser Browser;
        public Form1()
        {
            InitializeComponent();
            InitBrowser();
        }

        private void InitBrowser()
        {
            CefSettings cefSettings = new CefSettings();
            Cef.Initialize(cefSettings);
            Browser = new ChromiumWebBrowser("www.google.com");
            this.panel1.Controls.Add(Browser);  // panel1.
            Browser.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
