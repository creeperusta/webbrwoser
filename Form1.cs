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



        private void closebutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closebutton_KeyDown(object sender, KeyEventArgs e)
        {
            closebutton.BackColor = Color.Red;
            closebutton.ForeColor = Color.White;
        }

        private void closebutton_KeyUp(object sender, KeyEventArgs e)
        {
            closebutton.BackColor = Color.White;
            closebutton.ForeColor = Color.Red;
        }
    }
}
