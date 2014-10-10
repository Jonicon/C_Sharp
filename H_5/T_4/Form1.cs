using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            comboBox1.SelectedItem = "Google.com";
        }

        private void SearchTextbox_KeyUp(object sender, KeyEventArgs e) {
            if (!string.IsNullOrEmpty(SearchTextbox.Text) && e.KeyCode.Equals(Keys.Enter)) {
                string str = SearchTextbox.Text.Replace(' ', '+');
                switch (comboBox1.SelectedIndex) {
                    case 0:
                        webBrowser1.Navigate("https://www.google.com/search?q=" + str);
                        webBrowser1.Focus();
                        break;
                    case 1:
                        webBrowser1.Navigate("https://www.bing.com/search?q=" + str);
                        webBrowser1.Focus();
                        break;
                    case 2:
                        webBrowser1.Navigate("http://search.yahoo.com/search?p=" + str);
                        webBrowser1.Focus();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            // webBrowser1.Url = new Uri("http://www.google.fi");
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(SearchTextbox.Text)) {
                string str = SearchTextbox.Text.Replace(' ', '+');
                switch (comboBox1.SelectedIndex) {
                    case 0:
                        webBrowser1.Navigate("https://www.google.com/search?q=" + str);
                        webBrowser1.Focus();
                        break;
                    case 1:
                        webBrowser1.Navigate("https://www.bing.com/search?q=" + str);
                        webBrowser1.Focus();
                        break;
                    case 2:
                        webBrowser1.Navigate("http://search.yahoo.com/search?p=" + str);
                        webBrowser1.Focus();
                        break;
                    default:
                        break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            webBrowser1.Focus();
        }
    }
}
