using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace webbrwoser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Goadress_Click(object sender, EventArgs e)
        {
            webView.Url = ("www." + Gotoadresse.Text + ".com");
            webView.Url = (httpsadress.Text);
        }


        private void find_Click(object sender, EventArgs e)
        {
            webView.Url = ("https://www.google.com/search?q=" + Gotoadresse.Text);
        }
    }
}
